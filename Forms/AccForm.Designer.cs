namespace FinanceForms.Forms
{
    partial class AccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccForm));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            name = new MaterialSkin.Controls.MaterialTextBox();
            type = new MaterialSkin.Controls.MaterialComboBox();
            submit = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(name);
            materialCard1.Controls.Add(type);
            materialCard1.Controls.Add(submit);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 64);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(368, 180);
            materialCard1.TabIndex = 0;
            // 
            // name
            // 
            name.AnimateReadOnly = false;
            name.BorderStyle = BorderStyle.None;
            name.Depth = 0;
            name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name.Hint = "Наименование";
            name.LeadingIcon = null;
            name.Location = new Point(17, 15);
            name.MaxLength = 20;
            name.MouseState = MaterialSkin.MouseState.OUT;
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(334, 50);
            name.TabIndex = 3;
            name.Text = "";
            name.TrailingIcon = null;
            name.TextChanged += name_TextChanged;
            // 
            // type
            // 
            type.AutoResize = false;
            type.BackColor = Color.FromArgb(255, 255, 255);
            type.Depth = 0;
            type.DrawMode = DrawMode.OwnerDrawVariable;
            type.DropDownHeight = 174;
            type.DropDownStyle = ComboBoxStyle.DropDownList;
            type.DropDownWidth = 121;
            type.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            type.ForeColor = Color.FromArgb(222, 0, 0, 0);
            type.FormattingEnabled = true;
            type.Hint = "Тип";
            type.IntegralHeight = false;
            type.ItemHeight = 43;
            type.Location = new Point(17, 71);
            type.MaxDropDownItems = 4;
            type.MouseState = MaterialSkin.MouseState.OUT;
            type.Name = "type";
            type.Size = new Size(334, 49);
            type.StartIndex = 0;
            type.TabIndex = 2;
            type.SelectedIndexChanged += type_SelectedIndexChanged;
            // 
            // submit
            // 
            submit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submit.Depth = 0;
            submit.HighEmphasis = true;
            submit.Icon = Properties.Resources.add_white;
            submit.Location = new Point(214, 129);
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
            // AccForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 247);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccForm";
            Text = "AccForm";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox type;
        private MaterialSkin.Controls.MaterialButton submit;
        private MaterialSkin.Controls.MaterialTextBox name;
    }
}