//sql veritaban�na ait k�t�phaneyi eklemen ve bunu programa belirtmen gerekiyor
using System.Data;
using System.Data.SqlClient;




namespace SinemaOto
{
    public partial class girisformu : Form
    {
        public girisformu()
        {
            InitializeComponent();
        }
        //connectionstring dedi�imiz veritaban�m�z�n yolunu projemize eklememiz gerekiyor ve veri taban�m�z�n yolunu projemize s�ylememiz gerekiyor
        //  SqlConnection conn = new SqlConnection(@"Data Source=Veritaban�m�z�n_Yolu;Initial Catalog=Veritaban�m�z�n_ad�;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=netflixandchillDB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // �ifreyi g�ster
            }
            else
            {
                txtPassword.PasswordChar = '*'; // �ifreyi gizle
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            //Kulllan�c� giri� i�lemlerini ger�ekle�tireceksin
            // select insert update delete komutlar� 
            //select sorgulama
          //  SqlCommand command = new SqlCommand("select*from hangi tablo �zerinde sorgulama i�lmei ger�ekle�tireceksem onu belirtiyorum ", conn);
           // �art ya da ko�ul t�mcemiz WHERE idi.
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Users WHERE USERNAME=@username AND USERPASSWORD=@password ",conn);
            command.Parameters.AddWithValue("@username",txtkullaniciadi.Text);
            command.Parameters.AddWithValue("@password",txtPassword.Text);
            SqlDataReader read = command.ExecuteReader();
            if (read.Read())// okuma i�lemi ba�ar�l� ise yani girmi� oldu�un veriler veri taban�nda mevcut ve e�le�iyor ise yap�lacak i�lemler
            {
               // MessageBox.Show("Giri� ba�ar�l�");
               frmanaform frmanaform = new frmanaform();
              frmanaform.kisiadisoyadi = read["NAMESURNAME"].ToString();    
                
                
                frmanaform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giri� i�lemi ba�ar�s�z!!");
            }
           conn.Close();
            txtkullaniciadi.Text = "";
            txtPassword.Text = "";
            txtkullaniciadi.Focus();//imleci konumland�r.
            
            
            
            //veritaban�na ba�lanma i�lemi sorgulama 
        // conn.Open();
        //    if (conn.State==ConnectionState.Open)
        //    {
        //        MessageBox.Show("Ba�ar�l�!");
        //    }
        //conn.Close();
        }
    }
}
