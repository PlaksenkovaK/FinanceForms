using DB.Models;
using FinanceForms.lib;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceForms.Forms
{
    public partial class AccForm : MaterialForm
    {
        private Account? account { get; set; } = new Account();
        private EventHandler update;
        private int accId = 0;
        public AccForm(EventHandler update, int id = 0)
        {
            InitializeComponent();
            this.update = update;
            this.accId = id;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.type.DataSource = Enum.GetValues<AccountType>();

            if (this.accId == 0)
            {
                this.Text = "Создание счета";
                this.account!.UserID = Program.app.currentUser;
            }
            else
            {
                this.Text = "Редактирование счета";
                this.account = await Program.app._dbContext.Accounts.FirstOrDefaultAsync(t => t.Id == accId && t.UserID == Program.app.currentUser);

                if (this.account == null)
                {
                    MaterialMessageBox.Show("Счет не найден");
                    this.Close();
                }

                this.name.Text = this.account!.AccountName;
                this.type.SelectedValue = this.account.AccountType;
            }
        }

        private async Task<string> _validate()
        {
            if (this.account == null)
                return "Ошибка валидации";

            var isUnic = await Program.app._dbContext.Accounts.FirstOrDefaultAsync(t => t.UserID == Program.app.currentUser && this.account.AccountName == t.AccountName);
            if (isUnic != null)
            {
                return "Наименование счета должно быть уникальным";
            }
            return string.Empty;
        }

        private async void submit_Click(object sender, EventArgs e)
        {
            try
            {
                var valid = await _validate();
                if (!string.IsNullOrEmpty(valid))
                {
                    throw new Exception(valid);
                }

                if (this.accId == 0 && this.account != null)
                {
                    await Program.app._dbContext.Accounts.AddAsync(account);
                }
                await Program.app._dbContext.SaveChangesAsync();
                this.update.Invoke(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (this.account == null) return;
            this.account.AccountName = name.Text;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.account == null) return;
            this.account.AccountType = (AccountType)this.type.SelectedIndex;
        }
    }
}
