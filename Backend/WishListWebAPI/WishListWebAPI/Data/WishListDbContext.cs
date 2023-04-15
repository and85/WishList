using Microsoft.EntityFrameworkCore;
using WishListWebAPI.Models;

namespace WishListWebAPI.Data
{
    public class WishListDbContext : DbContext
    {
        public WishListDbContext(DbContextOptions<WishListDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}