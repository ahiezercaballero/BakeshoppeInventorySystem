using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewCategoryModel : CategoryEditModel
    {
        public NewCategoryModel() : base(new Category())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            Name = null;
            Note = null;
        }
    }
    public class CategoryEditModel : EditModelBase<Category>
    {
        public CategoryEditModel(Category model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int CategoryId
        {
            get { return _ModelCopy.CategoryId; }
            set
            {
                _ModelCopy.CategoryId = value;
                RaisePropertyChanged(nameof(CategoryId));
            }
        }

        public string Name
        {
            get
            {
                return _ModelCopy.Name;
            }
            set
            {
                _ModelCopy.Name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Note
        {
            get
            {
                return _ModelCopy.Note;
            }
            set
            {
                _ModelCopy.Note = value;
                RaisePropertyChanged(nameof(Note));
            }
        }

        private Category CreateCopy(Category model)
        {
            var copy  = new Category()
            {
                CategoryId = model.CategoryId,
                Name = model.Name,
                Note = model.Note
            };
            return copy;
        }
    }
}
