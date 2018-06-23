using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class IngredientModel : ModelBase<Ingredient>
    {
        private IRepository _repository;

        public IngredientModel(Ingredient model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
