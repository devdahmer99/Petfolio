using Microsoft.EntityFrameworkCore;
using Petfolio.Infraestructure.Entidades;

namespace Petfolio.Infraestructure.Context;
public class PetDbContext : DbContext
{
    public PetDbContext(DbContextOptions<PetDbContext>options) : base (options)
    {}
    DbSet<Pet> Pets { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
   
}
