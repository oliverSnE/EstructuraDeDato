using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Threading;

namespace EstructuraDeDatos
{
    public partial class frmMemorama : Form
    {
        private string nombre = frmPreguntarNombre.nombre;
        int[] cartas = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        private bool estado = false;
        private int indiceTemporal = 0;
        private PictureBox picTemp = null;
        public frmMemorama()
        {
            InitializeComponent();
        }

        private void reset()
        {
            foreach (PictureBox pic in this.Controls.OfType<PictureBox>())
            {
                pic.Image = EstructuraDeDatos.Properties.Resources.reverso;
                pic.Update();
            }
        }

        private void flip (PictureBox pic, int entero)
        {
            //MessageBox.Show(cartas[entero].ToString());
            switch (cartas[entero])
            {
                case 0: pic.Image = EstructuraDeDatos.Properties.Resources.n0;
                    break;
                case 1: pic.Image = EstructuraDeDatos.Properties.Resources.n1;
                    break;
                case 2: pic.Image = EstructuraDeDatos.Properties.Resources.n2;
                    break;
                case 3: pic.Image = EstructuraDeDatos.Properties.Resources.n3;
                    break;
                case 4: pic.Image = EstructuraDeDatos.Properties.Resources.n4;
                    break;
                case 5: pic.Image = EstructuraDeDatos.Properties.Resources.n5;
                    break;
                case 6: pic.Image = EstructuraDeDatos.Properties.Resources.n6;
                    break;
                case 7: pic.Image = EstructuraDeDatos.Properties.Resources.n7;
                    break;
                
            }
            pic.Update();

            if (!estado)
            {
                estado = true;
                indiceTemporal = entero;
                picTemp = pic;
                picTemp.Enabled = false;
            }
            else
            {
                if (cartas[entero] == cartas[indiceTemporal])
                {
                   // MessageBox.Show("El eliott si es amá");
                    pic.Enabled = false;
                    pic.Visible = false;
                    picTemp.Enabled = false;
                    picTemp.Visible = false;

                }
                else
                {
                    //  Console.WriteLine("Eran mentiras.");
                    Thread.Sleep(1000);
                    pic.Image = EstructuraDeDatos.Properties.Resources.reverso;
                    picTemp.Image = EstructuraDeDatos.Properties.Resources.reverso;
                    picTemp.Enabled = true;

                }

                estado = false;
            }
        }
       
        private void frmMemorama_Load(object sender, EventArgs e)
        {
            cartas = cartas.OrderBy(s=>Guid.NewGuid()).ToArray();
            reset();
           // MessageBox.Show(string.Join(" - ", cartas)); 
        }

        private void p0_Click(object sender, EventArgs e)
        {
            flip(p0, 0);
        }

        private void p1_Click(object sender, EventArgs e)
        {
            flip(p1, 1);
        }

        private void p2_Click(object sender, EventArgs e)
        {
            flip(p2, 2);
        }

        private void p3_Click(object sender, EventArgs e)
        {
            flip(p3, 3);
        }

        private void p4_Click(object sender, EventArgs e)
        {
            flip(p4, 4);
        }

        private void p5_Click(object sender, EventArgs e)
        {
            flip(p5, 5);
        }

        private void p6_Click(object sender, EventArgs e)
        {
            flip(p6, 6);
        }

        private void p7_Click(object sender, EventArgs e)
        {
            flip(p7, 7);
        }

        private void p8_Click(object sender, EventArgs e)
        {
            flip(p8, 8);
        }

        private void p9_Click(object sender, EventArgs e)
        {
            flip(p9, 9);
        }

        private void p10_Click(object sender, EventArgs e)
        {
            flip(p10, 10);
        }

        private void p11_Click(object sender, EventArgs e)
        {
            flip(p11, 11);
        }

        private void p12_Click(object sender, EventArgs e)
        {
            flip(p12, 12);
        }

        private void p13_Click(object sender, EventArgs e)
        {
            flip(p13, 13);
        }

        private void p14_Click(object sender, EventArgs e)
        {
            flip(p14, 14);
        }

        private void p15_Click(object sender, EventArgs e)
        {
            flip(p15, 15);
        }
    }
}
