using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePracticeApplication.DataBase.DomainModel;

namespace CorePracticeApplication.DataBase
{
    public class AdventureEntitiesContext : DbContext
    {

        public AdventureEntitiesContext(DbContextOptions<AdventureEntitiesContext> option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ErrorLog>().ToTable("ErrorLog");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<CustomerAddress>().ToTable("CustomerAddress");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<ProductDescription>().ToTable("ProductDescription");
            modelBuilder.Entity<ProductModel>().ToTable("ProductModel");
            modelBuilder.Entity<ProductModelProductDescription>().ToTable("ProductModelProductDescription");
            modelBuilder.Entity<SalesOrderDetail>().ToTable("SalesOrderDetail");
            modelBuilder.Entity<SalesOrderHeader>().ToTable("SalesOrderHeader");
        }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<ProductModelProductDescription> ProductModelProductDescriptions { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        //public virtual DbSet<BuildVersion> BuildVersions { get; set; }
        public virtual DbSet<vGetAllCategory> vGetAllCategories { get; set; }
        public virtual DbSet<vProductAndDescription> vProductAndDescriptions { get; set; }
        public virtual DbSet<vProductModelCatalogDescription> vProductModelCatalogDescriptions { get; set; }

        //[DbFunction("AdventureEntities", "ufnGetAllCategories")]
        //public virtual IQueryable<ufnGetAllCategories_Result> ufnGetAllCategories()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufnGetAllCategories_Result>("[AdventureEntities].[ufnGetAllCategories]()");
        //}

        //[DbFunction("AdventureEntities", "ufnGetCustomerInformation")]
        //public virtual IQueryable<ufnGetCustomerInformation_Result> ufnGetCustomerInformation(Nullable<int> customerID)
        //{
        //    var customerIDParameter = customerID.HasValue ?
        //        new ObjectParameter("CustomerID", customerID) :
        //        new ObjectParameter("CustomerID", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufnGetCustomerInformation_Result>("[AdventureEntities].[ufnGetCustomerInformation](@CustomerID)", customerIDParameter);
        //}

        //public virtual int uspLogError(ObjectParameter errorLogID)
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspLogError", errorLogID);
        //}

        //public virtual int uspPrintError()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspPrintError");
        //}
    }
}
