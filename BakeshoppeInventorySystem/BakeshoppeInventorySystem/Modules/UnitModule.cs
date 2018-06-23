using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BakeshoppeInventorySystem.DataAccess;
using BakeshoppeInventorySystem.Models;
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

        #region Properties


        #endregion

        #region Methods



        #endregion
    }
}
