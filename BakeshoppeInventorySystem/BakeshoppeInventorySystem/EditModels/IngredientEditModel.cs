using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private Ingredient CreateCopy(Ingredient model)
        {
            var copy = new Ingredient
            {
                IngredientId = _ModelCopy.IngredientId,
                Name = _ModelCopy.Name,
                UnitId = _ModelCopy.UnitId
            };
            return copy;
        }
    }
}
