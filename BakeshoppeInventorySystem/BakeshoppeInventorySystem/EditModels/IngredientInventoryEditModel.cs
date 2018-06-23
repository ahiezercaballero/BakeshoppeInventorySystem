using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewIngredientInventoryModel : IngredientInventoryEditModel
    {
        public NewIngredientInventoryModel() : base(new IngredientInventory())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            IngredientId = null;
            InventoryProfileId = null;
            CurrQuantity = 0;
            Differential = 0;
            NewQuantity = 0;
            Date = DateTime.Today;
            Note = string.Empty;
        }
    }

    public class IngredientInventoryEditModel : EditModelBase<IngredientInventory>
    {
        public IngredientInventoryEditModel(IngredientInventory model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int IngredientInventoryId
        {
            get { return _ModelCopy.IngredientInventoryId; }
            set
            {
                _ModelCopy.IngredientInventoryId = value;
                RaisePropertyChanged(nameof(IngredientInventoryId));
            }
        }

        public int? IngredientId
        {
            get { return _ModelCopy.IngredientId; }
            set
            {
                _ModelCopy.IngredientId = value;
                RaisePropertyChanged(nameof(IngredientId));
            }
        }

        public int? InventoryProfileId
        {
            get { return _ModelCopy.InventoryProfileId; }
            set
            {
                _ModelCopy.InventoryProfileId = value;
                RaisePropertyChanged(nameof(InventoryProfileId));
            }
        }

        public int? CurrQuantity
        {
            get { return _ModelCopy.CurrQuantity; }
            set
            {
                _ModelCopy.CurrQuantity = value;
                RaisePropertyChanged(nameof(CurrQuantity));
            }
        }

        public int? Differential
        {
            get { return _ModelCopy.Differential; }
            set
            {
                _ModelCopy.Differential = value;
                RaisePropertyChanged(nameof(Differential));
            }
        }

        public int? NewQuantity
        {
            get { return _ModelCopy.NewQuantity; }
            set
            {
                _ModelCopy.NewQuantity = value;
                RaisePropertyChanged(nameof(NewQuantity));
            }
        }

        public DateTime? Date
        {
            get { return _ModelCopy.Date; }
            set
            {
                _ModelCopy.Date = value;
                RaisePropertyChanged(nameof(Date));
            }
        }

        public string Note
        {
            get { return _ModelCopy.Note; }
            set
            {
                _ModelCopy.Note = value;
                RaisePropertyChanged(nameof(Note));
            }
        }

        private IngredientInventory CreateCopy(IngredientInventory model)
        {
            var copy = new IngredientInventory
            {
                IngredientInventoryId = model.IngredientInventoryId,
                IngredientId = model.IngredientId,
                InventoryProfileId = model.InventoryProfileId,
                CurrQuantity = model.CurrQuantity,
                Differential = model.Differential,
                NewQuantity = model.NewQuantity,
                Date = model.Date,
                Note = model.Note
            };
            return copy;
        }
    }
}
