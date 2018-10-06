namespace EstructuraDeDatos
{
    partial class frmSumaDeMatrices
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
            this.components = new System.ComponentModel.Container();
            this.lblColum = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColum
            // 
            this.lblColum.AutoSize = true;
            this.lblColum.Location = new System.Drawing.Point(292, 260);
            this.lblColum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColum.Name = "lblColum";
            this.lblColum.Size = new System.Drawing.Size(144, 31);
            this.lblColum.TabIndex = 0;
            this.lblColum.Text = "Columnas:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(292, 318);
            this.lblRows.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(152, 31);
            this.lblRows.TabIndex = 1;
            this.lblRows.Text = "Renglones:";
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.btnGenerar);
            this.pnlContenido.Controls.Add(this.txtRow);
            this.pnlContenido.Controls.Add(this.txtCol);
            this.pnlContenido.Controls.Add(this.lblColum);
            this.pnlContenido.Controls.Add(this.lblRows);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1069, 611);
            this.pnlContenido.TabIndex = 2;
            this.pnlContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenido_Paint);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(818, 431);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(122, 66);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(445, 315);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 38);
            this.txtRow.TabIndex = 3;
            this.txtRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRow_KeyPress);
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(445, 257);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(100, 38);
            this.txtCol.TabIndex = 2;
            this.txtCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCol_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmSumaDeMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 611);
            this.Controls.Add(this.pnlContenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSumaDeMatrices";
            this.Text = "frmSumaDeMatrices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSumaDeMatrices_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColum;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}