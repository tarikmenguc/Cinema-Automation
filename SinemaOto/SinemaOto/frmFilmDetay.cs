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
    public partial class frmFilmDetay : Form
    {
        public frmFilmDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        public string idno = "";
        private void frmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Tbl_filmler Where ID=@p1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);   
            komut.Parameters.AddWithValue("@p1", idno);
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            
                {
                lblfilmadi.Text = oku["adı"].ToString();
                lblfilmbicimi.Text = oku["bicimi"].ToString();
                lblfilmturu.Text = oku["turu"].ToString();
                lblfilmozellikleri.Text = oku["ozellikler"].ToString();
                lblfilmyonetmenleri.Text = oku["yonetmen"].ToString();
                lblfilmoyunculari.Text = oku["oyuncu"].ToString();
                lblfilmdetayi.Text = oku["detay"].ToString();
                pbresim.ImageLocation = oku["afis"].ToString() ;
                lblvizyontarihi.Text = oku["tarih"].ToString();
            }
            
            baglanti.Close();
            if (lblFilmdurumu.Text=="0")
            {
                lblFilmdurumu.Text = "film vizyonda";
            }
            else
            {
                lblFilmdurumu.Text = "film vizyona girmedi";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
