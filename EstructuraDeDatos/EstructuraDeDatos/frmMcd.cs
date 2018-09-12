using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class frmMcd : Form
    {
        public frmMcd()
        {
            InitializeComponent();
        }
        private void responsive()
        {
            gbContenido.Location = new Point(1, 1);
            gbContenido.Width = this.Width - 3;
            gbContenido.Height = this.Height - 1;
        }

        private int mcd (int a, int b)
        {
            if (a<0 || b < 0)
            {
                a = a < 0 ? a * -1 : a;
                b = b < 0 ? b * -1 : b;
                return mcd(a, b);
            }
            else if (b > a ) return mcd(b, a);
            
            else if (b == 0) return a;

            else return mcd(a - b, b);
           

        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                SendKeys.Send("{BS}");
            }
        }

        private void txtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                SendKeys.Send("{BS}");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = mcd(Convert.ToInt16(txtN1.Text), Convert.ToInt16(txtN2.Text)).ToString();

        }

        private void frmMcd_Load(object sender, EventArgs e)
        {
            responsive();
        }
    }
}
