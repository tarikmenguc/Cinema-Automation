namespace SinemaOto
{
    partial class girisformu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            txtkullaniciadi = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btngiris = new Button();
            chkShowPassword = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 31);
            label1.TabIndex = 0;
            label1.Text = "NetflixandChill.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(97, 123);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Yetkili Kişi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 50);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(561, 0);
            button1.Name = "button1";
            button1.Size = new Size(51, 50);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Location = new Point(220, 127);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(223, 27);
            txtkullaniciadi.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(223, 27);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(152, 161);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 4;
            label3.Text = "Şifre";
            // 
            // btngiris
            // 
            btngiris.Cursor = Cursors.Hand;
            btngiris.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btngiris.Location = new Point(220, 200);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(223, 41);
            btngiris.TabIndex = 6;
            btngiris.Text = "Giriş";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkShowPassword.Location = new Point(449, 170);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(119, 24);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "şifreyi göster";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // girisformu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 316);
            Controls.Add(chkShowPassword);
            Controls.Add(btngiris);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtkullaniciadi);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "girisformu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private TextBox txtkullaniciadi;
        private TextBox txtPassword;
        private Label label3;
        private Button btngiris;
        private CheckBox chkShowPassword;
    }
}
