using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.Views.Network;
using BakeshoppeInventorySystem.Views.Items;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace BakeshoppeInventorySystem.Modules
{
    public class MainWindowModule : ObservableObject
    {
        private IRepository _repository;
        private LoadTransactionWindow _loadTransactionwindow;
        private ItemsWindow _itemsWindow;

        public MainWindowModule(IRepository repository)
        {
            _repository = repository;
        }

        #region Commands

        public ICommand OpenLoadTransacionWindow => new RelayCommand(OpenLoadTransactionProc);
        public ICommand OpenItemsWindow => new RelayCommand(OpenItemsProc);

        private void OpenLoadTransactionProc()
        {
            _loadTransactionwindow = new LoadTransactionWindow();
            _loadTransactionwindow.Owner = Application.Current.MainWindow;
            _loadTransactionwindow.ShowDialog();
        }

        private void OpenItemsProc()
        {
            _itemsWindow = new ItemsWindow();
            _itemsWindow.Owner = Application.Current.MainWindow;
            _itemsWindow.ShowDialog();
        }

        #endregion
    }
}
