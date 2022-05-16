using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Services.Interfaces;

namespace PetrolStationDB.Services
{
    public class BackupDatabase : IBackupDatabase
    {
        public bool BackupSQLiteDbToDesktop(string _path)
        {
            //"Data Source=sqlite_petrol_station.db"

            bool result = false;

            try
            {
                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string guidCode = Guid.NewGuid().ToString();
                string shortDate = DateTime.Now.ToShortDateString();

                StringBuilder folderPath = new StringBuilder();
                folderPath.Append(pathDesktop + "\\" + _path + "_" + shortDate.Replace('.', '-') + "_" + guidCode);

                if (!Directory.Exists(folderPath.ToString()))
                {
                    Directory.CreateDirectory(folderPath.ToString());

                    // Копирование файлов
                    string[] strExtensions = new string[] { ".db", ".db-shm", ".db-wal" }; // Расширения файлов

                    // Пути
                    string oldPathFiles = _path;
                    string newPathFile = folderPath.ToString();

                    foreach(var ext in strExtensions)
                    {
                        FileInfo fileInfo = new FileInfo(oldPathFiles + ext);
                        if (fileInfo.Exists)
                        {
                            fileInfo.CopyTo(newPathFile + "\\" + _path + ext);
                        }
                    }
                    
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public void Dispose()
        {
        }
    }
}
