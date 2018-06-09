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
    public class LoadTransactionModule : ObservableObject
    {
        private IRepository _repository;
        private NewLoadTransactionModel _newLoadTransaction;
        private NetworkModel _selectedNetworkModel;
        private bool _isCheckedLoad;
        private NewNetworkModel _newNetwork;
        private AddNewNetworkWindow _addNewNetworkWindow;
        private LoadTransactionUserControl _loadTranscationUserControl;
        private int? _currentBalance;

        public LoadTransactionModule(IRepository repository)
        {
            _repository = repository;
            _isCheckedLoad = true;
            NewLoadTransaction = new NewLoadTransactionModel();
            LoadTranscation();
            LoadNetwork();
        }

        #region Properties

        public ObservableCollection<LoadTransactionModel> LoadTransactionList { get; } = new ObservableCollection<LoadTransactionModel>();

        public ObservableCollection<NetworkModel> NetworkList { get; } = new ObservableCollection<NetworkModel>();

        public NewLoadTransactionModel NewLoadTransaction
        {
            get { return _newLoadTransaction; }
            set
            {
                _newLoadTransaction = value;
                RaisePropertyChanged(nameof(NewLoadTransaction));
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

        public NetworkModel SelectedNetworkModel
        {
            get
            {
                return _selectedNetworkModel;
            }
            set
            {
                _selectedNetworkModel = value;
                LoadTranscation();
                RaisePropertyChanged(nameof(SelectedNetworkModel));
            }
        }

        public bool IsCheckedLoad
        {
            get { return _isCheckedLoad; }
            set
            {
                _isCheckedLoad = value;
                RaisePropertyChanged(nameof(IsCheckedLoad));
            }
        }

        public bool IsCheckedReLoad { get; set; }

        public int? CurrentBalance
        {
            get
            {
                return _currentBalance;
            }
            set
            {
                _currentBalance = value;
                RaisePropertyChanged(nameof(CurrentBalance));
            }
        }
        #endregion

        #region Methods

        private void LoadTranscation()
        { 
            if (SelectedNetworkModel != null)
            { 
                LoadTransactionList.Clear();
                var loadtransactions = _repository.LoadTransactions.GetRange(c => c.NetworkId == SelectedNetworkModel.Model.NetworkId);
                foreach (var loadtransaction in loadtransactions)
                {
                    LoadTransactionList.Add(new LoadTransactionModel(loadtransaction, _repository));
                }
                var list = LoadTransactionList.LastOrDefault();
                if (list != null) { CurrentBalance = list.Model.CurrentBalance; }
                else { CurrentBalance = null; }

            }
        }

        private void LoadNetwork()
        {
            NetworkList.Clear();
            var networks = _repository.Networks.GetRange();
            foreach (var network in networks)
            {
                NetworkList.Add(new NetworkModel(network, _repository));
            }

        }

        #endregion

        #region Commands

        public ICommand AddLoadTransactionCommand => new RelayCommand(AddLoadTransactionProc);

        public ICommand FilterByLoadCommand => new RelayCommand(FilterByLoadProc);

        public ICommand FilterByReloadCommand => new RelayCommand(FilterByReloadProc);

        public ICommand RefreshCommand => new RelayCommand(RefreshProc);

        #endregion

        #region Procs


        private void AddLoadTransactionProc()
        {
            //NewLoadTransaction = new NewLoadTransactionModel();
            if (NewLoadTransaction == null) return;
            if (!NewLoadTransaction.HasChanges) return;
            if (LoadTransactionList.Count > 0) NewLoadTransaction.ModelCopy.AmountBeginning = LoadTransactionList[LoadTransactionList.Count - 1].Model.CurrentBalance; 
            if ((IsCheckedLoad == false) && (IsCheckedReLoad == false))
            {
                MessageBox.Show("You need to click an option between Load and Reload.");
                return;
            }
            if (IsCheckedLoad) // Load
            {
                if ((NewLoadTransaction.ModelCopy.AmountBeginning < NewLoadTransaction.ModelCopy.LoadAmount) ||
                    (NewLoadTransaction.ModelCopy.LoadAmount <= 0))
                {
                    MessageBox.Show("You have insufficient load balance.");
                    return;
                }
                NewLoadTransaction.ModelCopy.LoadProfileId = 1;
                NewLoadTransaction.ModelCopy.CurrentBalance = NewLoadTransaction.ModelCopy.AmountBeginning - NewLoadTransaction.ModelCopy.LoadAmount;
            }
            if (IsCheckedReLoad) //Reload
            {
                if (NewLoadTransaction.ModelCopy.LoadAmount <= 0)
                {
                    MessageBox.Show("Error in Amount. You cannot have zero amount.");
                    return;
                }
                NewLoadTransaction.ModelCopy.LoadProfileId = 2;
                NewLoadTransaction.ModelCopy.CurrentBalance = NewLoadTransaction.ModelCopy.AmountBeginning + NewLoadTransaction.ModelCopy.LoadAmount;
            }
            NewLoadTransaction.ModelCopy.NetworkId = SelectedNetworkModel.Model.NetworkId;
            try
            {
                _repository.LoadTransactions.Add(NewLoadTransaction.ModelCopy);
                LoadTransactionList.Add(new LoadTransactionModel(NewLoadTransaction.ModelCopy, _repository));
                CurrentBalance = NewLoadTransaction.ModelCopy.CurrentBalance; 
                MessageBox.Show("Load Transaction has been updated.");


            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred during save. Error: " + e, "Load Transaction");
            }
        }

        private void FilterByReloadProc()
        {
            var viewSailorList = CollectionViewSource.GetDefaultView(LoadTransactionList);
            viewSailorList.Filter =
                obj =>
                    ((LoadTransactionModel)obj).Model.LoadProfileId.Equals(2);
        }

        private void FilterByLoadProc()
        {
            var viewSailorList = CollectionViewSource.GetDefaultView(LoadTransactionList);
            viewSailorList.Filter =
                obj =>
                    ((LoadTransactionModel)obj).Model.LoadProfileId.Equals(1);
        }

        private void RefreshProc()
        {
            _loadTranscationUserControl = new LoadTransactionUserControl();
            LoadNetwork();
            _loadTranscationUserControl.NetworkComboBox.SelectedIndex = 0;
            MessageBox.Show("Your list has been updated.");
        }
        #endregion

    }
}
