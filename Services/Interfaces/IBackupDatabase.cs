using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStationDB.Services.Interfaces
{
    public interface IBackupDatabase : IDisposable
    {
        bool BackupMySqlDbToDesktop(string _connectingString);
        bool BackupSQLiteDbToDesktop(string _path);
    }
}
