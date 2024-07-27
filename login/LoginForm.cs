using DB.Models;
using FinanceForms.Service;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace FinanceForms.login
{
    public partial class LoginForm : MaterialForm
    {
        private TaskCompletionSource<bool> result;
        private bool isRegistration { get; set; }
        public LoginForm(TaskCompletionSource<bool> cont)
        {
            result = cont;
            Closing += (t1, t2) => { result.TrySetResult(false); };
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            changeFormType(false);
            changeSubmitBtnEnable();
        }
        void changeFormType(bool isRegistration)
        {
            this.Text = isRegistration ? "Регистрация пользователя" : "Авторизация";
            this.nameText.Visible = isRegistration;
            this.regBtn.Enabled = !isRegistration;
            this.isRegistration = isRegistration;
        }
        void DoLock(bool locking)
        {
            this.loginText.Enabled = locking;
            this.nameText.Enabled = locking;
            this.PasswordText.Enabled = locking;
        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(this.loginText.Text))
            {
                MaterialMessageBox.Show("Заполните поле 'Логин'", "Ошибка!", false, FlexibleMaterialForm.ButtonsPosition.Right);
                return false;
            }
            if (string.IsNullOrWhiteSpace(this.PasswordText.Text))
            {
                MaterialMessageBox.Show("Заполните поле 'Пароль'", "Ошибка!", false, FlexibleMaterialForm.ButtonsPosition.Right);
                return false;
            }
            return true;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            this.DoLock(false);
            if (!this.Valid()) return;
            if (!isRegistration)
            {
                var user = await Program.app._dbContext.Users.FirstOrDefaultAsync(t => t.Login == this.loginText.Text && t.Password == this.PasswordText.Text);
                if (user != null)
                {
                    settings.SetSetting("userId", user.Id.ToString());
                    result.TrySetResult(true);
                }
                else
                {
                    MaterialMessageBox.Show("Такого пользователя не существует, пройдите пожалуйста регистрацию!", "Ошибка!", false, FlexibleMaterialForm.ButtonsPosition.Right);
                    changeFormType(true);
                }
            }
            else
            {
                var user = new User()
                {
                    Login = this.loginText.Text,
                    Password = this.PasswordText.Text,
                    FirstName = this.nameText.Text,
                };

                
                await Program.app._dbContext!.Users.AddAsync(user);
                await Program.app._dbContext.SaveChangesAsync();

                var acc = new Account()
                {
                    AccountName = "Стандартный",
                    AccountType = AccountType.RUB,
                    UserID = user.Id,
                };

                await Program.app._dbContext!.Accounts.AddAsync(acc);
                await Program.app._dbContext.SaveChangesAsync();

                settings.SetSetting("userId", user.Id.ToString());
                result.TrySetResult(true);
            }
            this.DoLock(true);
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            changeFormType(true);
        }

        void changeSubmitBtnEnable()
        {
            if (!string.IsNullOrWhiteSpace(this.loginText.Text) && !string.IsNullOrWhiteSpace(this.PasswordText.Text))
            {
                this.SubmitBtn.Enabled = true;
            }
            else
            {
                this.SubmitBtn.Enabled = false;
            }
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {
            changeSubmitBtnEnable();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            changeSubmitBtnEnable();
        }
    }
}
