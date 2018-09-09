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
        
        int colum = 0;
        int row = 0;
        int tipo = 0;
        //bool bandera = false;

        //public bool checkbandera()
        //{
        //    if (bandera == true)
        //    {
        //        btnCapturar.Enabled = true;
        //        btnCapturar.Focus();
        //    }
        //    return bandera ? true : false;
        //}

        public frmTiposDeDatos2()
        {
            InitializeComponent();
        }
        private void responsive()
        {
            gbContenido.Location = new Point(1, 1);
            gbContenido.Width = this.Width - 2;
            gbContenido.Height = this.Height - 2;


        }

        public frmTiposDeDatos2(int tipo)
        {
            InitializeComponent();
            MessageBox.Show(tipo.ToString());
            responsive();
           

            this.tipo = tipo;
        }

        private void frmTiposDeDatos2_Load(object sender, EventArgs e)
        {
            dgvMatriz.Rows.Add();
            dgvMatriz.Rows.Add();
            dgvMatriz.Rows.Add();
            lblElemento.Text = "Elemento [" + colum + "," + row + "] =";
            lblElementoSeleccionado.Text = "Elemento seleccionado [" + colum + "," + row + "]";
            dgvMatriz[colum, row].Selected = false;
            if (tipo == 1)
            {
                gbContenido.Text = "Entero";
            }
            else if(tipo == 2)
            {
                gbContenido.Text = "Double";
            }else if (tipo == 3)
            {
                gbContenido.Text = "Decimal";
            }else if (tipo == 4)
            {
                gbContenido.Text = "CHAR";
            }else if (tipo == 5)
            {
                gbContenido.Text = "STRING";
            }else if(tipo == 6)
            {
                gbContenido.Text = "Triángulo";
                lblBase.Visible = true;
                lblBase.Text = "Base:";
                txtBase.Visible = true;
                lblAltura.Visible = true;
                lblAltura.Text = "Altura";
                txtAltura.Visible = true;
                lblElemento.Location = new Point(this.Width/2-lblElemento.Width/2);
                lblElemento.Text = "Elemento [" + colum + "," + row + "]";
                txtElemento.Visible = false;
            }else
            {
                gbContenido.Text = "Plano cartesiano";
                lblBase.Visible = true;
                lblBase.Text = "X: ";
                txtBase.Visible = true;
                lblAltura.Visible = true;
                lblAltura.Text = "Y: ";
                txtAltura.Visible = true;
                lblElemento.Location = new Point(this.Width / 2 - lblElemento.Width / 2);
                lblElemento.Text = "Elemento [" + colum + "," + row + "] =";
                txtElemento.Visible = false;

            }

        }

        
       

        private void txtElemento_Leave(object sender, EventArgs e)
        {
            ////Tipo INT
            //if (tipo == 1)
            //{
            //    if (txtElemento.Text.Length <= 0)
            //    {
            //        errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
            //        txtElemento.Focus();
            //    }
            //    else if (!Validaciones.entero(txtElemento.Text))
            //    {
            //        errorProvider.SetError(txtElemento, "Ingrese un número entero");
            //        txtElemento.Focus();
            //        txtElemento.SelectAll();
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txtElemento, "");
            //        btnCapturar.Focus();
            //        bandera = true;

            //    }
            //}
            ////Tipo Double
            //else if (tipo == 2)
            //{
            //    if (txtElemento.Text.Length <= 0)
            //    {
            //        errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
            //        txtElemento.Focus();
            //    }
            //    else if (!Validaciones.doble(txtElemento.Text))
            //    {
            //        errorProvider.SetError(txtElemento, "Ingrese un número tipo doble");
            //        txtElemento.Focus();
            //        txtElemento.SelectAll();
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txtElemento, "");
            //        btnCapturar.Focus();
            //        bandera = true;

            //    }
            //}
            ////Tipo Decimal
            //else if (tipo == 3)
            //{
            //    if (txtElemento.Text.Length <= 0)
            //    {
            //        errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
            //        txtElemento.Focus();
            //    }
            //    else if (!Validaciones.decima(txtElemento.Text))
            //    {
            //        errorProvider.SetError(txtElemento, "Ingrese un número tipo decimal");
            //        txtElemento.Focus();
            //        txtElemento.SelectAll();
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txtElemento, "");
            //        btnCapturar.Focus();
            //        bandera = true;
            //    }
            //}
            ////Tipo Char
            //else if (tipo == 4)
            //{
            //    if (txtElemento.Text.Length <= 0)
            //    {
            //        errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
            //        txtElemento.Focus();
            //    }
            //    else if (!Validaciones.cha(txtElemento.Text))
            //    {
            //        errorProvider.SetError(txtElemento, "Ingrese solamente un caracter");
            //        txtElemento.Focus();
            //        txtElemento.SelectAll();
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txtElemento, "");
            //        btnCapturar.Focus();
            //        bandera = true;

            //    }
            //}
            ////Tipo String
            //else if (tipo == 5)
            //{
            //    if (txtElemento.Text.Length <= 0)
            //    {
            //        errorProvider.SetError(txtElemento, "El campo no puede estar vacío");
            //        txtElemento.Focus();
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txtElemento, "");
            //        btnCapturar.Focus();
            //        bandera = true;
            //    }


            //}
            ////checkbandera();

        }

        

        private void btnCapturar_Click_1(object sender, EventArgs e)
        {
            if (tipo == 6)
            {
                

                dgvMatriz[colum, row].Value = new Triangulos(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltura.Text));

            }
            else if (tipo == 7)
            {
                dgvMatriz[colum, row].Value = new PuntoCarteciano(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltura.Text));

            }


            else
            {
                dgvMatriz[colum, row].Selected = false;
                dgvMatriz[colum, row].Value = txtElemento.Text;

            }
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
            //btnCapturar.Enabled = false;
            txtElemento.ResetText();


        }

        private void btnReiniciar_Click_1(object sender, EventArgs e)
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

        private void dgvMatriz_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lblSeleccionado.Visible = true;
            lblElementoSeleccionado.Text = "Elemento seleccionado [" + dgvMatriz.CurrentCell.ColumnIndex + "," + dgvMatriz.CurrentCell.RowIndex + "] =";
            lblSeleccionado.Text = dgvMatriz.CurrentCell.Value.ToString();
            if (tipo == 6)
            {

            }

        }

        private void gbContenido_Enter(object sender, EventArgs e)
        {

        }

        private void picVolver_Click(object sender, EventArgs e)
        {
           this.Close();
            frmTiposDeDatos tdd = new frmTiposDeDatos();
            tdd.pnlContenido.Controls.Clear();
            tdd.gbTipo.Visible = true;           
                      
        }
        
    }

    public class Triangulos
    {
        private double Base;
        private double Altura;
        public Triangulos()
        {

        }
        public Triangulos (double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public void setBase(double Base)
        {
            this.Base = Base;
            
        }
        public double getBase()
        {
            return Base;
        }
        public void setAltura(double Altura)
        {
            this.Altura = Altura;
        }
        public double getAltura()
        {
            return Altura;
        }
        
    }
    public class PuntoCarteciano
    {
        private int x;
        private int y;

        public PuntoCarteciano()
        {

        }
        public PuntoCarteciano (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(int x)
        {
            this.x = x;

        }
        public double getX()
        {
            return x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public double getY()
        {
            return y;
        }
    }

}