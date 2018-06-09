using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BakeshoppeInventorySystem.DataAccess;

namespace BakeshoppeInventorySystem.Modules
{
    public class ViewModelLocator
    {
        private static readonly IRepository _repository = new EfRepository();

        public ViewModelLocator()
        {
            CategoryModule = new CategoryModule(_repository);
            IngredientInventoryModule = new IngredientInventoryModule(_repository);
            IngredientModule = new IngredientModule(_repository);
            InventoryProfileModule = new InventoryProfileModule(_repository);
            LoadProfileModule = new LoadProfileModule(_repository);
            LoadTransactionModule = new LoadTransactionModule(_repository);
            NetworkModule = new NetworkModule(_repository);
            ProductInventoryModule = new ProductInventoryModule(_repository);
            ProductModule = new ProductModule(_repository);
            SaleHistoryModule = new SaleHistoryModule(_repository);
            UnitModule = new UnitModule(_repository);
            MainWindowModule = new MainWindowModule(_repository);

        }

        public MainWindowModule MainWindowModule { get; }

        public CategoryModule CategoryModule { get; }

        public IngredientInventoryModule IngredientInventoryModule { get; }

        public IngredientModule IngredientModule { get; }

        public InventoryProfileModule InventoryProfileModule { get; }

        public LoadProfileModule LoadProfileModule { get; }

        public LoadTransactionModule LoadTransactionModule { get; }

        public NetworkModule NetworkModule { get; set; }

        public ProductInventoryModule ProductInventoryModule { get; }

        public ProductModule ProductModule { get; }

        public SaleHistoryModule SaleHistoryModule { get; }

        public UnitModule UnitModule { get; }

        public static class ViewModelLocatorStatic
        {
            public static ViewModelLocator Locator = Application.Current.Resources["Locator"] as ViewModelLocator;
        }
    }
}
