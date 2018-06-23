using System;
using System.Windows;
using System.Windows.Input;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.EditModels;
using GalaSoft.MvvmLight.CommandWpf;

namespace BakeshoppeInventorySystem.Models
{
    public class IngredientModel : ModelBase<Ingredient>
    {
        private IRepository _repository;
        private IngredientEditModel _editModel;
        private int _indexUnit;

        public IngredientModel(Ingredient model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }

        // For Methods
        // Example of Methods 
        // Mga ana na format kay Methods

        // For Properties
        // Example of properties.
        // SamplePropert{ get; set;}

        // For Commands
        // Example for Commands
        // public ICommand blabla

        // For Conditions
        // Example for Condition
        // From the Command: public ICommand AddCOmmand => new RelayCommand(ProcedureMethod, ConditionMethod)

        //The same for the Modules
        #region Methods



        #endregion


        #region Properties

        public IngredientEditModel EditModel
        {
            get { return _editModel; }
            set
            {
                _editModel = value;
                RaisePropertyChanged(nameof(EditModel));
            }
        }

        public Unit Unit
        {
            get { return _repository.Units.Get(c => c.UnitId == Model.UnitId); }
        }

        public int IndexUnit
        {
            get { return _indexUnit; }
            set
            {
                _indexUnit = value;
                RaisePropertyChanged(nameof(IndexUnit));
            }
        }

        #endregion

        #region Commands



        #endregion

        #region Conditions



        #endregion
    }
}
