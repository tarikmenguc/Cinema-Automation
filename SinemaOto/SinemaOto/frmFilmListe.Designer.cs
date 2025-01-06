namespace SinemaOto
{
    partial class frmFilmListe
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
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtarama = new TextBox();
            label3 = new Label();
            listepaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 45);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(248, 8);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 5;
            label2.Text = "Film Liste Ekranı";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(556, 0);
            button1.Name = "button1";
            button1.Size = new Size(43, 45);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 31);
            label1.TabIndex = 0;
            label1.Text = "NetflixandChill.com";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtarama);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 45);
            panel2.TabIndex = 7;
            // 
            // txtarama
            // 
            txtarama.BorderStyle = BorderStyle.None;
            txtarama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtarama.ForeColor = Color.Indigo;
            txtarama.Location = new Point(133, 15);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(193, 21);
            txtarama.TabIndex = 1;
            txtarama.TextChanged += txtarama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 0;
            label3.Text = "Film Adı";
            // 
            // listepaneli
            // 
            listepaneli.AutoScroll = true;
            listepaneli.BackColor = Color.White;
            listepaneli.Dock = DockStyle.Fill;
            listepaneli.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            listepaneli.Location = new Point(0, 90);
            listepaneli.Name = "listepaneli";
            listepaneli.Size = new Size(599, 616);
            listepaneli.TabIndex = 8;
            // 
            // frmFilmListe
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(599, 706);
            Controls.Add(listepaneli);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "frmFilmListe";
            StartPosition = FormStartPosition.Manual;
            Text = "Faa";
            Load += frmFilmListe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TextBox txtarama;
        private Label label3;
        private FlowLayoutPanel listepaneli;
    }
}