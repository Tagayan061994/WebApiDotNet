using Microsoft.EntityFrameworkCore;
using MvcProduct.Models;

namespace MvcProduct.Data
{
    public class MvcProductContext : DbContext
    {
        public MvcProductContext (DbContextOptions<MvcProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}