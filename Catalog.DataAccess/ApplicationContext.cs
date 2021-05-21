using System;
using Catalog.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccess
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        { }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}