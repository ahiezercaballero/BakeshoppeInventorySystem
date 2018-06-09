using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewLoadTransactionModel : LoadTransactionEditModel
    {
        public NewLoadTransactionModel() : base(new LoadTransaction())
        {
            InitializeRequiredFields();
        }

       

        private void InitializeRequiredFields()
        {
            LoadProfileId = null;
            NetworkId = null;
            Date = DateTime.Now;
            AmountBeginning = 0;
            LoadAmount = 0;
            CurrentBalance = 0;
            
        }
    }

    public class LoadTransactionEditModel : EditModelBase<LoadTransaction>
    {
        public LoadTransactionEditModel(LoadTransaction model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int LoadTransactionId
        {
            get { return _ModelCopy.LoadTransactionId; }
            set
            {
                _ModelCopy.LoadTransactionId = value;
                RaisePropertyChanged(nameof(LoadTransactionId));
            }
        }

        public int? LoadProfileId
        {
            get { return _ModelCopy.LoadProfileId; }
            set
            {
                _ModelCopy.LoadProfileId = value;
                RaisePropertyChanged(nameof(LoadProfileId));
            }
        }

        public int? NetworkId
        {
            get { return _ModelCopy.NetworkId; }
            set
            {
                _ModelCopy.NetworkId = value;
                RaisePropertyChanged(nameof(NetworkId));
            }
        }

        public DateTime? Date
        {
            get { return _ModelCopy.Date; }
            set
            {
                _ModelCopy.Date = value;
                RaisePropertyChanged(nameof(Date));
            }
        }

        public int? AmountBeginning
        {
            get { return _ModelCopy.AmountBeginning; }
            set
            {
                _ModelCopy.AmountBeginning = value;
                RaisePropertyChanged(nameof(AmountBeginning));
            }
        }

        public int? LoadAmount
        {
            get { return _ModelCopy.LoadAmount; }
            set
            {
                int? tmp = value;
                int? newValue = ValidateInputAndAddErrors(ref tmp, value, nameof(LoadAmount),
                    () =>
                    {
                        int x;
                        var result = int.TryParse(Convert.ToString(tmp), out x);
                        return !result;
                    }, "This field is required.");
                _ModelCopy.LoadAmount = newValue;
            }
        }

        public int? CurrentBalance
        {
            get { return _ModelCopy.CurrentBalance; }
            set
            {
                _ModelCopy.CurrentBalance = value;
                RaisePropertyChanged(nameof(CurrentBalance));
            }
        }

        private LoadTransaction CreateCopy(LoadTransaction model)
        {
            var copy = new LoadTransaction
            {
                LoadTransactionId = model.LoadTransactionId,
                Date = model.Date,
                LoadProfileId = model.LoadProfileId,
                AmountBeginning = model.AmountBeginning,
                LoadAmount = model.LoadAmount,
                NetworkId = model.NetworkId,
                CurrentBalance = model.CurrentBalance
            };
            return copy;
        }
    }
}
