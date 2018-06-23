using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class ProductModel : ModelBase<Product>
    {
        private IRepository _repository;

        public ProductModel(Product model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
