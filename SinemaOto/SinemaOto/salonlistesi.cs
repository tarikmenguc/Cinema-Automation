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
    public partial class salonlistesi : UserControl
    {
        public salonlistesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salonlistesi_Load(object sender, EventArgs e)
        {

        }

        private void uzerinde(object sender, MouseEventArgs e)
        {
            lblsalonadi.ForeColor = Color.Gold;
            this.BackColor = Color.Black;

        }

        private void ayril(object sender, EventArgs e)
        {
            lblsalonadi.ForeColor = Color.Indigo;
            this.BackColor = Color.MistyRose;
        }

       
    }
}
