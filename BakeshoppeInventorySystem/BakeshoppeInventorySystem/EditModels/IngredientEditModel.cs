using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BakeshoppeInventorySystem.Models;
using GalaSoft.MvvmLight;
using System.Windows;
using System.Windows.Input;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.EditModels;
using BakeshoppeInventorySystem.Modules;
using GalaSoft.MvvmLight.CommandWpf;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewIngredientModel : IngredientEditModel
    {
        public NewIngredientModel() : base(new Ingredient())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            Name = string.Empty;
            UnitId = null;
        }
    }

    public class IngredientEditModel : EditModelBase<Ingredient>
    {
        public IngredientEditModel(Ingredient model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int IngredientId
        {
            get { return _ModelCopy.IngredientId; }
            set
            {
                _ModelCopy.IngredientId = value;
                RaisePropertyChanged(nameof(IngredientId));
            }
        }

        public string Name
        {
            get { return _ModelCopy.Name; }
            set
            {
                _ModelCopy.Name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public int? UnitId
        {
            get { return _ModelCopy.UnitId; }
            set
            {
                _ModelCopy.UnitId = value;
                RaisePropertyChanged(nameof(UnitId));
            }
        }

        //public Unit Unit
        //{
        //    get { return ViewModelLocator.ViewModelLocatorStatic.Locator.UnitModule.UnitList(); }
        //}

        private Ingredient CreateCopy(Ingredient model)
        {
            var copy = new Ingredient
            {
                IngredientId = model.IngredientId,
                Name = model.Name,
                UnitId = model.UnitId
            };
            return copy;
        }
    }
}
