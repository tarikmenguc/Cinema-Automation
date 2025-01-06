namespace SinemaOto
{
    partial class yonetmenlistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetmenlistesi));
            panel1 = new Panel();
            lbladsoyad = new Label();
            lblıd = new Label();
            pbresimdetay = new PictureBox();
            resimyukle = new Button();
            silbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 135);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lbladsoyad.ForeColor = Color.Indigo;
            lbladsoyad.Location = new Point(162, 10);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(75, 31);
            lbladsoyad.TabIndex = 1;
            lbladsoyad.Text = "label1";
            lbladsoyad.Click += lbladsoyad_Click;
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblıd.ForeColor = Color.Indigo;
            lblıd.Location = new Point(162, 74);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(75, 31);
            lblıd.TabIndex = 2;
            lblıd.Text = "label1";
            lblıd.Visible = false;
            lblıd.Click += lblıd_Click;
            // 
            // pbresimdetay
            // 
            pbresimdetay.Image = (Image)resources.GetObject("pbresimdetay.Image");
            pbresimdetay.Location = new Point(11, 10);
            pbresimdetay.Name = "pbresimdetay";
            pbresimdetay.Size = new Size(125, 122);
            pbresimdetay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbresimdetay.TabIndex = 3;
            pbresimdetay.TabStop = false;
            // 
            // resimyukle
            // 
            resimyukle.BackColor = Color.Indigo;
            resimyukle.Cursor = Cursors.Hand;
            resimyukle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            resimyukle.ForeColor = Color.GhostWhite;
            resimyukle.Location = new Point(374, 92);
            resimyukle.Name = "resimyukle";
            resimyukle.Size = new Size(122, 41);
            resimyukle.TabIndex = 16;
            resimyukle.Text = "DETAY";
            resimyukle.UseVisualStyleBackColor = false;
            resimyukle.Click += resimyukle_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.Indigo;
            silbtn.Cursor = Cursors.Hand;
            silbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            silbtn.ForeColor = Color.CadetBlue;
            silbtn.Location = new Point(499, 92);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(85, 41);
            silbtn.TabIndex = 17;
            silbtn.Text = "SİL";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // yonetmenlistesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(silbtn);
            Controls.Add(resimyukle);
            Controls.Add(pbresimdetay);
            Controls.Add(lblıd);
            Controls.Add(lbladsoyad);
            Controls.Add(panel1);
            Name = "yonetmenlistesi";
            Size = new Size(587, 135);
            ((System.ComponentModel.ISupportInitialize)pbresimdetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lbladsoyad;
        public Label lblıd;
        public PictureBox pbresimdetay;
        private Button resimyukle;
        private Button silbtn;
    }
}
