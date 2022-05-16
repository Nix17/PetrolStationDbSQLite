using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetrolStationDB.Database.Models;

namespace PetrolStationDB.Database
{
    public class _ContextDb: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PetrolStationType> PetrolStationTypes { get; set; }
        public DbSet<PetrolStation> PetrolStations { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MaterialLiability> MaterialLiabilitys { get; set; }

        public _ContextDb()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //MySQL
            /*optionsBuilder.UseMySql(
                "server=localhost;user=root;password=;database=petrol_station;",
                new MySqlServerVersion(new Version(10, 4, 24))
            );*/

            //SQLite
            optionsBuilder.UseSqlite("Data Source=sqlite_petrol_station.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Login);
            modelBuilder.Entity<PetrolStation>().HasAlternateKey(ps => ps.NumberStation);
            modelBuilder.Entity<Employee>().HasAlternateKey(u => u.PersonnelNumber);
        }
    }
}
