using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess;
using GalaSoft.MvvmLight;

namespace BakeshoppeInventorySystem.Modules
{
    public class UnitModule : ObservableObject
    {
        private IRepository _repository;

        public UnitModule(IRepository repository)
        {
            _repository = repository;
        }
    }
}
