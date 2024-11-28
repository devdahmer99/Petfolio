using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Petfolio.Infraestructure.Context;

namespace Petfolio.Infraestructure;
public class PetDbContextFactory : IDesignTimeDbContextFactory<PetDbContext>
{
    public PetDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PetDbContext>();
        optionsBuilder.UseSqlite("Data Source=PortifolioPets.db");

        return new PetDbContext(optionsBuilder.Options);
    }
}
