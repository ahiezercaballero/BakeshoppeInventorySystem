using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.Models
{
    public class SaleHistoryModel : ModelBase<SaleHistory>
    {
        private IRepository _repository;

        public SaleHistoryModel(SaleHistory model, IRepository repository) : base(model, repository)
        {
            _repository = repository;
        }
    }
}
