using System.Globalization;

namespace FinanceForms
{
    internal class Startup
    {
        internal static void Configure()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            try
            {
                CultureInfo ci = new CultureInfo("ru-RU");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;

                CultureInfo.DefaultThreadCurrentCulture = ci;
                CultureInfo.DefaultThreadCurrentUICulture = ci;
            }
            catch (Exception)
            {
                //igonre
            }


            Program.app = new App();

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (Program.app != null)
            {
                Program.app.OnError(sender, e);
            }
            else
            {
                var err = (Exception)e.ExceptionObject;
                MessageBox.Show(string.Format("{0}\n\n\n{1}", err.Message, err.StackTrace),
                "Ошибка!",
                MessageBoxButtons.OK, e.IsTerminating ? MessageBoxIcon.Stop : MessageBoxIcon.Information);
            }
        }
    }
}
