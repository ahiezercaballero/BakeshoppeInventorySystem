using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class ProductInventoryModel : ModelBase<ProductInventory>
    {
        private IRepository _repository;

        public ProductInventoryModel(ProductInventory model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
