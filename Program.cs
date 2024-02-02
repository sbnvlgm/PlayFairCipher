namespace Coursework_iss
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            /*string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.db"))
            {
                new DB("Data Source=dataBase.db; Version = 3;").InitializeDatabase();
            }*/
            Application.Run(new FormMain());
        }
    }
}