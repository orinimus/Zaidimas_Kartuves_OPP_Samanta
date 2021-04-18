using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zaidimas_Kartuves_OPP_Samanta.InitialData;
using Zaidimas_Kartuves_OPP_Samanta.Models;

namespace Zaidimas_Kartuves_OPP_Samanta.Database
{
    public class KartuvesContext: DbContext
    {

        //sukuriamos lenteles arba kitaip repozitoriai visiems susikurtiems modeliams:
        public DbSet<Vardas> Vardai { get; set; }
        public DbSet<Miestas> Miestai { get; set; }
        public DbSet<Valstybe> Valstybes { get; set; }
        public DbSet<Ezeras> Ezerai { get; set; }
        public DbSet<Spejimas> Spejimai { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = KartuviuDuombaze_Samantos"); //tarp kabuciu turi buti idetas SQL Server linkas, taciau del teisiu ilgo nesuteikimo, negaliu jo iterpti
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        { //ieinam i kiekvienos klases lenteles ir pasakom, kad ji turi duomenis is klasiu InitialData database'su
            modelBuilder.Entity<Ezeras>().HasData(EzerasInitialData.DataSeed);
            modelBuilder.Entity<Miestas>().HasData(MiestasInitialData.DataSeed);
            modelBuilder.Entity<Valstybe>().HasData(ValstybeInitialData.DataSeed);
            modelBuilder.Entity<Vardas>().HasData(VardasInitialData.DataSeed);
            modelBuilder.Entity<Spejimas>().HasData(SpejimasInitialData.DataSeed);
        }
    }


}
