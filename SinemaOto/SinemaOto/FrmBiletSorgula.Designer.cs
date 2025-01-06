namespace SinemaOto
{
    partial class FrmBiletSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletSorgula));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            txtbiletno = new TextBox();
            btnsorgula = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(8);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 62);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(8, 9);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(253, 31);
            label2.TabIndex = 5;
            label2.Text = "Bilet Sorgulama Ekranı";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(466, 0);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(63, 62);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(171, 31);
            label3.TabIndex = 26;
            label3.Text = "Bilet Numarası";
            // 
            // txtbiletno
            // 
            txtbiletno.BorderStyle = BorderStyle.FixedSingle;
            txtbiletno.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtbiletno.Location = new Point(189, 94);
            txtbiletno.Name = "txtbiletno";
            txtbiletno.Size = new Size(262, 32);
            txtbiletno.TabIndex = 27;
            // 
            // btnsorgula
            // 
            btnsorgula.BackColor = Color.DarkRed;
            btnsorgula.Cursor = Cursors.Hand;
            btnsorgula.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnsorgula.Location = new Point(189, 128);
            btnsorgula.Margin = new Padding(8);
            btnsorgula.Name = "btnsorgula";
            btnsorgula.Size = new Size(262, 37);
            btnsorgula.TabIndex = 28;
            btnsorgula.Text = "Sorgula";
            btnsorgula.UseVisualStyleBackColor = false;
            btnsorgula.Click += btnsorgula_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 80);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // FrmBiletSorgula
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(529, 293);
            Controls.Add(pictureBox1);
            Controls.Add(btnsorgula);
            Controls.Add(txtbiletno);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "FrmBiletSorgula";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletSorgula";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox txtbiletno;
        private Button btnsorgula;
        private PictureBox pictureBox1;
    }
}