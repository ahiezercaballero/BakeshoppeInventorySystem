using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class CategoryModel : ModelBase<Category>
    {
        private IRepository _repository;

        public CategoryModel(Category model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
