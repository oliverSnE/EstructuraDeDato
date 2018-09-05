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

            txtBienvenida.Text = "El alumno desarrollará aplicaciones que organicen información con base a estructuras de datos abstractas empleando el paradigma orientado a objetos para agilizar el acceso a los datos almacenados.";



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
    }
}
