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
    public partial class frmTiposDeDatos2 : Form
    {
        int colum = 0;
        int row = 0;

        public frmTiposDeDatos2()
        {
            InitializeComponent();
        }


        public frmTiposDeDatos2(int tipo)
        {
            InitializeComponent();
            MessageBox.Show(tipo.ToString());
        }

        private void frmTiposDeDatos2_Load(object sender, EventArgs e)
        {
            dgvMatriz.Rows.Add();
            dgvMatriz.Rows.Add();
            dgvMatriz.Rows.Add();
            lblElemento.Text = "Elemento [" + colum + "," + row + "] =";
            dgvMatriz[colum, row].Selected = false;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            dgvMatriz[colum, row].Selected = false;
            dgvMatriz[colum, row].Value = txtElemento.Text;

            colum++;
            if (colum > 2)
            {
                colum = 0;
                row++;
                
            }
            if (row == 3)
            {
                btnCapturar.Enabled = false;

            }
            else
            {
                lblElemento.Text = "Elemento [" + colum + "," + row + "] =";
                dgvMatriz.CurrentCell = dgvMatriz[1, row];
                dgvMatriz[1, row].Selected = false;
                dgvMatriz[colum, row].Selected = true;

            }
            
            txtElemento.Clear();
            txtElemento.Focus();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            colum = 0;
            row = 0;
            lblElemento.Text = "Elemento [" + colum + "," + row + "] =";
            btnCapturar.Enabled = true;
            dgvMatriz.Rows.Clear();
            dgvMatriz.Rows.Add();
            dgvMatriz.Rows.Add();
            dgvMatriz.Rows.Add();
        }
    }
}
