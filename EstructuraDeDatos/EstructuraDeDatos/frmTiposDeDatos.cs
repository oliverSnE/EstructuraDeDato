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
    public partial class frmTiposDeDatos : Form
    {
        public frmTiposDeDatos()
        {
            InitializeComponent();
        }

        private void frmTiposDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int dato = 0;
            dato = rInt.Checked == true ? 1 : dato;
            dato = rDouble.Checked == true ? 2 : dato;
            dato = rDecimal.Checked == true ? 3 : dato;
            dato = rChar.Checked == true ? 4 : dato;
            dato = rString.Checked == true ? 5 : dato;
            dato = rAdt1.Checked == true ? 6 : dato;
            dato = rAdt2.Checked == true ? 7 : dato;
            this.Hide();
            new frmTiposDeDatos2(dato).ShowDialog();
            this.Show();
        }
    }
}
