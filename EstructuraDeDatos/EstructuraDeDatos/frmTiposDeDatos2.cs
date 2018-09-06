using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EstructuraDeDatos
{

    public partial class frmTiposDeDatos2 : Form
    {
        //Validaciones validacion = new Validaciones();
        int colum = 0;
        int row = 0;
        int tipo = 0;
        bool bandera = false;

        public bool checkbandera()
        {
            if (bandera == true)
            {
                btnCapturar.Enabled = true;
                btnCapturar.Focus();
            }
            return bandera ? true : false;
        }

        public frmTiposDeDatos2()
        {
            InitializeComponent();
        }



        public frmTiposDeDatos2(int tipo)
        {
            InitializeComponent();
            MessageBox.Show(tipo.ToString());
            this.tipo = tipo;
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
            btnCapturar.Enabled = false;
            txtElemento.ResetText();
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

        private void txtElemento_Leave(object sender, EventArgs e)
        {
            //Tipo INT
            if (tipo == 1)
            {
                if (txtElemento.Text.Length <= 0)
                {
                    errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
                    txtElemento.Focus();
                }
                else if (!Validaciones.entero(txtElemento.Text))
                {
                    errorProvider.SetError(txtElemento, "Ingrese un número entero");
                    txtElemento.Focus();
                    txtElemento.SelectAll();
                }
                else
                {
                    errorProvider.SetError(txtElemento, "");
                    btnCapturar.Focus();
                    bandera = true;

                }
            }
            //Tipo Double
            else if (tipo == 2)
            {
                if (txtElemento.Text.Length <= 0)
                {
                    errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
                    txtElemento.Focus();
                }
                else if (!Validaciones.doble(txtElemento.Text))
                {
                    errorProvider.SetError(txtElemento, "Ingrese un número tipo doble");
                    txtElemento.Focus();
                    txtElemento.SelectAll();
                }
                else
                {
                    errorProvider.SetError(txtElemento, "");
                    btnCapturar.Focus();
                    bandera = true;

                }
            }
            //Tipo Decimal
            else if (tipo == 3)
            {
                if (txtElemento.Text.Length <= 0)
                {
                    errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
                    txtElemento.Focus();
                }
                else if (!Validaciones.decima(txtElemento.Text))
                {
                    errorProvider.SetError(txtElemento, "Ingrese un número tipo decimal");
                    txtElemento.Focus();
                    txtElemento.SelectAll();
                }
                else
                {
                    errorProvider.SetError(txtElemento, "");
                    btnCapturar.Focus();
                    bandera = true;
                }
            }
            //Tipo Char
            else if (tipo == 4)
            {
                if (txtElemento.Text.Length <= 0)
                {
                    errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
                    txtElemento.Focus();
                }
                else if (!Validaciones.cha(txtElemento.Text))
                {
                    errorProvider.SetError(txtElemento, "Ingrese solamente un caracter");
                    txtElemento.Focus();
                    txtElemento.SelectAll();
                }
                else
                {
                    errorProvider.SetError(txtElemento, "");
                    btnCapturar.Focus();
                    bandera = true;

                }
            }
            //Tipo String
            else if (tipo == 5)
            {
                if (txtElemento.Text.Length <= 0)
                {
                    errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
                    txtElemento.Focus();
                }
                else
                {
                    errorProvider.SetError(txtElemento, "");
                    btnCapturar.Focus();
                    bandera = true;
                }


            }
            checkbandera();

        }

       
    }
}