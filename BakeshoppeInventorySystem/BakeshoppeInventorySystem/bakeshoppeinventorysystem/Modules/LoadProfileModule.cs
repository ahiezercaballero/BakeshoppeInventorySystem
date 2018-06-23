using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess;
using GalaSoft.MvvmLight;

namespace BakeshoppeInventorySystem.Modules
{
    public class LoadProfileModule : ObservableObject
    {
        private IRepository _repository;

        public LoadProfileModule(IRepository repository)
        {
            _repository = repository;
        }
    }
}
