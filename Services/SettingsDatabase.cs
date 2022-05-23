using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetrolStationDB.Database;
using PetrolStationDB.Services.Interfaces;

namespace PetrolStationDB.Services
{
    public class SettingsDatabase : ISettingsDatabase
    {
        public void Dispose()
        {
        }

        public DbContextOptions<_ContextDb> GetDbContextOptions()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("Config\\appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<_ContextDb>();
            var options = optionsBuilder.UseSqlite(connectionString).Options;
            return options;
        }

        public string GetDbPathTofile()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("Config\\appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");
            //MessageBox.Show(connectionString);
            return connectionString;
        }
    }
}
