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
    public partial class Oyunculistesi : Form
    {
        public Oyunculistesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listepaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Oyunculistesi_Load_1(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Tbl_Oyuncular ORDER BY adsoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                //işlemlerini gerçekleştireceksin
                OyuncuListeleri arac = new OyuncuListeleri();
                arac.lbladsoyad.Text = oku["adsoyad"].ToString();
                arac.lblıd.Text = oku["ID"].ToString();
                arac.pbresimdetay.ImageLocation = oku["resim"].ToString();
                listepaneli.Controls.Add(arac);

            }

            baglanti.Close();
        }

        private void txtarama_TextChanged_1(object sender, EventArgs e)
        { 
            Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Oyuncular Where adsoyad LIKE '%" + txtarama.Text + "%' ORDER  BY adsoyad ASC ", baglanti);
            SqlDataReader oku = ara.ExecuteReader();

            while (oku.Read())
            {
                //işlemlerini gerçekleştireceksin
                OyuncuListeleri arac = new OyuncuListeleri();
                arac.lbladsoyad.Text = oku["adsoyad"].ToString();
                arac.lblıd.Text = oku["ID"].ToString();
                arac.pbresimdetay.ImageLocation = oku["resim"].ToString();
                listepaneli.Controls.Add(arac);

            }

            baglanti.Close();
        }
    }
}
