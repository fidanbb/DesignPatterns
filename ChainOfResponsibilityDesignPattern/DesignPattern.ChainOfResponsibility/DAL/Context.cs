using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LS1LSLB;initial Catalog=DesignPattern1; " +
                "integrated Security=true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
