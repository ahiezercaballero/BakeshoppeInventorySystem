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
using BakeshoppeInventorySystem.Views.Stocks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace BakeshoppeInventorySystem.Modules
{
    public class IngredientModule : ObservableObject
    {
        private IRepository _repository;
        private IngredientModel _selectedIngredientModel;
        private AddNewIngredientWindow _addNewIngredientWindow;
        private NewIngredientModel _newIngredient;
        //private int? _unitIndex;

        public IngredientModule(IRepository repository)
        {
            _repository = repository;
            
            LoadIngredients();
            LoadUnits();
        }

        #region Properties

        public ObservableCollection<IngredientModel> IngredientList { get; } = new ObservableCollection<IngredientModel>();
        public ObservableCollection<UnitModel> UnitList { get; } = new ObservableCollection<UnitModel>();


        public IngredientModel SelectedIngredientModel
        {
            get
            {
                return _selectedIngredientModel;
            }
            set
            {
                _selectedIngredientModel = value;

                if (_selectedIngredientModel != null)
                {
                    try
                    {
                        _selectedIngredientModel.EditModel?.Dispose();
                    }
                    catch (ArgumentNullException e)
                    {
                        MessageBox.Show("Error in Null Exception" + e, "SelectedModel");
                    }
                    _selectedIngredientModel.EditModel = new IngredientEditModel(SelectedIngredientModel.Model);
                    if (SelectedIngredientModel.Model.UnitId.HasValue)
                        SelectedIngredientModel.IndexUnit = SelectedIngredientModel.Model.UnitId.Value - 1;
                }
                RaisePropertyChanged(nameof(SelectedIngredientModel));
            }
        }
        public NewIngredientModel NewIngredient
        {
            get { return _newIngredient; }
            set
            {
                _newIngredient = value;
                RaisePropertyChanged(nameof(NewIngredient));
            }
        }
        
        //public int UnitIndex
        //{
        //    get
        //    {
               
        //    }
        //}
        #endregion

        #region Methods

        public void LoadIngredients()
        {
            var ingredients = _repository.Ingredients.GetRange();
            foreach (var ingredient in ingredients)
            {
                IngredientList.Add(new IngredientModel(ingredient, _repository));
            }
        }

        public void LoadUnits()
        {
            var units = _repository.Units.GetRange();
            foreach (var unit in units)
            {
                UnitList.Add(new UnitModel(unit, _repository));
            }
        }

        #endregion

        #region Commands
        #endregion

        #region  Procs
        private void AddIngredientProc()
        {
            NewIngredient = new NewIngredientModel();
            _addNewIngredientWindow = new AddNewIngredientWindow();
            _addNewIngredientWindow.Owner = Application.Current.MainWindow;
            _addNewIngredientWindow.ShowDialog();
        }
        #endregion

        #region Conditions

        #endregion
    }
}
