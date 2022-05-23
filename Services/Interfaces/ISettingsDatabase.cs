using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetrolStationDB.Database;

namespace PetrolStationDB.Services.Interfaces
{
    public interface ISettingsDatabase : IDisposable
    {
        DbContextOptions<_ContextDb> GetDbContextOptions();
        string GetDbPathTofile();
    }
}
