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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }



        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            dgvFibonacci.Rows.Clear();
            dgvFibonacci.Visible = true;
            int f0 = 0, f1 = 1, fn = 0;
            
            dgvFibonacci.Rows.Add("0");
            if (int.Parse(txtLimite.Text) == 1)
            {
                dgvFibonacci.Rows.Add("1");
            }             
          
            for (int i = 0; i < int.Parse(txtLimite.Text); i++)
            {
                               
                if (fn == 1)
                {
                    dgvFibonacci.Rows.Add(fn.ToString());
                    
                }
                if (fn> int.Parse(txtLimite.Text))
                {
                    break;
                }
               
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
                if (fn <= int.Parse(txtLimite.Text))
                {
                    dgvFibonacci.Rows.Add(fn.ToString());

                }
                 

            }

        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)){

                SendKeys.Send ("{BS}");
            }
            
        }
    }
}
