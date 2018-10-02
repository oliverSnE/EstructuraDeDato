using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstructuraDeDatos
{
    public partial class frmFractalHilbert : Form
    {
        public frmFractalHilbert()
        {
            InitializeComponent();
        }
        private bool DoRefresh;
        private float LastX, LastY;
        private Bitmap HilbertImage;

        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            LastX = LastX + dx;
            LastY = LastY + dy;
        }

        private void Hilbert(Graphics gr, int depth, float dx, float dy)
        {
            if (depth > 1) Hilbert(gr, depth - 1, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 1) Hilbert(gr, depth - 1, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 1) Hilbert(gr, depth - 1, -dy, -dx);

            if (DoRefresh) pbHilbert.Refresh();
        }

        public void generar()
        {
            int depth = int.Parse(txtProf.Text);
            if (depth > 8)
            {
                if (MessageBox.Show("A large depth may take a long time to draw (and will be mostly black anyway). Do you want to continue?",
                        "Continue?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            // See if we should refresh as we draw.
            DoRefresh = ckRefrescar.Checked;

            // Get the parameters.
            float total_length, start_x, start_y, start_length;

            // See how big we can make the curve.
            if (pbHilbert.ClientSize.Height < pbHilbert.ClientSize.Width)
            {
                total_length = (float)(0.9 * pbHilbert.ClientSize.Height);
            }
            else
            {
                total_length = (float)(0.9 * pbHilbert.ClientSize.Width);
            }

            start_x = (pbHilbert.ClientSize.Width - total_length) / 2;
            start_y = (pbHilbert.ClientSize.Height - total_length) / 2;

            // Compute the side length for this level.
            start_length = (float)(total_length / (Math.Pow(2, depth) - 1));

            HilbertImage = new Bitmap(pbHilbert.ClientSize.Width, pbHilbert.ClientSize.Height);
            pbHilbert.Image = HilbertImage;

            using (Graphics gr = Graphics.FromImage(HilbertImage))
            {
                // Draw the curve.
                gr.Clear(pbHilbert.BackColor);
                LastX = (int)start_x;
                LastY = (int)start_y;
                Hilbert(gr, depth, start_length, 0);
            }

            // Display the result.
            pbHilbert.Refresh();
            this.Cursor = Cursors.Default;
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            generar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarImagen();

        }

        public void guardarImagen()
        {
            //OpenFileDialog abrir = new OpenFileDialog();
            //abrir.Filter = "jpeg files (*.jpeg)|*.jpeg|bmp file (*.bmp)|*.bmp|png files (*.png)|*.png";

            //sfdImagen.FileName = "";
            //ofdImagen.Title = "Seleccione donde guardar la imagen";
            ////sfdImagen.ShowDialog();
            //if (abrir.ShowDialog() == DialogResult.OK)
            //{
            //    pbHilbert.BackgroundImage = Image.FromFile(abrir.FileName);

            //}
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "jpeg files (*.jpeg)|*.jpeg|bmp file (*.bmp)|*.bmp|png files (*.png)|*.png";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }
                    pbHilbert.Image.Save(sfd.FileName, format);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible guardar la imagen");
            }
           
        }

        private void pbHilbert_Click(object sender, EventArgs e)
        {

        }

        private void frmFractalHilbert_Load(object sender, EventArgs e)
        {
            pbHilbert.Width = Convert.ToInt32(this.Width * 0.95);
            pbHilbert.Height = Convert.ToInt32(this.Height * 0.95);
        }
    }

}
