using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOto
{
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununtarihi();
            filmadigetir();
            salonadigetir();
        }
        void filmadigetir()
        {
            string sorgu = "select DISTINCT filmadı from Tbl_Kontrol ORDER BY filmadı ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                // string gelentarih = rdr["tarih"].ToString();
                cbfilmadi.Items.Add(rdr["filmadı"].ToString());


                //DateTime ftarih = Convert.ToDateTime(gelentarih);
                //DateTime bugun = DateTime.Today;
                //TimeSpan timespan = ftarih - bugun;
                //if (timespan.TotalDays <= 0)
                //{
                //    cbfilmadi.Items.Add(rdr["adı"].ToString());
                //}

            }
            baglanti.Close();

        }

        void salonadigetir()
        {
            string sorgu = "select DISTINCT salonadı from Tbl_Salonlar ORDER BY salonadı ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {

                cbsalon.Items.Add(rdr["salonadı"].ToString());
            }
            baglanti.Close();
            seanskontrol();
        }
        void bugununtarihi()
        {
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyil.Value = DateTime.Today.Year;

        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            if (btnolustur.Text == "Tamamla")
            {
                //
                string sorgu = "select DISTINCT saat  from Tbl_Kontrol WHERE tarih=@tarih AND salonadı=@salonadi";
                string tarih = ngun.Value + "-" + nay.Value + "-" + nyil.Value;
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cbsalon.Text.ToString());
                SqlDataReader rdr = komut.ExecuteReader();
                while (rdr.Read())
                {
                    cbdoolusaatler.Items.Add(rdr["saat"].ToString());
                }
                baglanti.Close();


                btnolustur.Text = "Oluştur";
                btnolustur.BackColor = Color.Blue;
            }
            else
            {
                kaydet();
                    temizle();
                btnolustur.Text = "Tamamla";
                btnolustur.BackColor = Color.Indigo;
            }
        }
        void kaydet()
        {
            string sorgu = "insert into Tbl_Kontrol (filmadı,tarih,saat,salonadı) Values (@filmadi,@tarih,@saat,@salonadi)";
           string tarih=ngun.Value + "-" + nay.Text + "-" + nyil.Value;
            baglanti.Open ();
            SqlCommand ekle = new SqlCommand(sorgu, baglanti);
            ekle.Parameters.AddWithValue("@filmadi",cbfilmadi.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblsecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbsalon.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close ();
            MessageBox.Show("salon atama işlmei gerçekleştirildi");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }
        void temizle()
        {
            cbfilmadi.Items.Clear();
            cbsalon.Items.Clear();
            cbdoolusaatler.Items.Clear();
            lblsecilen.Text = "";
            bugununtarihi();
            filmadigetir();
            salonadigetir();
            flpanel.Controls.Clear();
            btnolustur.Text = "Tamamla";
        }
        private void seanssaatler(object sender,EventArgs e)
        {
            //foreach
            foreach (RadioButton item in flpanel.Controls)
            {
                if (item.Checked)
                {
                    lblsecilen.Text = item.Text.ToString();
                }
            }
        }
        void seanskontrol()
        {
            //test için...
            flpanel.Controls.Clear();
            for (int i = 10; i <= 22; i++) // saat
            {
                for (int j = 0; j <= 30; j += 30)//dakika
                {
                    RadioButton rnd = new RadioButton();
                    rnd.CheckedChanged += new EventHandler(seanssaatler);

                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();

                    }
                    if (cbdoolusaatler.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }

                    flpanel.Controls.Add(rnd);
                }
            }
        }
        private void panelseans_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
