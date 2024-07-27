namespace FinanceForms.login
{
    partial class LoginForm
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
            LoginCard = new MaterialSkin.Controls.MaterialCard();
            regBtn = new MaterialSkin.Controls.MaterialButton();
            SubmitBtn = new MaterialSkin.Controls.MaterialButton();
            nameText = new MaterialSkin.Controls.MaterialTextBox();
            PasswordText = new MaterialSkin.Controls.MaterialTextBox();
            loginText = new MaterialSkin.Controls.MaterialTextBox();
            LoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // LoginCard
            // 
            LoginCard.BackColor = Color.FromArgb(255, 255, 255);
            LoginCard.Controls.Add(regBtn);
            LoginCard.Controls.Add(SubmitBtn);
            LoginCard.Controls.Add(nameText);
            LoginCard.Controls.Add(PasswordText);
            LoginCard.Controls.Add(loginText);
            LoginCard.Depth = 0;
            LoginCard.Dock = DockStyle.Fill;
            LoginCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            LoginCard.Location = new Point(3, 64);
            LoginCard.Margin = new Padding(14);
            LoginCard.MouseState = MaterialSkin.MouseState.HOVER;
            LoginCard.Name = "LoginCard";
            LoginCard.Padding = new Padding(14);
            LoginCard.Size = new Size(384, 237);
            LoginCard.TabIndex = 1;
            // 
            // regBtn
            // 
            regBtn.AutoSize = false;
            regBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            regBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            regBtn.Depth = 0;
            regBtn.HighEmphasis = true;
            regBtn.Icon = null;
            regBtn.Location = new Point(17, 188);
            regBtn.Margin = new Padding(4, 6, 4, 6);
            regBtn.MouseState = MaterialSkin.MouseState.HOVER;
            regBtn.Name = "regBtn";
            regBtn.NoAccentTextColor = Color.Empty;
            regBtn.Size = new Size(197, 36);
            regBtn.TabIndex = 7;
            regBtn.Text = "Зарегистрироваться";
            regBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            regBtn.UseAccentColor = false;
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.AutoSize = false;
            SubmitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SubmitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SubmitBtn.Depth = 0;
            SubmitBtn.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SubmitBtn.HighEmphasis = true;
            SubmitBtn.Icon = null;
            SubmitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SubmitBtn.ImageKey = "login_40dp.png";
            SubmitBtn.Location = new Point(235, 188);
            SubmitBtn.Margin = new Padding(4, 6, 4, 6);
            SubmitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.NoAccentTextColor = Color.Empty;
            SubmitBtn.Size = new Size(138, 36);
            SubmitBtn.TabIndex = 6;
            SubmitBtn.Text = "Вход";
            SubmitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SubmitBtn.UseAccentColor = false;
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // nameText
            // 
            nameText.AnimateReadOnly = false;
            nameText.BorderStyle = BorderStyle.None;
            nameText.Depth = 0;
            nameText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameText.Hint = "Имя пользователя";
            nameText.LeadingIcon = null;
            nameText.Location = new Point(17, 129);
            nameText.MaxLength = 50;
            nameText.MouseState = MaterialSkin.MouseState.OUT;
            nameText.Multiline = false;
            nameText.Name = "nameText";
            nameText.Size = new Size(356, 50);
            nameText.TabIndex = 3;
            nameText.Text = "";
            nameText.TrailingIcon = null;
            // 
            // PasswordText
            // 
            PasswordText.AnimateReadOnly = false;
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.Depth = 0;
            PasswordText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordText.Hint = "Пароль*";
            PasswordText.LeadingIcon = null;
            PasswordText.Location = new Point(17, 73);
            PasswordText.MaxLength = 25;
            PasswordText.MouseState = MaterialSkin.MouseState.OUT;
            PasswordText.Multiline = false;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(356, 50);
            PasswordText.TabIndex = 2;
            PasswordText.Text = "";
            PasswordText.TrailingIcon = null;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // loginText
            // 
            loginText.AnimateReadOnly = false;
            loginText.BorderStyle = BorderStyle.None;
            loginText.Depth = 0;
            loginText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginText.Hint = "Логин*";
            loginText.LeadingIcon = null;
            loginText.Location = new Point(17, 17);
            loginText.MaxLength = 12;
            loginText.MouseState = MaterialSkin.MouseState.OUT;
            loginText.Multiline = false;
            loginText.Name = "loginText";
            loginText.Size = new Size(356, 50);
            loginText.TabIndex = 1;
            loginText.Text = "";
            loginText.TrailingIcon = null;
            loginText.TextChanged += loginText_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 304);
            Controls.Add(LoginCard);
            Name = "LoginForm";
            Text = "Авторизация";
            Load += LoginForm_Load;
            LoginCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialCard LoginCard;
        private MaterialSkin.Controls.MaterialTextBox PasswordText;
        private MaterialSkin.Controls.MaterialTextBox loginText;
        private MaterialSkin.Controls.MaterialTextBox nameText;
        private MaterialSkin.Controls.MaterialButton SubmitBtn;
        private MaterialSkin.Controls.MaterialButton regBtn;
    }
}