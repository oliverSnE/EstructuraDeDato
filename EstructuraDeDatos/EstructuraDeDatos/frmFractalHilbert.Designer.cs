namespace EstructuraDeDatos
{
    partial class frmFractalHilbert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.ckRefrescar = new System.Windows.Forms.CheckBox();
            this.pbHilbert = new System.Windows.Forms.PictureBox();
            this.sfdImagen = new System.Windows.Forms.SaveFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbHilbert)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(-2, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Profundidad:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(156, 21);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(72, 34);
            this.txtProf.TabIndex = 2;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(106, 72);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 45);
            this.btnIr.TabIndex = 3;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // ckRefrescar
            // 
            this.ckRefrescar.AutoSize = true;
            this.ckRefrescar.Location = new System.Drawing.Point(61, 145);
            this.ckRefrescar.Name = "ckRefrescar";
            this.ckRefrescar.Size = new System.Drawing.Size(139, 33);
            this.ckRefrescar.TabIndex = 4;
            this.ckRefrescar.Text = "Refrescar";
            this.ckRefrescar.UseVisualStyleBackColor = true;
            // 
            // pbHilbert
            // 
            this.pbHilbert.Location = new System.Drawing.Point(319, 24);
            this.pbHilbert.Name = "pbHilbert";
            this.pbHilbert.Size = new System.Drawing.Size(517, 444);
            this.pbHilbert.TabIndex = 5;
            this.pbHilbert.TabStop = false;
            this.pbHilbert.Click += new System.EventHandler(this.pbHilbert_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 42);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "button1";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "openFileDialog1";
            // 
            // frmFractalHilbert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 480);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbHilbert);
            this.Controls.Add(this.ckRefrescar);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFractalHilbert";
            this.Text = "frmFractalHilbert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFractalHilbert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHilbert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.CheckBox ckRefrescar;
        private System.Windows.Forms.PictureBox pbHilbert;
        private System.Windows.Forms.SaveFileDialog sfdImagen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
    }
}