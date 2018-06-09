using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeshoppeInventorySystem.DataAccess.EF;

namespace BakeshoppeInventorySystem.DataAccess
{
    public interface IRepository
    {
        IDataService<Category> Categories { get; }
        IDataService<Ingredient> Ingredients { get; }
        IDataService<IngredientInventory> IngredientInventories { get; }
        IDataService<InventoryProfile> InventoryProfiles { get; }
        IDataService<LoadProfile> LoadProfiles { get; }
        IDataService<LoadTransaction> LoadTransactions { get; }
        IDataService<Network> Networks { get; }
        IDataService<Product> Products { get; }
        IDataService<ProductInventory> ProductInventories { get; }
        IDataService<SaleHistory> SaleHistories { get; }
        IDataService<Unit> Units { get; }
    }
    public class EfRepository : IRepository
    {
        public IDataService<Category> Categories { get; } = new EfDataService<Category>();
        public IDataService<Ingredient> Ingredients { get; } = new EfDataService<Ingredient>();
        public IDataService<IngredientInventory> IngredientInventories { get; } = new EfDataService<IngredientInventory>();
        public IDataService<InventoryProfile> InventoryProfiles { get; } = new EfDataService<InventoryProfile>();
        public IDataService<LoadProfile> LoadProfiles { get; } = new EfDataService<LoadProfile>();
        public IDataService<LoadTransaction> LoadTransactions { get; } = new EfDataService<LoadTransaction>();
        public IDataService<Network> Networks { get; } = new EfDataService<Network>();
        public IDataService<Product> Products { get; } = new EfDataService<Product>();
        public IDataService<ProductInventory> ProductInventories { get; } = new EfDataService<ProductInventory>();
        public IDataService<SaleHistory> SaleHistories { get; } = new EfDataService<SaleHistory>();
        public IDataService<Unit> Units { get; } = new EfDataService<Unit>();
    }
}
