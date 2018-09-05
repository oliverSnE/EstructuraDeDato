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
            txtBienvenida.Location = new Point(1,1);
            txtBienvenida.Width = this.Width - msMenu.Height;
            txtBienvenida.Height = this.Height - 1;
            txtBienvenida.Enabled = false;
            txtBienvenida.Text = "El alumno desarrollará aplicaciones que organicen información con base a estructuras de datos abstractas empleando el paradigma orientado a objetos para agilizar el acceso a los datos almacenados.";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            responsive();
           

        }
    }
}
