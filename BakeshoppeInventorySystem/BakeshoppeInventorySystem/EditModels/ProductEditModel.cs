using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewProductModel : ProductEditModel
    {
        public NewProductModel() : base(new Product())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            Price = 0;
            CategoryId = null;
            Name = string.Empty;
        }
    }

    public class ProductEditModel : EditModelBase<Product>
    {
        public ProductEditModel(Product model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int ProductId
        {
            get { return _ModelCopy.ProductId; }
            set
            {
                _ModelCopy.ProductId = value;
                RaisePropertyChanged(nameof(ProductId));
            }
        }

        public int? CategoryId
        {
            get { return _ModelCopy.CategoryId; }
            set
            {
                _ModelCopy.CategoryId = value;
                RaisePropertyChanged(nameof(CategoryId));
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

        public double? Price
        {
            get { return _ModelCopy.Price; }
            set
            {
                _ModelCopy.Price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        private Product CreateCopy(Product model)
        {
            var copy = new Product
            {
                ProductId = model.ProductId,
                CategoryId = model.CategoryId,
                Name = model.Name,
                Price = model.Price
            };
            return copy;
        }
    }
}
