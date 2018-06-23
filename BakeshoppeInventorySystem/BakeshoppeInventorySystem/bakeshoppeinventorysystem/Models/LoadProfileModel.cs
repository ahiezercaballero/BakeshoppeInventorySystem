using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class LoadProfileModel : ModelBase<LoadProfile>
    {
        private IRepository _repository;

        public LoadProfileModel(LoadProfile model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
