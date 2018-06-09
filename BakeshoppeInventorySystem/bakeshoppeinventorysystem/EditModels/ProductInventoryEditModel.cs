using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewProductInventoryModel : ProductInventoryEditModel
    {
        public NewProductInventoryModel() : base(new ProductInventory())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            InventoryProfileId = null;
            Date = DateTime.Today;
            Differential = 0;
            CurrQuantity = 0;
            NewQuantity = 0;
            ProductId = null;
            Notes = string.Empty;

        }
    }

    public class ProductInventoryEditModel : EditModelBase<ProductInventory>
    {
        public ProductInventoryEditModel(ProductInventory model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int ProductInventoryId
        {
            get { return _ModelCopy.ProductInventoryId; }
            set
            {
                _ModelCopy.ProductInventoryId = value;
                RaisePropertyChanged(nameof(ProductInventoryId));
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

        public DateTime? Date
        {
            get { return _ModelCopy.Date; }
            set
            {
                _ModelCopy.Date = value;
                RaisePropertyChanged(nameof(Date));
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

        public int? CurrQuantity
        {
            get { return _ModelCopy.CurrQuantity; }
            set
            {
                _ModelCopy.CurrQuantity = value;
                RaisePropertyChanged(nameof(CurrQuantity));
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

        public int? ProductId
        {
            get { return _ModelCopy.ProductId; }
            set
            {
                _ModelCopy.ProductId = value;
                RaisePropertyChanged(nameof(ProductId));
            }
        }

        public string Notes
        {
            get { return _ModelCopy.Notes; }
            set
            {
                _ModelCopy.Notes = value;
                RaisePropertyChanged(nameof(Notes));
            }
        }

        private ProductInventory CreateCopy(ProductInventory model)
        {
            var copy = new ProductInventory
            {
                ProductInventoryId = model.ProductInventoryId,
                InventoryProfileId = model.InventoryProfileId,
                Date = model.Date,
                Differential = model.Differential,
                CurrQuantity = model.CurrQuantity,
                NewQuantity = model.NewQuantity,
                ProductId = model.ProductId,
                Notes = model.Notes
            };
            return copy;
        }
    }
}
