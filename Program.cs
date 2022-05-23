using PetrolStationDB.Database;
using PetrolStationDB.Views.ExportToWordView;
using PetrolStationDB.Services;

namespace PetrolStationDB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SettingsDatabase settingsDb = new SettingsDatabase();
            // Начальная инициализация БД
            using (_ContextDb db = new _ContextDb(settingsDb.GetDbContextOptions()))
            {
                DatabaseInitializer dbIni = new DatabaseInitializer(db);
                dbIni.MySeed();
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new authForm());
        }
    }
}