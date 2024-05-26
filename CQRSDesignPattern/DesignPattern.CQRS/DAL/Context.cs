using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LS1LSLB;initial Catalog=CQRSDesignPattern; " +
                "integrated Security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
