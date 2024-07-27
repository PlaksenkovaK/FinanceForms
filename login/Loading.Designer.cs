namespace FinanceForms.login
{
    partial class Loading
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
            materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            loadingstate = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            SuspendLayout();
            // 
            // materialProgressBar1
            // 
            materialProgressBar1.Depth = 0;
            materialProgressBar1.Location = new Point(6, 110);
            materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialProgressBar1.Name = "materialProgressBar1";
            materialProgressBar1.Size = new Size(344, 5);
            materialProgressBar1.TabIndex = 0;
            // 
            // loadingstate
            // 
            loadingstate.BackColor = Color.FromArgb(255, 255, 255);
            loadingstate.BorderStyle = BorderStyle.None;
            loadingstate.Depth = 0;
            loadingstate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            loadingstate.ForeColor = Color.FromArgb(222, 0, 0, 0);
            loadingstate.Location = new Point(6, 67);
            loadingstate.MouseState = MaterialSkin.MouseState.HOVER;
            loadingstate.Name = "loadingstate";
            loadingstate.Size = new Size(344, 37);
            loadingstate.TabIndex = 1;
            loadingstate.Text = "";
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 124);
            Controls.Add(loadingstate);
            Controls.Add(materialProgressBar1);
            Name = "Loading";
            Text = "Loading";
            ResumeLayout(false);
        }

        #endregion


    }
}