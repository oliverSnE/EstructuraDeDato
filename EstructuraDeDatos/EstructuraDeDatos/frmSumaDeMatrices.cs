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
    public partial class frmSumaDeMatrices : Form
    {
        public frmSumaDeMatrices()
        {
            InitializeComponent();
        }
        public static int col = 0;
        public static int row = 0;


        private void frmSumaDeMatrices_Load(object sender, EventArgs e)
        {
            lblColum.Location = new Point(this.Width/2-lblColum.Width/2,this.Height/2-lblColum.Width/2);
            txtCol.Location = new Point(this.Width / 2 + lblColum.Width / 2, this.Height / 2-lblColum.Width / 2);
            lblRows.Location = new Point(this.Width / 2 - lblColum.Width / 2, this.Height / 2 - lblColum.Width / 2+ txtCol.Height + 5);
            txtRow.Location = new Point(this.Width / 2 + lblColum.Width / 2, this.Height / 2 - lblColum.Width / 2 + txtCol.Height + 5);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCol.Text == "" || int.Parse(txtCol.Text) <=0 || int.Parse(txtCol.Text) > 25)
            {
                errorProvider.SetError(txtCol,"El número deberá estar entre el 0 y el 25");
            }

            if (txtRow.Text == "" || int.Parse(txtRow.Text) <= 0 || int.Parse(txtRow.Text) > 25)
            {
                errorProvider.SetError(txtRow, "El número deberá estar entre el 0 y el 25");
            }

            if (Convert.ToInt32(txtCol.Text) < Convert.ToInt32(txtRow.Text))
            {
                errorProvider.SetError(btnGenerar,"EL RENGLÓN NO PUEDE SER MAYOR A LA COLUMNA");
            }
            else
            {
                errorProvider.SetError(btnGenerar,"");
                col = int.Parse(txtCol.Text);
                row = int.Parse(txtRow.Text);
                pnlContenido.Enabled = false;
                pnlContenido.Controls.Clear();
                pnlContenido.Enabled = true;
                frmMatrices matrices = new frmMatrices();
                matrices.TopLevel = false;
                pnlContenido.Controls.Add(matrices);
                matrices.Show();
            }
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                SendKeys.Send("{BS}");
            }
        }

        private void txtRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                SendKeys.Send("{BS}");
            }
        }
    }
}
