using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class InventoryProfileModel : ModelBase<InventoryProfile>
    {
        private IRepository _repository;

        public InventoryProfileModel(InventoryProfile model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
