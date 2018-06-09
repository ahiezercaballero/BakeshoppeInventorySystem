using BakeshoppeInventorySystem.DataAccess;
using GalaSoft.MvvmLight;

namespace BakeshoppeInventorySystem.Models
{
    public class ModelBase<T> : ObservableObject
    {
        protected IRepository _Repository;
        public T _model;

        public ModelBase(T model)
        {
            Model = model;
        }

        public ModelBase(T model, IRepository repository)
        {
            Model = model;
            _Repository = repository;
        }

        public T Model
        {
            get { return _model; }
            set
            {
                _model = value;
                RaisePropertyChanged(nameof(Model));
            }
        }
    }
}
