using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewInventoryProfileModel : InventoryProfileEditModel
    {
        public NewInventoryProfileModel() : base(new InventoryProfile())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            Remarks = string.Empty;
        }
    }

    public class InventoryProfileEditModel : EditModelBase<InventoryProfile>
    {
        public InventoryProfileEditModel(InventoryProfile model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int InventoryProfileId
        {
            get { return _ModelCopy.InventoryProfileId; }
            set
            {
                _ModelCopy.InventoryProfileId = value;
                RaisePropertyChanged(nameof(InventoryProfileId));
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
        private InventoryProfile CreateCopy(InventoryProfile model)
        {
            var copy = new InventoryProfile
            {
                InventoryProfileId = model.InventoryProfileId,
                Remarks = model.Remarks
            };
            return copy;
        }
    }
}
