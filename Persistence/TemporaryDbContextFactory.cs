using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Persistence
{
    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StoreContext>();
            builder.UseSqlite("Data Source=music.db", optionsBuilder =>
                optionsBuilder.MigrationsAssembly(typeof(StoreContext).GetTypeInfo().Assembly.GetName().Name));
            return new StoreContext(builder.Options);
        }
    }
}