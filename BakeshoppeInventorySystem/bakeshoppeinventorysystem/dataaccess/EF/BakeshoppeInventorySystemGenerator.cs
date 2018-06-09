﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "BakeshoppeInventorySystem\App.config"
//     Connection String Name: "BakeshoppeInventorySystemContext"
//     Connection String:      "Data Source=localhost\SQLEXPRESS;Initial Catalog=BakeshoppeInventorySystem;Integrated Security=True"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Express Edition (64-bit)
// Database Engine Edition: Express

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace BakeshoppeInventorySystem.DataAccess.EF
{

    #region Unit of work

    public interface IBakeshoppeInventorySystemContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        System.Data.Entity.DbSet<Ingredient> Ingredients { get; set; } // Ingredient
        System.Data.Entity.DbSet<IngredientInventory> IngredientInventories { get; set; } // IngredientInventory
        System.Data.Entity.DbSet<InventoryProfile> InventoryProfiles { get; set; } // InventoryProfile
        System.Data.Entity.DbSet<LoadProfile> LoadProfiles { get; set; } // LoadProfile
        System.Data.Entity.DbSet<LoadTransaction> LoadTransactions { get; set; } // LoadTransaction
        System.Data.Entity.DbSet<Network> Networks { get; set; } // Network
        System.Data.Entity.DbSet<Product> Products { get; set; } // Product
        System.Data.Entity.DbSet<ProductInventory> ProductInventories { get; set; } // ProductInventory
        System.Data.Entity.DbSet<SaleHistory> SaleHistories { get; set; } // SaleHistory
        System.Data.Entity.DbSet<Unit> Units { get; set; } // Unit

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class BakeshoppeInventorySystemContext : System.Data.Entity.DbContext, IBakeshoppeInventorySystemContext
    {
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        public System.Data.Entity.DbSet<Ingredient> Ingredients { get; set; } // Ingredient
        public System.Data.Entity.DbSet<IngredientInventory> IngredientInventories { get; set; } // IngredientInventory
        public System.Data.Entity.DbSet<InventoryProfile> InventoryProfiles { get; set; } // InventoryProfile
        public System.Data.Entity.DbSet<LoadProfile> LoadProfiles { get; set; } // LoadProfile
        public System.Data.Entity.DbSet<LoadTransaction> LoadTransactions { get; set; } // LoadTransaction
        public System.Data.Entity.DbSet<Network> Networks { get; set; } // Network
        public System.Data.Entity.DbSet<Product> Products { get; set; } // Product
        public System.Data.Entity.DbSet<ProductInventory> ProductInventories { get; set; } // ProductInventory
        public System.Data.Entity.DbSet<SaleHistory> SaleHistories { get; set; } // SaleHistory
        public System.Data.Entity.DbSet<Unit> Units { get; set; } // Unit

        static BakeshoppeInventorySystemContext()
        {
            System.Data.Entity.Database.SetInitializer<BakeshoppeInventorySystemContext>(null);
        }

        public BakeshoppeInventorySystemContext()
            : base("Name=BakeshoppeInventorySystemContext")
        {
        }

        public BakeshoppeInventorySystemContext(string connectionString)
            : base(connectionString)
        {
        }

        public BakeshoppeInventorySystemContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public BakeshoppeInventorySystemContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public BakeshoppeInventorySystemContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new IngredientConfiguration());
            modelBuilder.Configurations.Add(new IngredientInventoryConfiguration());
            modelBuilder.Configurations.Add(new InventoryProfileConfiguration());
            modelBuilder.Configurations.Add(new LoadProfileConfiguration());
            modelBuilder.Configurations.Add(new LoadTransactionConfiguration());
            modelBuilder.Configurations.Add(new NetworkConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new SaleHistoryConfiguration());
            modelBuilder.Configurations.Add(new UnitConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new IngredientConfiguration(schema));
            modelBuilder.Configurations.Add(new IngredientInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new InventoryProfileConfiguration(schema));
            modelBuilder.Configurations.Add(new LoadProfileConfiguration(schema));
            modelBuilder.Configurations.Add(new LoadTransactionConfiguration(schema));
            modelBuilder.Configurations.Add(new NetworkConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SaleHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new UnitConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

    #region POCO classes

    // Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class Category
    {
        public int CategoryId { get; set; } // CategoryId (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string Note { get; set; } // Note (length: 300)
    }

    // Ingredient
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class Ingredient
    {
        public int IngredientId { get; set; } // IngredientId (Primary key)
        public int? UnitId { get; set; } // UnitId
        public string Name { get; set; } // Name (length: 50)
    }

    // IngredientInventory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class IngredientInventory
    {
        public int IngredientInventoryId { get; set; } // IngredientInventoryId (Primary key)
        public int? IngredientId { get; set; } // IngredientId
        public int? InventoryProfileId { get; set; } // InventoryProfileId
        public int? CurrQuantity { get; set; } // CurrQuantity
        public int? Differential { get; set; } // Differential
        public int? NewQuantity { get; set; } // NewQuantity
        public System.DateTime? Date { get; set; } // Date
        public string Note { get; set; } // Note (length: 300)
    }

    // InventoryProfile
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class InventoryProfile
    {
        public int InventoryProfileId { get; set; } // InventoryProfileId (Primary key)
        public string Remarks { get; set; } // Remarks (length: 50)
    }

    // LoadProfile
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class LoadProfile
    {
        public int LoadProfileId { get; set; } // LoadProfileId (Primary key)
        public string Remarks { get; set; } // Remarks (length: 300)
    }

    // LoadTransaction
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class LoadTransaction
    {
        public int LoadTransactionId { get; set; } // LoadTransactionId (Primary key)
        public int? NetworkId { get; set; } // NetworkId
        public int? LoadProfileId { get; set; } // LoadProfileId
        public int? AmountBeginning { get; set; } // AmountBeginning
        public int? LoadAmount { get; set; } // LoadAmount
        public int? CurrentBalance { get; set; } // CurrentBalance
        public System.DateTime? Date { get; set; } // Date
    }

    // Network
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class Network
    {
        public int NetworkId { get; set; } // NetworkId (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public double? FeePerTransaction { get; set; } // FeePerTransaction
    }

    // Product
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class Product
    {
        public int ProductId { get; set; } // ProductId (Primary key)
        public int? CategoryId { get; set; } // CategoryId
        public string Name { get; set; } // Name (length: 50)
        public double? Price { get; set; } // Price
    }

    // ProductInventory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class ProductInventory
    {
        public int ProductInventoryId { get; set; } // ProductInventoryId (Primary key)
        public int? ProductId { get; set; } // ProductId
        public int? InventoryProfileId { get; set; } // InventoryProfileId
        public int? CurrQuantity { get; set; } // CurrQuantity
        public int? Differential { get; set; } // Differential
        public int? NewQuantity { get; set; } // NewQuantity
        public System.DateTime? Date { get; set; } // Date
        public string Notes { get; set; } // Notes (length: 100)
    }

    // SaleHistory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class SaleHistory
    {
        public int SaleHistoryId { get; set; } // SaleHistoryId (Primary key)
        public int? ProductId { get; set; } // ProductId
        public int? InitialStock { get; set; } // InitialStock
        public int? LeftOver { get; set; } // LeftOver
        public double? Sales { get; set; } // Sales
        public System.DateTime? Date { get; set; } // Date
        public int? SalesAdjustment { get; set; } // SalesAdjustment
        public string Note { get; set; } // Note (length: 300)
    }

    // Unit
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class Unit
    {
        public int UnitId { get; set; } // UnitId (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string Symbol { get; set; } // Symbol (length: 50)
    }

    #endregion

    #region POCO Configuration

    // Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class CategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
            : this("dbo")
        {
        }

        public CategoryConfiguration(string schema)
        {
            ToTable("Category", schema);
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Note).HasColumnName(@"Note").HasColumnType("nvarchar").IsOptional().HasMaxLength(300);
        }
    }

    // Ingredient
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class IngredientConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ingredient>
    {
        public IngredientConfiguration()
            : this("dbo")
        {
        }

        public IngredientConfiguration(string schema)
        {
            ToTable("Ingredient", schema);
            HasKey(x => x.IngredientId);

            Property(x => x.IngredientId).HasColumnName(@"IngredientId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UnitId).HasColumnName(@"UnitId").HasColumnType("int").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

    // IngredientInventory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class IngredientInventoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IngredientInventory>
    {
        public IngredientInventoryConfiguration()
            : this("dbo")
        {
        }

        public IngredientInventoryConfiguration(string schema)
        {
            ToTable("IngredientInventory", schema);
            HasKey(x => x.IngredientInventoryId);

            Property(x => x.IngredientInventoryId).HasColumnName(@"IngredientInventoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IngredientId).HasColumnName(@"IngredientId").HasColumnType("int").IsOptional();
            Property(x => x.InventoryProfileId).HasColumnName(@"InventoryProfileId").HasColumnType("int").IsOptional();
            Property(x => x.CurrQuantity).HasColumnName(@"CurrQuantity").HasColumnType("int").IsOptional();
            Property(x => x.Differential).HasColumnName(@"Differential").HasColumnType("int").IsOptional();
            Property(x => x.NewQuantity).HasColumnName(@"NewQuantity").HasColumnType("int").IsOptional();
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsOptional();
            Property(x => x.Note).HasColumnName(@"Note").HasColumnType("nvarchar").IsOptional().HasMaxLength(300);
        }
    }

    // InventoryProfile
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class InventoryProfileConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<InventoryProfile>
    {
        public InventoryProfileConfiguration()
            : this("dbo")
        {
        }

        public InventoryProfileConfiguration(string schema)
        {
            ToTable("InventoryProfile", schema);
            HasKey(x => x.InventoryProfileId);

            Property(x => x.InventoryProfileId).HasColumnName(@"InventoryProfileId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Remarks).HasColumnName(@"Remarks").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

    // LoadProfile
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class LoadProfileConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LoadProfile>
    {
        public LoadProfileConfiguration()
            : this("dbo")
        {
        }

        public LoadProfileConfiguration(string schema)
        {
            ToTable("LoadProfile", schema);
            HasKey(x => x.LoadProfileId);

            Property(x => x.LoadProfileId).HasColumnName(@"LoadProfileId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Remarks).HasColumnName(@"Remarks").HasColumnType("nvarchar").IsOptional().HasMaxLength(300);
        }
    }

    // LoadTransaction
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class LoadTransactionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LoadTransaction>
    {
        public LoadTransactionConfiguration()
            : this("dbo")
        {
        }

        public LoadTransactionConfiguration(string schema)
        {
            ToTable("LoadTransaction", schema);
            HasKey(x => x.LoadTransactionId);

            Property(x => x.LoadTransactionId).HasColumnName(@"LoadTransactionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NetworkId).HasColumnName(@"NetworkId").HasColumnType("int").IsOptional();
            Property(x => x.LoadProfileId).HasColumnName(@"LoadProfileId").HasColumnType("int").IsOptional();
            Property(x => x.AmountBeginning).HasColumnName(@"AmountBeginning").HasColumnType("int").IsOptional();
            Property(x => x.LoadAmount).HasColumnName(@"LoadAmount").HasColumnType("int").IsOptional();
            Property(x => x.CurrentBalance).HasColumnName(@"CurrentBalance").HasColumnType("int").IsOptional();
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsOptional();
        }
    }

    // Network
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class NetworkConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Network>
    {
        public NetworkConfiguration()
            : this("dbo")
        {
        }

        public NetworkConfiguration(string schema)
        {
            ToTable("Network", schema);
            HasKey(x => x.NetworkId);

            Property(x => x.NetworkId).HasColumnName(@"NetworkId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.FeePerTransaction).HasColumnName(@"FeePerTransaction").HasColumnType("float").IsOptional();
        }
    }

    // Product
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class ProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
            : this("dbo")
        {
        }

        public ProductConfiguration(string schema)
        {
            ToTable("Product", schema);
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("float").IsOptional();
        }
    }

    // ProductInventory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class ProductInventoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductInventory>
    {
        public ProductInventoryConfiguration()
            : this("dbo")
        {
        }

        public ProductInventoryConfiguration(string schema)
        {
            ToTable("ProductInventory", schema);
            HasKey(x => x.ProductInventoryId);

            Property(x => x.ProductInventoryId).HasColumnName(@"ProductInventoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsOptional();
            Property(x => x.InventoryProfileId).HasColumnName(@"InventoryProfileId").HasColumnType("int").IsOptional();
            Property(x => x.CurrQuantity).HasColumnName(@"CurrQuantity").HasColumnType("int").IsOptional();
            Property(x => x.Differential).HasColumnName(@"Differential").HasColumnType("int").IsOptional();
            Property(x => x.NewQuantity).HasColumnName(@"NewQuantity").HasColumnType("int").IsOptional();
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsOptional();
            Property(x => x.Notes).HasColumnName(@"Notes").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }

    // SaleHistory
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class SaleHistoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SaleHistory>
    {
        public SaleHistoryConfiguration()
            : this("dbo")
        {
        }

        public SaleHistoryConfiguration(string schema)
        {
            ToTable("SaleHistory", schema);
            HasKey(x => x.SaleHistoryId);

            Property(x => x.SaleHistoryId).HasColumnName(@"SaleHistoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsOptional();
            Property(x => x.InitialStock).HasColumnName(@"InitialStock").HasColumnType("int").IsOptional();
            Property(x => x.LeftOver).HasColumnName(@"LeftOver").HasColumnType("int").IsOptional();
            Property(x => x.Sales).HasColumnName(@"Sales").HasColumnType("float").IsOptional();
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("datetime").IsOptional();
            Property(x => x.SalesAdjustment).HasColumnName(@"SalesAdjustment").HasColumnType("int").IsOptional();
            Property(x => x.Note).HasColumnName(@"Note").HasColumnType("nvarchar").IsOptional().HasMaxLength(300);
        }
    }

    // Unit
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.25.0.0")]
    public class UnitConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Unit>
    {
        public UnitConfiguration()
            : this("dbo")
        {
        }

        public UnitConfiguration(string schema)
        {
            ToTable("Unit", schema);
            HasKey(x => x.UnitId);

            Property(x => x.UnitId).HasColumnName(@"UnitId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Symbol).HasColumnName(@"Symbol").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

    #endregion

}
// </auto-generated>

