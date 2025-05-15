using Microsoft.EntityFrameworkCore;
using Proyecto_Final_PrograIV.Entities;

namespace Proyecto_Final_PrograIV.FinalProjectDataBase
{
    public class FinalProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "JWTDataBase");
        }

        public DbSet<Candidate> Candidates { get; set; }
        //public DbSet<Company> Companies { get; set; }
        //public DbSet<Offer> Offers { get; set; }
        //public DbSet<Skill> Skills { get; set; }
        //public DbSet<OfferSkill> OfferSkills { get; set; }
    }
}
