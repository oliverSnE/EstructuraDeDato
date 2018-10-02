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
    public partial class frmBusquedaBinaria : Form
    {
        public int[] valores;
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }
        private void responsive()
        {
            gbBinario.Location = new Point(1, 1);
            gbBinario.Width = this.Width - 3;
            gbBinario.Height = this.Height;
            txtInfo.Text = "Es un algoritmo de búsqueda que encuentra la posición de un valor en un array ordenado. " +
                "Compara el valor con el elemento en el medio del array, si no son iguales, la mitad en la cual el " +
                "valor no puede estar es eliminada y la búsqueda continúa en la mitad restante hasta que el valor se encuentre.";
        }

        private void frmBusquedaBinaria_Load(object sender, EventArgs e)
        {
            responsive();
        }
        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        private void gbBinario_Enter(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //dgvBusqueda.Rows.Clear();
            Random r = new Random();

            valores = new int[int.Parse(txtElemento.Text)];

            for (int i = 0; i < int.Parse(txtElemento.Text); i++)
            {
                valores[i] = r.Next(0, Convert.ToInt32(txtLimite.Text));
                //dgvBusqueda.Rows.Add(r.Next(0, Convert.ToInt32(txtLimite.Text)).ToString());

            }
            Array.Sort(valores);
            dgvBusqueda.DataSource = valores.Select(x => new { Elementos = x }).ToList();
            setRowNumber(dgvBusqueda);
        }

        private void txtElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                SendKeys.Send("{BS}");
                
            }
            
        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {
            if (txtElemento.Text.Length >= 1)
            {
                if (txtElemento.Text == "0" || txtElemento.Text == "-")
                {
                    txtElemento.Clear();
                }

            }
            

        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                SendKeys.Send("{BS}");

            }

        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            if (txtLimite.Text.Length >= 1)
            {
                if (txtLimite.Text == "0" || txtLimite.Text == "-")
                {
                    txtLimite.Clear();
                }

            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                SendKeys.Send("{BS}");

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length >= 1)
            {
                if (txtBuscar.Text == "0" || txtBuscar.Text == "-")
                {
                    txtBuscar.Clear();
                }

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length <= 0)
            {
                errorProvider.SetError(txtBuscar,"El campo no puede esta vacío.");
            }
            else
            {
               lblEncontrado.Text = Convert.ToString(busqueda(valores, Convert.ToInt32(txtBuscar.Text)));
                
                 errorProvider.SetError(txtBuscar,"");
            }
            
        }

        public static object busqueda(int[] num, int key)
        {
            
            
            int minimo = 0;
            int maximo = num.Length - 1;
            while (minimo <= maximo)
            {
                int mitad = (minimo + maximo) / 2;
                if (key == num [mitad])
                {
                    ++mitad;
                    return "Está en la posición: " + mitad;

                }
                else if (key < num [mitad])
                {
                    maximo = mitad - 1;

                }
                else
                {
                    minimo = mitad + 1;
                }

            }
            return "No está";

        }
    }
}
