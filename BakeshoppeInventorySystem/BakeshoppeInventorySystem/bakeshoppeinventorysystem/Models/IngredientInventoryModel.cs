using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class IngredientInventoryModel : ModelBase<IngredientInventory>
    {
        private IRepository _repository;

        public IngredientInventoryModel(IngredientInventory model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
