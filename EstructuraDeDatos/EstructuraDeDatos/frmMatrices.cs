using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class frmMatrices : Form
    {
        public frmMatrices()
        {
            InitializeComponent();
        }
        private void responsive()
        {
            dgvMatriz1.Location = new Point(1, Convert.ToInt32(this.Height * 0.1));
            dgvMatriz1.Width = Convert.ToInt32(this.Width * 0.30);
            dgvMatriz1.Height = Convert.ToInt32(this.Height * .70);

            dgvMatriz2.Location = new Point(dgvMatriz1.Width+2 + lblSuma.Width+10, Convert.ToInt32(this.Height * 0.1));
            dgvMatriz2.Width = Convert.ToInt32(this.Width * 0.30);
            dgvMatriz2.Height = Convert.ToInt32(this.Height * .70);

            dgvSumaMatrices.Location = new Point(dgvMatriz1.Width+4+dgvMatriz2.Width+4 + lblSuma.Width + lblSuma.Width, Convert.ToInt32(this.Height * 0.1));
            dgvSumaMatrices.Width = Convert.ToInt32(this.Width * 0.30);
            dgvSumaMatrices.Height = Convert.ToInt32(this.Height * .70);
        }
        private int col = frmSumaDeMatrices.col;
        private int row = frmSumaDeMatrices.row;
        private int numeros = 0;
        private void generador()
        {
            Random r = new Random();
            int col = 0;
            
            var l1 = int.Parse(txtL1.Text);
            var l2 = int.Parse(txtL2.Text);

            if (l1 > l2)
            {
                l1 = int.Parse(txtL2.Text);
                l2 = int.Parse(txtL1.Text);
            }
            
            for (int i = 0; i < dgvMatriz1.ColumnCount; i++)
            {
                for (int j = 0; j < dgvMatriz1.RowCount; j++)
                {
                    numeros = 0;
                    numeros = r.Next(l1, l2);
                    dgvMatriz1.Rows[j].Cells[col].Value = numeros;
                    numeros = r.Next(l1, l2);
                    dgvMatriz2.Rows[j].Cells[col].Value = numeros;

                }

                for (int j = 0; j < dgvMatriz1.RowCount; j++)
                {
                    numeros = 0;
                    numeros = r.Next(l1, l2);
                    dgvMatriz1.Rows[j].Cells[col].Value = numeros;
                    numeros = r.Next(l1, l2);
                    dgvMatriz2
.Rows[j].Cells[col].Value = numeros;
                }

                col++;
            }

        }
        private void RowsColums()
        {
            for (int i = 0; i < col; i++)
            {
                dgvMatriz1.Columns.Add("", "Colum " + (i + 1));
                dgvMatriz2.Columns.Add("", "Colum " + (i + 1));
                dgvSumaMatrices.Columns.Add("", "Colum " + (i + 1));
            }
            for (int i = 0; i < row; i++)
            {
                dgvMatriz1.Rows.Add("");
                dgvMatriz2.Rows.Add("");
                dgvSumaMatrices.Rows.Add("");
            }
        }
        private void sumaDeMatrices()
        {
            int col = 0;
            for (int i = 0; i < dgvMatriz1.ColumnCount; i++)
            {
                for (int j = 0; j < dgvMatriz1.RowCount; j++)
                {
                    int sm1 = 0;
                    int sm2 = 0;
                    int result = 0;

                    sm1 = int.Parse(dgvMatriz1.Rows[j].Cells[col].Value.ToString());
                    sm2 = int.Parse(dgvMatriz2.Rows[j].Cells[col].Value.ToString());
                    result = sm1 + sm2;
                    dgvSumaMatrices.Rows[j].Cells[col].Value = result;

                }

                col++;
            }
        }
        private void frmMatrices_Load(object sender, EventArgs e)
        {
            responsive();
            RowsColums();
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            generador();
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            sumaDeMatrices();
        }
    }
}
