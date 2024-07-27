namespace FinanceForms
{
    partial class TransactionForm
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
            components = new System.ComponentModel.Container();
            MaterialSkin.Controls.MaterialButton submit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dateTimePicker1 = new DateTimePicker();
            accountBox = new MaterialSkin.Controls.MaterialComboBox();
            typeBox = new MaterialSkin.Controls.MaterialComboBox();
            categoryBox = new MaterialSkin.Controls.MaterialComboBox();
            dateText = new MaterialSkin.Controls.MaterialTextBox();
            amount = new MaterialSkin.Controls.MaterialTextBox();
            description = new MaterialSkin.Controls.MaterialTextBox();
            name = new MaterialSkin.Controls.MaterialTextBox();
            imageList1 = new ImageList(components);
            submit = new MaterialSkin.Controls.MaterialButton();
            deleteBtn = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // submit
            // 
            submit.AutoSize = false;
            submit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            submit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            submit.Depth = 0;
            submit.HighEmphasis = true;
            submit.Icon = Properties.Resources.add_white;
            submit.Location = new Point(522, 285);
            submit.Margin = new Padding(4, 6, 4, 6);
            submit.MouseState = MaterialSkin.MouseState.HOVER;
            submit.Name = "submit";
            submit.NoAccentTextColor = Color.Empty;
            submit.Size = new Size(149, 50);
            submit.TabIndex = 8;
            submit.Text = "Сохранить";
            submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            submit.UseAccentColor = false;
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(deleteBtn);
            materialCard1.Controls.Add(dateTimePicker1);
            materialCard1.Controls.Add(accountBox);
            materialCard1.Controls.Add(typeBox);
            materialCard1.Controls.Add(categoryBox);
            materialCard1.Controls.Add(submit);
            materialCard1.Controls.Add(dateText);
            materialCard1.Controls.Add(amount);
            materialCard1.Controls.Add(description);
            materialCard1.Controls.Add(name);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 64);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(689, 355);
            materialCard1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSize = false;
            deleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteBtn.Depth = 0;
            deleteBtn.HighEmphasis = true;
            deleteBtn.Icon = (Image)resources.GetObject("deleteBtn.Icon");
            deleteBtn.Location = new Point(356, 285);
            deleteBtn.Margin = new Padding(4, 6, 4, 6);
            deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.NoAccentTextColor = Color.Empty;
            deleteBtn.Size = new Size(149, 50);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Удалить";
            deleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteBtn.UseAccentColor = false;
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // accountBox
            // 
            accountBox.AutoResize = false;
            accountBox.BackColor = Color.FromArgb(255, 255, 255);
            accountBox.Depth = 0;
            accountBox.DrawMode = DrawMode.OwnerDrawVariable;
            accountBox.DropDownHeight = 174;
            accountBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accountBox.DropDownWidth = 121;
            accountBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            accountBox.FormattingEnabled = true;
            accountBox.Hint = "Счет*";
            accountBox.IntegralHeight = false;
            accountBox.ItemHeight = 43;
            accountBox.Location = new Point(356, 74);
            accountBox.MaxDropDownItems = 4;
            accountBox.MouseState = MaterialSkin.MouseState.OUT;
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(313, 49);
            accountBox.StartIndex = 0;
            accountBox.TabIndex = 5;
            accountBox.SelectedIndexChanged += accountBox_SelectedIndexChanged;
            // 
            // typeBox
            // 
            typeBox.AutoResize = false;
            typeBox.BackColor = Color.FromArgb(255, 255, 255);
            typeBox.Depth = 0;
            typeBox.DrawMode = DrawMode.OwnerDrawVariable;
            typeBox.DropDownHeight = 174;
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.DropDownWidth = 121;
            typeBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            typeBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            typeBox.FormattingEnabled = true;
            typeBox.Hint = "Тип*";
            typeBox.IntegralHeight = false;
            typeBox.ItemHeight = 43;
            typeBox.Location = new Point(356, 17);
            typeBox.MaxDropDownItems = 4;
            typeBox.MouseState = MaterialSkin.MouseState.OUT;
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(313, 49);
            typeBox.StartIndex = 0;
            typeBox.TabIndex = 3;
            typeBox.SelectedIndexChanged += typeBox_SelectedIndexChanged;
            // 
            // categoryBox
            // 
            categoryBox.AutoResize = false;
            categoryBox.BackColor = Color.FromArgb(255, 255, 255);
            categoryBox.Depth = 0;
            categoryBox.DrawMode = DrawMode.OwnerDrawVariable;
            categoryBox.DropDownHeight = 174;
            categoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryBox.DropDownWidth = 121;
            categoryBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            categoryBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            categoryBox.FormattingEnabled = true;
            categoryBox.Hint = "Категория*";
            categoryBox.IntegralHeight = false;
            categoryBox.ItemHeight = 43;
            categoryBox.Location = new Point(356, 128);
            categoryBox.MaxDropDownItems = 4;
            categoryBox.MouseState = MaterialSkin.MouseState.OUT;
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(313, 49);
            categoryBox.StartIndex = 0;
            categoryBox.TabIndex = 6;
            categoryBox.SelectedIndexChanged += categoryBox_SelectedIndexChanged;
            // 
            // dateText
            // 
            dateText.AnimateReadOnly = true;
            dateText.BorderStyle = BorderStyle.None;
            dateText.Depth = 0;
            dateText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateText.Hint = "Дата*";
            dateText.LeadingIcon = null;
            dateText.Location = new Point(17, 185);
            dateText.MaxLength = 50;
            dateText.MouseState = MaterialSkin.MouseState.OUT;
            dateText.Multiline = false;
            dateText.Name = "dateText";
            dateText.ReadOnly = true;
            dateText.Size = new Size(319, 50);
            dateText.TabIndex = 7;
            dateText.Text = "";
            dateText.TrailingIcon = Properties.Resources.today_40dp;
            dateText.TrailingIconClick += DateText_TrailingIconClick;
            // 
            // amount
            // 
            amount.AnimateReadOnly = false;
            amount.BorderStyle = BorderStyle.None;
            amount.Depth = 0;
            amount.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            amount.Hint = "Сумма*";
            amount.LeadingIcon = null;
            amount.Location = new Point(17, 127);
            amount.MaxLength = 10;
            amount.MouseState = MaterialSkin.MouseState.OUT;
            amount.Multiline = false;
            amount.Name = "amount";
            amount.Size = new Size(319, 50);
            amount.TabIndex = 2;
            amount.Text = "";
            amount.TrailingIcon = null;
            // 
            // description
            // 
            description.AnimateReadOnly = false;
            description.BorderStyle = BorderStyle.None;
            description.Depth = 0;
            description.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            description.Hint = "Описание";
            description.LeadingIcon = null;
            description.Location = new Point(17, 73);
            description.MaxLength = 40;
            description.MouseState = MaterialSkin.MouseState.OUT;
            description.Multiline = false;
            description.Name = "description";
            description.Size = new Size(319, 50);
            description.TabIndex = 1;
            description.Text = "";
            description.TrailingIcon = null;
            description.TextChanged += description_TextChanged;
            // 
            // name
            // 
            name.AnimateReadOnly = false;
            name.BorderStyle = BorderStyle.None;
            name.Depth = 0;
            name.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name.Hint = "Название";
            name.LeadingIcon = null;
            name.Location = new Point(17, 17);
            name.MaxLength = 20;
            name.MouseState = MaterialSkin.MouseState.OUT;
            name.Multiline = false;
            name.Name = "name";
            name.Size = new Size(319, 50);
            name.TabIndex = 0;
            name.Text = "";
            name.TrailingIcon = null;
            name.TextChanged += name_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "today_40dp.png");
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 422);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TransactionForm";
            Text = "Создание транзакции";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton submit;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialTextBox description;
        private MaterialSkin.Controls.MaterialTextBox name;
        private MaterialSkin.Controls.MaterialComboBox categoryBox;
        private MaterialSkin.Controls.MaterialComboBox typeBox;
        private MaterialSkin.Controls.MaterialComboBox accountBox;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialTextBox dateText;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox amount;
        private MaterialSkin.Controls.MaterialButton deleteBtn;
    }
}