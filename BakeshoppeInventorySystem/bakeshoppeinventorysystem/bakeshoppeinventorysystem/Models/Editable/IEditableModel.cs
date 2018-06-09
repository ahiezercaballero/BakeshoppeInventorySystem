using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BakeshoppeInventorySystem.Models.Editable
{
    public interface IEditableModel<T>
    {
        bool isEditing { get; }
        EditModelBase<T> EditModel { get; }
        ICommand EditCommand { get; }
        ICommand SaveEditCommand { get; }
        ICommand CancelEditCOmmand { get; }
    }
}
