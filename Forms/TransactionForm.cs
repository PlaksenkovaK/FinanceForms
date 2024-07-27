using DB.Models;
using FinanceForms.lib;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FinanceForms
{
    public partial class TransactionForm : MaterialForm
    {
        private EventHandler<bool> update { get; set; }
        private bool IsNew { get; set; }
        private int id { get; set; }

        private Transaction transaction { get; set; }

        private Dictionary<int, string> Categories { get; set; } = [];
        private Dictionary<int, string> Accs { get; set; } = [];
        private Dictionary<TransactionType, string> TransactionTypes { get; set; } = [];

        public TransactionForm(EventHandler<bool> update, int id = 0)
        {
            this.IsNew = id == 0;
            this.id = id;
            this.transaction = new Transaction();
            InitializeComponent();
            this.update = update;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Вносить транзакции можно за предудыщие пол года
            this.dateTimePicker1.MaxDate = DateTime.Today;
            this.dateTimePicker1.MinDate = DateTime.Today.AddMonths(-6);

            this.Categories = await Program.app._dbContext.Categories
                .Where(t => t.UserID == null || t.UserID == Program.app.currentUser)
                .ToDictionaryAsync(t => t.Id, k => k.CategoryName);
            this.categoryBox.DataSource = this.Categories.Values.Prepend("Выберите..").ToArray();
            this.Accs = await Program.app._dbContext.Accounts
                .Where(t => t.UserID == Program.app.currentUser)
                .ToDictionaryAsync(t => t.Id, k => k.AccountName);
            this.accountBox.DataSource = this.Accs.Values.ToArray();

            this.TransactionTypes = new Dictionary<TransactionType, string>();
            foreach (var value in Enum.GetValues<TransactionType>())
            {
                TransactionTypes.Add(value, value.GetDisplayName());
            }
            this.typeBox.DataSource = this.TransactionTypes.Values.ToArray();


            if (this.IsNew)
            {
                this.Text = "Создание транзакции";
                this.transaction.UserID = Program.app.currentUser;
                this.dateTimePicker1.Value = DateTime.Today;
                this.deleteBtn.Enabled = false;
            }
            else
            {
                this.Text = "Редактирование транзакции";
                this.transaction = await Program.app._dbContext.Transactions.Include(t => t.Category).Include(t => t.Account).FirstOrDefaultAsync(t => t.Id == this.id && t.UserID == Program.app.currentUser);

                if (this.transaction == null)
                {
                    MaterialMessageBox.Show("Транзакция не найдена");
                    this.Close();
                    return;
                }

                this.name.Text = this.transaction.Name;
                this.description.Text = this.transaction.Description;
                this.dateText.Text = this.transaction.TransactionDate.ToShortDateString();
                this.dateTimePicker1.Value = this.transaction.TransactionDate;
                this.amount.Text = this.transaction.Amount.ToString();
                if (this.transaction.CategoryId != null)
                {
                    this.categoryBox.SelectedItem = this.Categories.FirstOrDefault(t => t.Key == this.transaction.CategoryId).Value;
                }
                if (this.transaction.AccountID != null)
                {
                    this.accountBox.SelectedItem = this.Accs.FirstOrDefault(t => t.Key == this.transaction.AccountID).Value;
                }
                this.typeBox.SelectedItem = this.TransactionTypes.FirstOrDefault(t => t.Key == this.transaction.TransactionType).Value;
            }
        }

        private string? ValidateForm()
        {
            if (this.transaction != null)
            {
                try
                {
                    this.amount.Text = this.amount.Text.Replace(".", ",");
                    this.transaction!.Amount = Convert.ToDouble(this.amount.Text);
                    this.amount.ForeColor = Color.FromArgb(100, 255, 255, 255);
                }
                catch
                {
                    if (string.IsNullOrEmpty(this.amount.Text))
                    {
                        this.transaction!.Amount = 0;
                    }
                    else
                    {
                        return "Сумму заполнять только числовыми значениями";
                    }
                }

                if (this.dateTimePicker1.Value == DateTime.MinValue)
                {
                    return "Заполните дату";
                }
                else
                {
                    this.dateText.ForeColor = Color.FromArgb(100, 255, 255, 255);
                }
                if (this.transaction.TransactionType == TransactionType.expenditure && this.transaction.CategoryId == null)
                {
                    return "Категория должна быть заполнена для тринзакции с типом 'Расход'";
                }
                else
                {
                    this.categoryBox.ForeColor = Color.FromArgb(100, 255, 255, 255);
                }
                if (this.transaction.Amount <= 0)
                {
                    return "Введите нужную сумму";
                }
                else
                {
                    this.amount.ForeColor = Color.FromArgb(100, 255, 255, 255);
                }
            }

            return null;
        }
        private void DateText_TrailingIconClick(object sender, EventArgs e)
        {
            this.dateTimePicker1.Show();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateText.Text = this.dateTimePicker1.Value.ToShortDateString();
            this.transaction.TransactionDate = this.dateTimePicker1.Value;
            this.dateTimePicker1.Visible = false;
        }

        private async void submit_Click(object sender, EventArgs e)
        {
            try
            {
                var valid = this.ValidateForm();
                if (!string.IsNullOrEmpty(valid))
                {
                    MaterialMessageBox.Show(valid);
                    return;
                }

                if (this.IsNew)
                {
                    await Program.app._dbContext.Transactions.AddAsync(this.transaction);
                }
                await Program.app._dbContext.SaveChangesAsync();
                this.update.Invoke(sender, true);
                this.Close();
            }
            catch
            {
                throw;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.transaction.Name = this.name.Text;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            this.transaction.Description = this.description.Text;
        }

        private void accountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.transaction.AccountID = this.Accs.FirstOrDefault(t => t.Value == this.accountBox.SelectedItem?.ToString()).Key;
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.transaction.TransactionType = this.TransactionTypes.FirstOrDefault(t => t.Value == this.typeBox.SelectedItem?.ToString()).Key;
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.transaction.CategoryId = this.Categories.FirstOrDefault(t => t.Value == this.categoryBox.SelectedItem?.ToString()).Key;
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!this.IsNew)
            {
                try
                {
                    Program.app._dbContext.Transactions.Remove(this.transaction);
                    await Program.app._dbContext.SaveChangesAsync();
                    this.update.Invoke(sender,true);
                    this.Close();
                }
                catch 
                {
                    throw;
                }
            }
        }
    }
}
