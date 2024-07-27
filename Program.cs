using System.Reflection;

namespace FinanceForms
{
    internal static class Program
    {

        internal static App app;
        internal static MainPage MainPage;
        internal static string AppName => "Мониторинг личных финансов";

        internal static string version => Assembly.GetExecutingAssembly().GetName().Version.ToString(3) +
#if DEBUG
            "DEV (release)";
#else
            "(release)";
#endif

        [STAThread]
        static void Main()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),AppName.Replace(" ","_"));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            ApplicationConfiguration.Initialize();

            Startup.Configure();

            Application.Run(app);

        }
    }
}