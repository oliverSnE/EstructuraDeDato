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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void responsive()
        {
            txtBienvenida.Location = new Point(this.Width/2-txtBienvenida.Width/2,this.Height/2-txtBienvenida.Height/2);
            txtBienvenida.Width = Convert.ToInt32(this.Width*0.6);
            txtBienvenida.Height = Convert.ToInt32(this.Height*0.7);
            msMenu.Height = Convert.ToInt32(this.Height * 0.10);
            msMenu.Width = this.Width;
            pnlMenu.Width = this.Width;
            picCerrar.Location = new Point(this.Width - picCerrar.Width - 5, pnlMenu.Height /2 - picCerrar.Height/2);
            picCerrar.Height = pnlMenu.Height;
            pnlContenido.Location = new Point(1,pnlMenu.Height+msMenu.Height);
            pnlContenido.Height = this.Height - pnlMenu.Height - msMenu.Height;
            pnlContenido.Width = this.Width;
            txtBienvenida.Text = "El alumno desarrollará aplicaciones que organicen información con base a estructuras de datos abstractas empleando el paradigma orientado a objetos para agilizar el acceso a los datos almacenados.";
            pnlstrip.Width = this.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            responsive();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            responsive();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            responsive();
        }

        private void práctica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            frmTiposDeDatos TDD = new frmTiposDeDatos();
            TDD.TopLevel = false;
            pnlContenido.Controls.Add(TDD);
            TDD.Show();
           
           
           
        }

        private void unidad5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            pnlContenido.Controls.Add(txtBienvenida);
            
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            frmFibonacci fibonacci = new frmFibonacci();
            fibonacci.TopLevel = false;
            pnlContenido.Controls.Add(fibonacci);
            fibonacci.Show();
        }

        private void picCerrar_Click(object sender, EventArgs e) => this.Close();

        private void mCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            frmMcd mcd = new frmMcd();
            mcd.TopLevel = false;
            pnlContenido.Controls.Add(mcd);
            mcd.Show();
        }

        private void búsquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            frmBusquedaBinaria binario = new frmBusquedaBinaria();
            binario.TopLevel = false;
            pnlContenido.Controls.Add(binario);
            binario.Show();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            frmPreguntarNombre nombrememo = new frmPreguntarNombre();
            nombrememo.TopLevel = false;
            pnlContenido.Controls.Add(nombrememo);
            nombrememo.Show();
        }
    }
}
