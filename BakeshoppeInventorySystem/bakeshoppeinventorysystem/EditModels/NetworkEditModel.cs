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
            FeePerTransaction = 0;

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
                string tmp = value;
                string newValue = ValidateInputAndAddErrors(ref tmp, value, nameof(Name),
                    () => string.IsNullOrWhiteSpace(value), "Name field is required.");
                _ModelCopy.Name = newValue;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public double? FeePerTransaction
        {
            get { return _ModelCopy.FeePerTransaction; }
            set
            {
                //double? tmp = value;
                //string toStringValue = Convert.ToString(tmp);
                //double? newValue = ValidateInputAndAddErrors(ref tmp, value, nameof(FeePerTransaction),
                //    () =>
                //    {
                //        double x;
                //        var result = double.TryParse(toStringValue, out x);
                //        return !result;
                //    }, "This field is required.");
                //_ModelCopy.FeePerTransaction = newValue;
                _ModelCopy.FeePerTransaction = value;
                RaisePropertyChanged(nameof(FeePerTransaction));
            }
        }

        private Network CreateCopy(Network model)
        {
            var copy = new Network
            {
                NetworkId = model.NetworkId,
                Name = model.Name,
                FeePerTransaction = model.FeePerTransaction
            };
            return copy;
        }
    }
}
