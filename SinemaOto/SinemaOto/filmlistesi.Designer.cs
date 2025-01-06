namespace SinemaOto
{
    partial class filmlistesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmlistesi));
            groupBox9 = new GroupBox();
            lblidno = new Label();
            lblfilmadi = new Label();
            btnfilm = new Button();
            pbresim = new PictureBox();
            textBox8 = new TextBox();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbresim).BeginInit();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lblidno);
            groupBox9.Controls.Add(lblfilmadi);
            groupBox9.Controls.Add(btnfilm);
            groupBox9.Controls.Add(pbresim);
            groupBox9.Controls.Add(textBox8);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.Indigo;
            groupBox9.Location = new Point(3, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(273, 342);
            groupBox9.TabIndex = 32;
            groupBox9.TabStop = false;
            // 
            // lblidno
            // 
            lblidno.AutoSize = true;
            lblidno.Location = new Point(193, 2);
            lblidno.Name = "lblidno";
            lblidno.Size = new Size(64, 28);
            lblidno.TabIndex = 19;
            lblidno.Text = "label1";
            lblidno.Visible = false;
            // 
            // lblfilmadi
            // 
            lblfilmadi.AutoSize = true;
            lblfilmadi.Location = new Point(13, 0);
            lblfilmadi.Name = "lblfilmadi";
            lblfilmadi.Size = new Size(64, 28);
            lblfilmadi.TabIndex = 18;
            lblfilmadi.Text = "label1";
            lblfilmadi.Click += lblfilmadi_Click;
            // 
            // btnfilm
            // 
            btnfilm.BackColor = Color.Indigo;
            btnfilm.Cursor = Cursors.Hand;
            btnfilm.ForeColor = Color.GhostWhite;
            btnfilm.Location = new Point(13, 279);
            btnfilm.Name = "btnfilm";
            btnfilm.Size = new Size(254, 38);
            btnfilm.TabIndex = 17;
            btnfilm.Text = "Detay";
            btnfilm.UseVisualStyleBackColor = false;
            btnfilm.Click += btnfilm_Click;
            // 
            // pbresim
            // 
            pbresim.Image = (Image)resources.GetObject("pbresim.Image");
            pbresim.Location = new Point(10, 33);
            pbresim.Name = "pbresim";
            pbresim.Size = new Size(257, 240);
            pbresim.SizeMode = PictureBoxSizeMode.Zoom;
            pbresim.TabIndex = 16;
            pbresim.TabStop = false;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Dock = DockStyle.Bottom;
            textBox8.ForeColor = Color.Indigo;
            textBox8.Location = new Point(10, 312);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(260, 27);
            textBox8.TabIndex = 0;
            // 
            // filmlistesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox9);
            Name = "filmlistesi";
            Size = new Size(293, 359);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbresim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox9;
        private Button btnfilm;
        private TextBox textBox8;
        public PictureBox pbresim;
        public Label lblfilmadi;
        public Label lblidno;
    }
}
