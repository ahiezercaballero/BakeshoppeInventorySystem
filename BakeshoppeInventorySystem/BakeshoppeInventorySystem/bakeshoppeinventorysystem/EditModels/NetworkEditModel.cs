using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewNetworkModel : NetworkEditModel
    {
        public NewNetworkModel() : base(new Network())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            Name = string.Empty;

        }
    }

    public class NetworkEditModel : EditModelBase<Network>
    {
        public NetworkEditModel(Network model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int NetworkId
        {
            get { return _ModelCopy.NetworkId; }
            set
            {
                _ModelCopy.NetworkId = value;
                RaisePropertyChanged(nameof(NetworkId));
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

        private Network CreateCopy(Network model)
        {
            var copy = new Network
            {
                NetworkId = model.NetworkId,
                Name = model.Name
            };
            return copy;
        }
    }
}
