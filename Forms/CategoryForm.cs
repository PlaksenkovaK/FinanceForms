using DB.Models;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace FinanceForms.Forms
{
    public partial class CategoryForm : MaterialForm
    {
        private Category category { get; set; } = new Category();
        public CategoryForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "Создание счета";
            this.category.UserID = Program.app.currentUser;
            this.name.Text = this.category!.CategoryName;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.category.CategoryName = this.name.Text;
        }

        private async Task<string> _validate()
        {
            var isUnic = await Program.app._dbContext.Categories.FirstOrDefaultAsync(t => t.UserID == Program.app.currentUser && this.category.CategoryName == t.CategoryName);
            if (isUnic != null)
            {
                return "Наименование категории должно быть уникальным";
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
                await Program.app._dbContext.Categories.AddAsync(category);
                await Program.app._dbContext.SaveChangesAsync();
                this.Close();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }
    }
}
