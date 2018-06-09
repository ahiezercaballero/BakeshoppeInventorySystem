using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace BakeshoppeInventorySystem.Models.Editable
{
    public interface IEditModel<out T> : INotifyDataErrorInfo
    {
        T ModelOriginal { get; }
        T ModelCopy { get; }
        bool HasChanges { get; }
        string TopmostError { get; }
    }

    public abstract class EditModelBase<T> : ObservableObject, IEditModel<T>, IDisposable
    {
        private Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        protected T _ModelCopy;
        protected T _ModelOriginal;

        #region Fields

        protected void SetErrors(string propertyName, string propertyError)
        {
            if (_errors.ContainsKey(propertyName))
                _errors[propertyName].Add(propertyError);
            else
            {
                var propertyErrors = new List<string> { propertyError };
                _errors.Add(propertyName, propertyErrors);
            }

            RaisePropertyChanged(nameof(TopmostError));
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected TField ValidateInputAndAddErrors<TField>(ref TField field, TField value, string propertyName,
            Func<bool> invalidInputFilter, string errorMessage, bool storeInvalidInput = true)
        {
            ClearErrors(propertyName);
            bool isValid = !invalidInputFilter();
            if (isValid)
            {

                field = value;
                RaisePropertyChanged(nameof(propertyName));
                return value;
            }

            SetErrors(propertyName, errorMessage);

            if (!storeInvalidInput) return field;
            field = value;

            RaisePropertyChanged(nameof(propertyName));
            return value;
        }

        protected void ClearErrors(string propertyName)
        {
            //Remove the error list for this property
            _errors.Remove(propertyName);

            RaisePropertyChanged(nameof(TopmostError));
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        #endregion

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
                return _errors.Values;
            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        public bool HasErrors => _errors.Count > 0;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public T ModelOriginal
        {
            get { return _ModelOriginal; }
            set
            {
                _ModelOriginal = value;
                RaisePropertyChanged(nameof(ModelOriginal));
            }
        }

        public T ModelCopy
        {
            get { return _ModelCopy; }
            protected set
            {
                _ModelCopy = value;
                RaisePropertyChanged(nameof(ModelCopy));
            }
        }
        public bool HasChanges { get; set; }

        public string TopmostError
        {
            get
            {
                var topmost = _errors.LastOrDefault().Value;
                return (topmost == null) || (topmost.Count == 0) ? string.Empty : topmost[0];
            }
        }

        public void Dispose()
        {
            if (_ModelCopy == null) return;
            PropertyChanged += ModelOnPropertyChanged;
        }

        #region Constructors

        protected EditModelBase(T model)
        {
            PropertyChanged += ModelOnPropertyChanged;
            _ModelOriginal = model;
        }
        private void ModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((e.PropertyName == nameof(HasChanges)) || (e.PropertyName == nameof(ModelCopy))) return;
            HasChanges = true;
        }

        #endregion
    }
}
