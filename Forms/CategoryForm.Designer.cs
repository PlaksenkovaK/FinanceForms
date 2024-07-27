namespace FinanceForms.Forms
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            name = new MaterialSkin.Controls.MaterialTextBox();
            submit = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // name
            // 
            name.AnimateReadOnly = false;
            name.BorderStyle = BorderStyle.None;
            name.Depth = 0;
            name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name.Hint = "Наименование";
            name.LeadingIcon = null;
            name.Location = new Point(6, 75);
            name.MaxLength = 20;
            name.MouseState = MaterialSkin.MouseState.OUT;
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(376, 50);
            name.TabIndex = 0;
            name.Text = "";
            name.TrailingIcon = null;
            name.TextChanged += name_TextChanged;
            // 
            // submit
            // 
            submit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submit.Depth = 0;
            submit.HighEmphasis = true;
            submit.Icon = Properties.Resources.add_white;
            submit.Location = new Point(244, 134);
            submit.Margin = new Padding(4, 6, 4, 6);
            submit.MouseState = MaterialSkin.MouseState.HOVER;
            submit.Name = "submit";
            submit.NoAccentTextColor = Color.Empty;
            submit.Size = new Size(137, 36);
            submit.TabIndex = 1;
            submit.Text = "Сохранить";
            submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            submit.UseAccentColor = true;
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 179);
            Controls.Add(submit);
            Controls.Add(name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoryForm";
            Text = "Добавление категории";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox name;
        private MaterialSkin.Controls.MaterialButton submit;
    }
}