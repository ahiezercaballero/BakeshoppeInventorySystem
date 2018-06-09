using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;
using BakeshoppeInventorySystem.Models.Editable;

namespace BakeshoppeInventorySystem.EditModels
{
    public class NewSaleHistoryModel : SaleHistoryEditModel
    {
        public NewSaleHistoryModel() : base(new SaleHistory())
        {
            InitializeRequiredFields();
        }

        private void InitializeRequiredFields()
        {
            ProductId = null;
            Date = DateTime.Today;
            Note = string.Empty;
            InitialStock = 0;
            LeftOver = 0;
            Sales = 0;
            SalesAdjustment = 0;
        }
    }

    public class SaleHistoryEditModel : EditModelBase<SaleHistory>
    {
        public SaleHistoryEditModel(SaleHistory model) : base(model)
        {
            ModelCopy = CreateCopy(model);
        }

        public int SaleHistoryId
        {
            get { return _ModelCopy.SaleHistoryId; }
            set
            {
                _ModelCopy.SaleHistoryId = value;
                RaisePropertyChanged(nameof(SaleHistoryId));
            }
        }

        public int? ProductId
        {
            get { return _ModelCopy.ProductId; }
            set
            {
                _ModelCopy.ProductId = value;
                RaisePropertyChanged(nameof(ProductId));
            }
        }

        public DateTime? Date
        {
            get { return _ModelCopy.Date; }
            set
            {
                _ModelCopy.Date = value;
                RaisePropertyChanged(nameof(Date));
            }
        }

        public string Note
        {
            get { return _ModelCopy.Note; }
            set
            {
                _ModelCopy.Note = value;
                RaisePropertyChanged(nameof(Note));
            }
        }

        public int? InitialStock
        {
            get { return _ModelCopy.InitialStock; }
            set
            {
                _ModelCopy.InitialStock = value;
                RaisePropertyChanged(nameof(InitialStock));
            }
        }

        public int? LeftOver
        {
            get { return _ModelCopy.LeftOver; }
            set
            {
                _ModelCopy.LeftOver = value;
                RaisePropertyChanged(nameof(LeftOver));
            }
        }

        public double? Sales
        {
            get { return _ModelCopy.Sales; }
            set
            {
                _ModelCopy.Sales = value;
                RaisePropertyChanged(nameof(Sales));
            }
        }

        public int? SalesAdjustment
        {
            get { return _ModelCopy.SalesAdjustment; }
            set
            {
                _ModelCopy.SalesAdjustment = value;
                RaisePropertyChanged(nameof(SalesAdjustment));
            }
        }

        private SaleHistory CreateCopy(SaleHistory model)
        {
            var copy = new SaleHistory
            {
                SaleHistoryId = model.SaleHistoryId,
                ProductId = model.ProductId,
                Date = model.Date,
                Note = model.Note,
                InitialStock = model.InitialStock,
                LeftOver = model.LeftOver,
                Sales = model.Sales,
                SalesAdjustment = model.SalesAdjustment
            };
            return copy;
        }
    }
}
