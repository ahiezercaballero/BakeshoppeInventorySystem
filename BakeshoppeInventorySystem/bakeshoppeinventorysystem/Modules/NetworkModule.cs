using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.EditModels;
using BakeshoppeInventorySystem.Models;
using BakeshoppeInventorySystem.Views.Network;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace BakeshoppeInventorySystem.Modules
{
    public class NetworkModule : ObservableObject
    {
        private IRepository _repository;
        private NetworkModel _selectedNetworkModel;
        private AddNewNetworkWindow _addNewNetworkWindow;
        private NewNetworkModel _newNetwork;
        private LoadTransactionModule _loadLoadTransaction;

        public NetworkModule(IRepository repository)
        {
            _repository = repository;
            LoadNetworks();
        }

        #region Properties

        public ObservableCollection<NetworkModel> NetworkList { get; } =  new ObservableCollection<NetworkModel>();

        public NetworkModel SelectedNetworkModel
        {
            get
            {
                
                return _selectedNetworkModel;
            }
            set
            {
                
                _selectedNetworkModel = value;
                if(_selectedNetworkModel != null) { 
                try
                {
                    _selectedNetworkModel.EditModel?.Dispose();
                }
                catch (ArgumentNullException e)
                {
                    MessageBox.Show("Error in Null Exception" + e, "SelectedModel");
                }
                _selectedNetworkModel.EditModel = new NetworkEditModel(SelectedNetworkModel.Model);
                }
                RaisePropertyChanged(nameof(SelectedNetworkModel));
            }
        }

        public NewNetworkModel NewNetwork
        {
            get { return _newNetwork; }
            set
            {
                _newNetwork = value;
                RaisePropertyChanged(nameof(NewNetwork));
            }
        }

        #endregion

        #region Methods

        public void LoadNetworks()
        {
            var networks = _repository.Networks.GetRange();
            foreach (var network in networks)
            {
                NetworkList.Add(new NetworkModel(network, _repository));
            }
        }

        #endregion

        #region Commands

        public ICommand AddNetworkWindow => new RelayCommand(AddNetworkWindowProc);
        public ICommand SaveAddNetworkCommand => new RelayCommand(SaveAddNetworkProc);
        public ICommand CancelAddNetworkCommand => new RelayCommand(CancelAddNetwork);

        public ICommand DeleteNetworkCommand => new RelayCommand(DeleteNetworkProc);

        private void DeleteNetworkProc()
        {
            if (SelectedNetworkModel != null)
            {
                try
                {
                    var x = MessageBox.Show("Are you sure to delete " + SelectedNetworkModel.Model.Name + "? Doing so, will delete all its dependencies as well", "Delete", MessageBoxButton.OKCancel);
                    if (x == MessageBoxResult.OK && SelectedNetworkModel.Model != null)
                    {
                        _repository.Networks.Remove(SelectedNetworkModel.Model);
                        NetworkList.Remove(SelectedNetworkModel);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unable to delete " + SelectedNetworkModel.Model.Name + ".");
                }
            }
        }

        private void CancelAddNetwork()
        {
            NewNetwork?.Dispose();
            _addNewNetworkWindow.Close();
        }

        #endregion

        #region Proc

        private void AddNetworkWindowProc()
        {
            NewNetwork = new NewNetworkModel();
            _addNewNetworkWindow = new AddNewNetworkWindow();
            _addNewNetworkWindow.Owner = Application.Current.MainWindow;
            _addNewNetworkWindow.ShowDialog();
        }

        private void SaveAddNetworkProc()
        {
            if (NewNetwork == null) return;
            if (!NewNetwork.HasChanges) return;
            if (NetworkList.Any(a => a.Model.Name.ToUpper() == NewNetwork.ModelCopy.Name.ToUpper())) { MessageBox.Show("The network has already been listed"); return; }
            

            try
            {
                NewNetwork.ModelCopy.Name = NewNetwork.ModelCopy.Name.ToUpper();
                _repository.Networks.Add(NewNetwork.ModelCopy);
                NetworkList.Add(new NetworkModel(NewNetwork.ModelCopy, _repository));
                MessageBox.Show("You have successfully created a new network.");
                _addNewNetworkWindow.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred during save. Error: " + e, "Network");
            }
        }

        #endregion
    }
}
