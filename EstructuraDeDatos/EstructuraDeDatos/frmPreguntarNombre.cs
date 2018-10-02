using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class frmPreguntarNombre : Form
    {
        public static string nombre;
        private int tiempo = 0;
        private bool jugar = false;
        public frmPreguntarNombre()
        {
            InitializeComponent();
        }

        private void frmPreguntarNombre_Load(object sender, EventArgs e)
        {
            lblIntentos.Location = new Point(1,1);
            lblNumIntento.Location = new Point(lblIntentos.Width + 2,1 );
            
            lblPlayer.Location = new Point(this.Width / 2 - lblPlayer.Width / 2 - lblTiempo.Width / 2, 0);
            lblTiempo.Location = new Point(this.Width / 2 + lblPlayer.Width + lblTiempo.Width, 0);

            pnlContenido.Location = new Point(1,30);
            pnlContenido.Width = this.Width;
            pnlContenido.Height = this.Height-30;
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            pnlContenido.Controls.Add(txtNombre);
            pnlContenido.Controls.Add(lblNombre);
            pnlContenido.Controls.Add(btnJugar);
            lblNombre.Location = new Point(this.Width/2-lblNombre.Width/2,Convert.ToInt32(this.Height*0.45));
            txtNombre.Location = new Point(this.Width / 2 - txtNombre.Width / 2, Convert.ToInt32(this.Height * 0.45 + lblNombre.Height+5));
            btnJugar.Location = new Point(this.Width / 2 - btnJugar.Width / 2, Convert.ToInt32(this.Height * 0.55));

        }

       

        private void btnJugar_Click_1(object sender, EventArgs e)
        {
            jugar = true;
            //tiempo++;
            //lblTiempo.Text = tiempo.ToString();

            lblTiempo.Text = tiempo.ToString();
            lblPlayer.Text = txtNombre.Text;
            pnlContenido.Enabled = false;
            pnlContenido.Controls.Clear();
            pnlContenido.Enabled = true;
            frmMemorama memorama = new frmMemorama();
            memorama.TopLevel = false;
            pnlContenido.Controls.Add(memorama);
            memorama.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (jugar == true)
            {
                tiempo++;
                lblTiempo.Text = tiempo.ToString();
                lblNumIntento.Text = frmMemorama.count + "";
            }
            

        }
    }
}
