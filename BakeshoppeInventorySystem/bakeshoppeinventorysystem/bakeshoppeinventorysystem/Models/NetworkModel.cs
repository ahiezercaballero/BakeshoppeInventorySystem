using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class NetworkModel : ModelBase<Network>
    {
        private IRepository _repository;

        public NetworkModel(Network model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
