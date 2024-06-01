using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LS1LSLB;initial Catalog=MediatorPattern; " +
                "integrated Security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
