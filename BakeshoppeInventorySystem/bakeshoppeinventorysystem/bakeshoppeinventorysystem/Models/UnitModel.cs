using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class UnitModel : ModelBase<Unit>
    {
        private IRepository _repository;

        public UnitModel(Unit model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
