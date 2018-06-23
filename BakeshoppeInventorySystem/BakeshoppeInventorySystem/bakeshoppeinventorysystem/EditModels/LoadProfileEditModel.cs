using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class LoadProfileEditModel : EditModelBase<LoadProfile>
    {
        public LoadProfileEditModel(LoadProfile model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int LoadProfileId
        {
            get { return _ModelCopy.LoadProfileId; }
            set
            {
                _ModelCopy.LoadProfileId = value;
                RaisePropertyChanged(nameof(LoadProfileId));
            }
        }

        public string Remarks
        {
            get { return _ModelCopy.Remarks; }
            set
            {
                _ModelCopy.Remarks = value;
                RaisePropertyChanged(nameof(Remarks));
            }
        }

        private LoadProfile CreateCopy(LoadProfile model)
        {
            var copy = new LoadProfile
            {
                LoadProfileId = _ModelCopy.LoadProfileId,
                Remarks = _ModelCopy.Remarks
            };
            return copy;
        }
    }
}
