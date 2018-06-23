using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewUnitModel : UnitEditModel
    {
        public NewUnitModel() : base(new Unit())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            Name = string.Empty;
            Symbol = string.Empty;
        }
    }

    public class UnitEditModel : EditModelBase<Unit>
    {
        public UnitEditModel(Unit model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int UnitId
        {
            get { return _ModelCopy.UnitId; }
            set
            {
                _ModelCopy.UnitId = value;
                RaisePropertyChanged(nameof(UnitId));
            }
        }

        public string Name
        {
            get { return _ModelCopy.Name; }
            set
            {
                _ModelCopy.Name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Symbol
        {
            get { return _ModelCopy.Symbol; }
            set
            {
                _ModelCopy.Symbol = value;
                RaisePropertyChanged(nameof(Symbol));
            }
        }

        private Unit CreateCopy(Unit model)
        {
            var copy = new Unit
            {
                Name = model.Name,
                UnitId = model.UnitId,
                Symbol = model.Symbol
            };
            return copy;
        }
    }
}
