using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileStoreWebsiteV1._3.Models;

namespace MobileStoreWebsiteV1._3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MobileStoreWebsiteV1._3.Models.Model>? Model { get; set; }
        public DbSet<MobileStoreWebsiteV1._3.Models.Order>? Order { get; set; }
        public DbSet<MobileStoreWebsiteV1._3.Models.Product>? Product { get; set; }

    }
}