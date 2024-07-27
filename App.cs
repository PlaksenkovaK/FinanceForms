using FinanceForms.DB;
using FinanceForms.login;
using FinanceForms.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace FinanceForms
{
    internal class App : ApplicationContext
    {
        internal FinanceDbContext _dbContext;
        internal int currentUser;
        internal App()
        {
            RunLoading();
        }

        private Form RunLoading(bool isDialog = false)
        {
            var lb = Run(new Loading());

            lb.Show();

            lb.Shown += LbOnShown;

            return lb;
        }

        private async Task InitialDB()
        {
            this._dbContext = new FinanceDbContext();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Program.AppName.Replace(" ", "_"));
            var db_file = Path.Combine(path, settings.GetSetting("dbfile", "LocalDb.db"));
            await this._dbContext.Database.MigrateAsync();
        }

        private async void LbOnShown(object _sender, EventArgs _e)
        {
            await Task.Delay(300);

            var lb = (Loading)_sender;

            lb.loadingstate.Text = "Проверяю отпечатки...";
            lb.materialProgressBar1.PerformStep();

            if (this._dbContext == null)
            {
                await InitialDB();
            }


        restart:

            lb.loadingstate.Text = "Ты был тут до этого?";
            lb.materialProgressBar1.PerformStep();

            var userId = settings.GetSetting("userId");

            if (!string.IsNullOrWhiteSpace(userId))
            {
                if (this._dbContext?.Database != null)
                {
                    var user = await this._dbContext.Users.FirstOrDefaultAsync(t => t.Id == Convert.ToInt32(userId));
                    if (user == null)
                    {
                        userId = null;
                        settings.SetSetting("userId", "");
                        MaterialMessageBox.Show(string.Format("{0}\n\n\n{1}", "Пользователь не найден в БД", "Пройдите регастрацию пользователя"), "Ошибка авторизации!", MessageBoxButtons.OK, FlexibleMaterialForm.ButtonsPosition.Right);
                    }
                }
                else
                {
                    throw new Exception("Ошибка получения доступа к базе данных.");
                }

                //TODO:Проверить что пользак существует
                //если не существует settings.SetSetting("jwt", ""); userId = "";
            }

            lb.loadingstate.Text = "Авторизация запуск..";
            lb.materialProgressBar1.PerformStep();
            await Task.Delay(300);

            if (string.IsNullOrWhiteSpace(userId))
            {
                lb.loadingstate.Text = "Жду ввода логина...";

                var logInResult = new TaskCompletionSource<bool>();

                OpenWindows.FirstOrDefault(x => x.GetType() == typeof(LoginForm))?.Close();

                var l = new LoginForm(logInResult);
                Run(l).Show(lb);
                //l.Closed += (object sender, EventArgs e) => { Application.Exit(); };
                l.Closed += (object sender, EventArgs e) => { logInResult.TrySetCanceled(); };
                l.Focus();
                await logInResult.Task;

                goto restart;
            }

            //lb.loadingstate.Text = "Читаю сертификат...";

            lb.loadingstate.Text = "Загружаю ядро...";

            await Task.Delay(300);

            currentUser = Convert.ToInt32(userId);

            this.MainForm = this.OpenWindows.FirstOrDefault(t=>t.GetType() == typeof(MainPage)) ?? Run(Program.MainPage = new MainPage());

            lb.Close();

            if (!this.MainForm.CanFocus)
            {
                MainForm.Show();
            }

            MainForm.Focus();
        }


        private void OnApplicationExit(object sender, EventArgs e)
        {
            // save data
        }

        internal List<Form> OpenWindows = new List<Form>();

        private void OnFormClosed(object sender, EventArgs e)
        {
            OpenWindows.Remove((Form)sender);
            if (OpenWindows.Count == 0)
            {
                ExitThread();
            }
            ((Form)sender).Dispose();
        }

        private void OnFormClosing(object sender, CancelEventArgs e)
        {
            // When a form is closing, remember the form position so it
            // can be saved in the user data file.
        }

        public T Run<T>(T f) where T : MaterialForm
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(f);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey700, Accent.DeepPurple200, TextShade.WHITE);

            OpenWindows.Add(f);
            f.Shown += (sender, args) => { ((MaterialForm)sender!).Activate(); };
            f.Closed += new EventHandler(OnFormClosed!);
            f.Closing += new CancelEventHandler(OnFormClosing!);
            return f;
        }

        public Task<Form> logout()
        {
            settings.SetSetting("userId", "");
            this.currentUser = 0;
            return Task.FromResult(RunLoading(true));
        }

        public void OnError(object sender, UnhandledExceptionEventArgs e)
        {
            var err = (Exception)e.ExceptionObject;
            MaterialMessageBox.Show(string.Format("{0}\n\n\n{1}", err.Message, err.StackTrace),
                "Ошибка!",
                MessageBoxButtons.OK, e.IsTerminating ? MessageBoxIcon.Stop : MessageBoxIcon.Information);
        }
    }
}
