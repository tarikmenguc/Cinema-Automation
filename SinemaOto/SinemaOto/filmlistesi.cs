using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOto
{
    public partial class filmlistesi : UserControl
    {
        public filmlistesi()
        {
            InitializeComponent();
        }

        private void btnfilm_Click(object sender, EventArgs e)
        {
           frmFilmDetay frm = new frmFilmDetay();   
            frm.idno = lblidno.Text;
            frm.ShowDialog();
        }

        private void lblfilmadi_Click(object sender, EventArgs e)
        {

        }
    }
}
