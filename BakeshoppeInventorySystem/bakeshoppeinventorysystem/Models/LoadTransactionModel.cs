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

        // For Methods
        // Example of Methods 
        // Mga ana na format kay Methods

        // For Properties
        // Example of properties.
        // SamplePropert{ get; set;}

        // For Commands
        // Example for Commands
        // public ICommand blabla

        // For Conditions
        // Example for Condition
        // From the Command: public ICommand AddCOmmand => new RelayCommand(ProcedureMethod, ConditionMethod)

        //The same for the Modules
        #region Methods



        #endregion

        #region Properties

        public LoadProfile LoadProfile
        {
            get { return _repository.LoadProfiles.Get(c => c.LoadProfileId == Model.LoadProfileId); }
        }

        public int? CurrentBalance
        {
            get { return Model.CurrentBalance; }
        }

        #endregion

        #region Commands



        #endregion

        #region Conditions



        #endregion
    }
}
