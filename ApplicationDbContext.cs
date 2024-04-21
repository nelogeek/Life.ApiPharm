using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.ApiPharm
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public DbSet<GRLS> GRLS { get; set; }
        public DbSet<PharmaceuticalSubstanceDb> PharmaceuticalSubstances { get; set; }
        public DbSet<NormativeDocDb> NormativeDocs { get; set; }
        public DbSet<ManufacturingInfoDb> ManufacturingInfos { get; set; }
        public DbSet<ManufacturingFormDb> ManufacturingForms { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<InstructionDb> Instructions { get; set; }
        public DbSet<AtgItemDb> AtgItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LifeGRLS;Username=nelogeek;Password=Vbghty*9856");
        }
    }
}
