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



        #endregion

        #region Commands



        #endregion

        #region Conditions



        #endregion
    }
}
