using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class LoadTransactionModel : ModelBase<LoadTransaction>
    {
        private IRepository _repository;

        public LoadTransactionModel(LoadTransaction model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
