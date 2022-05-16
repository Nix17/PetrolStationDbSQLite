using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Services.Interfaces;
//using MySql.Data.MySqlClient;

namespace PetrolStationDB.Services
{
    public class BackupDatabase : IBackupDatabase
    {
        public bool BackupMySqlDbToDesktop(string _connectingString)
        {
            bool result = false;

            /*StringBuilder filePath = new StringBuilder();

            try
            {
                //string constring = "server=localhost;user=root;pwd=;database=petrol_station;";
                
                string constring = _connectingString;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string guidCode = Guid.NewGuid().ToString();
                string shortDate = DateTime.Now.ToShortDateString();
                filePath.Append(path + "\\backup_" + shortDate + "_" + guidCode + ".sql");
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(filePath.ToString());
                            conn.Close();
                        }
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                return false;
            }*/

            return result;
        }

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

        
        
        /*Restore a MySQL database

        private void Restore()
        {
            string constring = "server=localhost;user=root;pwd=qwerty;database=test;";
            string file = "C:\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }
        ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ (Экспорт/импорт БД)
        https://stackoverflow.com/questions/12311492/backing-up-database-in-mysql-using-c-sharp
         */
    }
}
