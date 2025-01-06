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
    public partial class frmFilmListe : Form
    {
        public frmFilmListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void frmFilmListe_Load(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            string sorgu = "select * from Tbl_Filmler ORDER  BY adı ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                //verileri getir
                filmlistesi arac = new filmlistesi();
                arac.lblfilmadi.Text = reader["adı"].ToString();
                arac.pbresim.ImageLocation = reader["afis"].ToString();
                arac.lblidno.Text = reader["ID"].ToString();
                listepaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Filmler Where adı LIKE '%" + txtarama.Text + "%' collate Turkish_CI_AS ORDER  BY adı ASC ", baglanti);
            SqlDataReader oku = ara.ExecuteReader();

            while (oku.Read())
            {
                //işlemlerini gerçekleştireceksin
                filmlistesi arac = new filmlistesi();
                arac.lblfilmadi.Text = oku["adı"].ToString();
                arac.pbresim.ImageLocation = oku["afis"].ToString();
                arac.lblidno.Text = oku["ID"].ToString();
                listepaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }
    }
}
