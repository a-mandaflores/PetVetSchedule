using Microsoft.EntityFrameworkCore;
using PetVetApi.Model;

namespace PetVetApi.Data
{
    public class PetVetContext: DbContext
    {
        public PetVetContext(DbContextOptions<PetVetContext> options) : base(options) { }
        public virtual DbSet<Pet> Pets { get; set; }
    }
}
