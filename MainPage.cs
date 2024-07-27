using DB.Models;
using FinanceForms.Forms;
using FinanceForms.lib;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Windows.Media;

namespace FinanceForms
{
    public partial class MainPage : MaterialForm
    {
        private event EventHandler<bool> _update;
        private event EventHandler AccsUpdHandler;
        private int selectedAcc { get; set; }
        private List<Account> Accs { get; set; } = new();
        private List<Transaction> Transactions { get; set; } = new();
        private bool isLoading = false;
        public MainPage()
        {
            InitializeComponent();

            this._update += this.update;
            this.AccsUpdHandler += this.AccsUpd;
        }
        private async Task Init()
        {
            var selectedAcc = this.Accs.FirstOrDefault(t => t.Id == this.selectedAcc);

            var transactions = await Program.app._dbContext.Transactions.Include(t => t.Category)
                .Where(t => t.CategoryId != null &&
                (t.TransactionDate.Month == this.currentDate.Value.Month && t.TransactionDate.Year == this.currentDate.Value.Year) &&
                t.TransactionType == TransactionType.expenditure &&
                t.UserID == Program.app.currentUser && t.AccountID == this.selectedAcc).ToArrayAsync();

            var fullMoney = (await Program.app._dbContext.Transactions.Where(t => (t.TransactionDate.Month == this.currentDate.Value.Month && t.TransactionDate.Year == this.currentDate.Value.Year) &&
                    t.TransactionType == TransactionType.income &&
                    t.UserID == Program.app.currentUser && t.AccountID == this.selectedAcc)
                .Select(t => t.Amount).ToArrayAsync())?.Sum();

            var fullLeftMoney = transactions.Select(t => t.Amount).Sum();

            if (fullMoney != 0)
            {
                var prog = (int?)((double)fullLeftMoney * 100 / (double)fullMoney);
                this.leftMoneyProgress.Value = prog > 100 ? 100 : prog ?? 0;
                this.MoneyLabelProg.Value = prog > 100 ? 100 : prog ?? 0;
            }
            else
            {
                this.leftMoneyProgress.Value = 0;
                this.MoneyLabelProg.Value = 0;
            }

            this.moneyLabelProgText.Text = $"{this.MoneyLabelProg.Value}% бюджета израсходовано";
            this.leftMoneyProgLabel.Text = $"{this.leftMoneyProgress.Value}% бюджета израсходовано";
            this.leftmoney.Text = $"{fullLeftMoney}{selectedAcc?.AccountType.GetDisplayName()}";
            this.moneyLabel.Text = $"{fullMoney}{selectedAcc?.AccountType.GetDisplayName()}";
            this.savedMoney.Text = $"{fullMoney - fullLeftMoney}{selectedAcc?.AccountType.GetDisplayName()}";

            #region Charts
            var dict = new Dictionary<string, double>();
            foreach (var category in transactions.Select(t => t.Category?.CategoryName).Distinct())
            {
                var sum = transactions.Where(t => t.Category?.CategoryName == category).Select(t => t.Amount).Sum();
                dict.Add(category, sum);
            }
            this.categoriesChart.Series =
            [
                new ColumnSeries
                {
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb((((int)Accent.DeepPurple200) & 0xFF0000) >> 16, (((int)Accent.DeepPurple200) & 0xFF00) >> 8, ((int)Accent.DeepPurple200) & 0xFF)),
                    Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(232, 232, 232)),
                    DataLabels = true,
                    Title = "Расход",
                    Values = new ChartValues<double>(dict.Values)
                },
            ];

            this.categoriesChart.AxisX =
            [
                .. new List<Axis>
                {
                    new Axis
                    {
                        Labels = dict.Keys.ToArray(),
                    }
                }
            ];

            //
            //date 
            //
            var dict2 = new Dictionary<string, double>();
            foreach (var date in transactions.Select(t => t.TransactionDate).Distinct())
            {
                var sum = transactions.Where(t => t.TransactionDate == date).Select(t => t.Amount).Sum();
                dict2.Add(date.ToShortDateString(), sum);
            }

            this.dateChart.Series =
            [
                new ColumnSeries
                {
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb((((int)Accent.DeepPurple200) & 0xFF0000) >> 16, (((int)Accent.DeepPurple200) & 0xFF00) >> 8, ((int)Accent.DeepPurple200) & 0xFF)),
                    Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(232, 232, 232)),
                    DataLabels = true,
                    Title = "Расход",
                    Values = new ChartValues<double>(dict2.Values)
                }
            ];

            this.dateChart.AxisX =
            [
                .. new List<Axis>
                {
                    new Axis
                    {
                        Labels = dict2.Keys.ToArray(),
                    }
                },
            ];
            #endregion
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var user = await Program.app._dbContext.Users.Where(t => t.Id == Program.app.currentUser).Select(t => string.IsNullOrWhiteSpace(t.FirstName) ? t.Login : t.FirstName).FirstOrDefaultAsync();

            this.Text = "Мониторинг личных финансов" + (string.IsNullOrWhiteSpace(user) ? $" - Привет,{user}" : "");

            this.selectedAcc = 1;

            await SetAccs();

            currentDate.MinDate = DateTime.Today.AddYears(-2);
            currentDate.MaxDate = DateTime.Today;

            currentDate.CustomFormat = "MMMM/yyyy";
            currentDate.Format = DateTimePickerFormat.Custom;

            currentDate.Value = DateTime.Today;

            currentDate.ShowUpDown = true;

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this._update -= this.update;
            this.AccsUpdHandler -= this.AccsUpd;
            Program.app._dbContext?.Dispose();
            Program.app._dbContext = null;
        }
        private void addCategory_Click(object sender, EventArgs e)
        {
            var trForm = Program.app.Run(new CategoryForm());
            trForm.ShowDialog();
            trForm.Focus();
        }
        private void addAcc_Click(object sender, EventArgs e)
        {
            var trForm = Program.app.Run(new AccForm(this.AccsUpdHandler));
            trForm.ShowDialog();
            trForm.Focus();
        }
        private void addTrantaction_Click(object sender, EventArgs e)
        {
            var trForm = Program.app.Run(new TransactionForm(this._update));
            trForm.ShowDialog();
            trForm.Focus();
        }
        private async void update(object sender, bool e)
        {
            if (e)
            {
                await this.Init();
                await this.SetTrs();
            }
        }



        private async Task SetAccs()
        {
            this.Accs = await Program.app._dbContext.Accounts.Include(t => t.Transactions.Where(t => t.TransactionDate.Month == DateTime.Today.Month))
                           .Where(t => t.UserID == Program.app.currentUser)
                           .OrderBy(t => t.Id)
                           .ToListAsync();
            this.accsComboBox.DataSource = Accs.Select(t => t.AccountName).ToArray();


            //Table
            this.accsListView.Items.Clear();
            var itemsList = this.Accs.Select(t => new System.Windows.Forms.ListViewItem(
                new string[] {
                t.Id.ToString(),
                t.AccountName,
                t.AccountType.ToString(),
                (t.Transactions.Where(t=>t.TransactionType == TransactionType.income).Select(t=>t.Amount).Sum() -
                                t.Transactions.Where(t=>t.TransactionType == TransactionType.expenditure).Select(t=>t.Amount).Sum()).ToString() + t.AccountType.GetDisplayName(),
                })).ToArray();
            this.accsListView.Items.AddRange(itemsList);
            this.deleteMenuItem.Enabled = false;
        }
        private async void AccsUpd(object sender, EventArgs e)
        {
            await this.SetAccs();
        }
        private async void accsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = this.Accs?.FirstOrDefault(t => t.AccountName == this.accsComboBox.SelectedValue?.ToString());
            if (value != null && this.selectedAcc != value?.Id)
            {
                this.selectedAcc = value?.Id ?? 1;
                await this.Init();
            }
        }

        private async void selectedTabChange(object sender, EventArgs e)
        {
            if (this.tabs.SelectedTab?.Name == logout.Name)
            {
                this.logOut();
            }

            if (this.tabs.SelectedTab?.Name == this.accsCollection.Name)
            {
                await this.SetAccs();
            }

            if (this.tabs.SelectedTab?.Name == this.tabPage2.Name)
            {
                await this.SetTrs();
            }
        }

        private async void DateChange(object sender, EventArgs e)
        {
            if (isLoading) return;
            isLoading = true;
            this.Enabled = false;
            await this.Init();
            this.Enabled = true;
            isLoading = false;
        }

        private async Task SetTrs()
        {
            if (isLoading) return;
            isLoading = true;
            this.Transactions = await Program.app._dbContext.Transactions.Include(t => t.Category).Include(t => t.Account)
                .Where(t => t.UserID == Program.app.currentUser)
                .ToListAsync();
            var itemsList = this.Transactions.Select(t => new System.Windows.Forms.ListViewItem(
                new string[] {
                t.Id.ToString(),
                t.Name ?? "-",
                t.Description ?? "-",
                t.Account?.AccountName ?? "-",
                t.Amount.ToString() + t.Account?.AccountType.GetDisplayName(),
                t.TransactionDate.ToShortDateString(),
                t.Category?.CategoryName ?? "-",
                t.TransactionType.GetDisplayName()
                })).ToArray();
            this.transactionList.Items.Clear();
            this.transactionList.Items.AddRange(itemsList);
            this.deleteTrMenuItem.Enabled = false;
            this.showMenuItem.Enabled = false;
            isLoading = false;
        }

        private async void logOut()
        {
            if (isLoading) return;
            isLoading = true;
            this.Enabled = false;
            var loginForm = await Program.app.logout();
            loginForm.FormClosed += async (_, e) =>
            {
                this.Enabled = true;
                await SetAccs();
                await Init();
                this.tabs.SelectedTab = this.tabPage1;
                isLoading = false;
            };
        }

        private void AccsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = this.accsListView.SelectedItems;
            if (selectedItems.Count == 1)
            {
                this.deleteMenuItem.Enabled = true;
            }
            else
            {
                this.deleteMenuItem.Enabled = false;
            }
        }
        private void TransactionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = this.transactionList.SelectedItems;
            if (selectedItems.Count == 1)
            {
                this.deleteTrMenuItem.Enabled = true;
                this.showMenuItem.Enabled = true;
            }
            else
            {
                this.deleteTrMenuItem.Enabled = false;
                this.showMenuItem.Enabled = false;
            }
        }

        private async void DeleteTRMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(this.transactionList.FocusedItem?.Text);
            var deleted = this.Transactions.FirstOrDefault(t => t.Id == id);
            if (deleted != null)
            {
                Program.app._dbContext.Transactions.Remove(deleted);
                await Program.app._dbContext.SaveChangesAsync();
                await this.SetTrs();
                await Init();
            }
        }

        private void ShowTRMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(this.transactionList.FocusedItem?.Text);
                var form = Program.app.Run(new TransactionForm(this._update, id));
                form.ShowDialog();
                form.Focus();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message,"Ошибка!");
            }
        }

        private async void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(this.accsListView.FocusedItem?.Text);
            var deletedAcc = this.Accs.FirstOrDefault(t => t.Id == id);
            if (deletedAcc != null)
            {
                Program.app._dbContext.Accounts.Remove(deletedAcc);
                await Program.app._dbContext.SaveChangesAsync();
                await this.SetAccs();
            }
        }

    }
}
