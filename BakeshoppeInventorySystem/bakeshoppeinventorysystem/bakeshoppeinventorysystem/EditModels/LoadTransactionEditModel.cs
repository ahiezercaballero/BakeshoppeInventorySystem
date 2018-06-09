using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
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
            Date = DateTime.Today;
            CurrBalance = 0;
            LoadAmount = 0;
            NewBalance = 0;
            PaidAmount = 0;
            
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

        public int? CurrBalance
        {
            get { return _ModelCopy.CurrBalance; }
            set
            {
                _ModelCopy.CurrBalance = value;
                RaisePropertyChanged(nameof(CurrBalance));
            }
        }

        public int? LoadAmount
        {
            get { return _ModelCopy.LoadAmount; }
            set
            {
                _ModelCopy.LoadAmount = value;
                RaisePropertyChanged(nameof(LoadAmount));
            }
        }

        public int? NewBalance
        {
            get { return _ModelCopy.NewBalance; }
            set
            {
                _ModelCopy.NewBalance = value;
                RaisePropertyChanged(nameof(NewBalance));
            }
        }

        public int? PaidAmount
        {
            get { return _ModelCopy.PaidAmount; }
            set
            {
                _ModelCopy.PaidAmount = value; 
                RaisePropertyChanged(nameof(PaidAmount));
            }
        }

        private LoadTransaction CreateCopy(LoadTransaction model)
        {
            var copy = new LoadTransaction
            {
                LoadTransactionId = model.LoadTransactionId,
                Date = model.Date,
                LoadProfileId = model.LoadProfileId,
                CurrBalance = model.CurrBalance,
                LoadAmount = model.LoadAmount,
                NetworkId = model.NetworkId,
                NewBalance = model.NewBalance,
                PaidAmount = model.PaidAmount
            };
            return copy;
        }
    }
}
