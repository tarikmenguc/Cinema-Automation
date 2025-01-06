using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaOto
{
    public partial class ylistearaci : UserControl
    {
        public ylistearaci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void ylistearaci_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Secilenler Where kisi=@kisi AND tur=@tur", baglanti);
            komut.Parameters.AddWithValue("@kisi", lbladi.Text);
            komut.Parameters.AddWithValue("@tur", "yonetmen");
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                //gold renk
                lbladi.ForeColor = Color.Gold;
            }
            else
            {
                //Indigo renk
                lbladi.ForeColor = Color.Indigo;
            }
            baglanti.Close();

        }

        private void lbladi_Click(object sender, EventArgs e)
        {

            // baglanti nesnesini kontrol et ve açık değilse aç
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            // Label'ın mevcut rengini kontrol et
            if (lbladi.ForeColor == Color.Gold)
            {
                // Eğer mevcut renk Gold ise, rengi Indigo'ya değiştir ve kaydı sil
                lbladi.ForeColor = Color.Indigo;

                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where kisi=@kisi AND tur=@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "yonetmen");
                komut.ExecuteNonQuery();

                MessageBox.Show("yonetici çıkarıldı");
            }
            else
            {
                // Eğer mevcut renk Indigo ise, rengi Gold'a değiştir ve kaydı ekle
                lbladi.ForeColor = Color.Gold;

                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler (kisi,tur) values (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "yonetmen");
                komut.ExecuteNonQuery();

                MessageBox.Show("yönetmen eklendi");
            }

            // Bağlantıyı kapat
            baglanti.Close();

        }

        private void uzerinde(object sender, MouseEventArgs e)
        {
            
        }

        private void ayril(object sender, EventArgs e)
        {

           
        }
    }
}
