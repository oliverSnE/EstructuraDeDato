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
    public partial class frmPruebaDeFibonacci : Form
    {
        public frmPruebaDeFibonacci()
        {
            InitializeComponent();
        }

        public void buscar()
        {
            if (Convert.ToInt32(txtBuscar.Text) == 1)
            {
                lblEncontrado.Text = "El número 1 de la secuencia de Fibonacci es 0";
            }
            else if (Convert.ToInt32(txtBuscar.Text)== 2)
            {
                lblEncontrado.Text = "El número 2 de la secuencia de Fibonacci es 1";

            }
            else
            {
                lblEncontrado.Text = "El número " + txtBuscar.Text + " De Fibonacci es " +
                                     prueba(Convert.ToInt32(txtBuscar.Text) - 2);
            }
        }

        public long prueba(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return prueba(num - 1) + prueba(num -2 );
            }

         }

        public void enumerarRows()
        {
            foreach (DataGridViewRow numRows in dgvFibonacci.Rows)
            {
                numRows.HeaderCell.Value = (numRows.Index + 1).ToString();

            }
        }

        public void generar()
        {
                dgvFibonacci.Rows.Clear();
                dgvFibonacci.Visible = true;
                int f0 = 0, f1 = 1, fn = 0;

                dgvFibonacci.Rows.Add("0");
                //if (int.Parse(txtBuscar.Text) == 1)
                //{
                //    dgvFibonacci.Rows.Add("1");
                //}

                for (int i = 0; i <= 4200; i++)
                {

                    if (fn == 1)
                    {
                        dgvFibonacci.Rows.Add(fn.ToString());

                    }
                    if (fn > 4200)
                    {
                        break;
                    }

                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                    if (fn <= 4200)
                    {
                        dgvFibonacci.Rows.Add(fn.ToString());

                    }
                }
            
            

        }

        private void frmPruebaDeFibonacci_Load(object sender, EventArgs e)
        {
            generar();
            enumerarRows();
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtBuscar.Text) > 20)
            {
                errorProvider.SetError(txtBuscar,"El número ingresado no puede ser mayor a 20");
            }
            else
            {
                errorProvider.SetError(txtBuscar,"");
                buscar();
                txtBuscar.Clear();
                txtBuscar.Focus();

            }
          
            
        }
    }
}
