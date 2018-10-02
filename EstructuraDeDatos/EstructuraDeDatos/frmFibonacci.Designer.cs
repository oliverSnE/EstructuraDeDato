namespace EstructuraDeDatos
{
    partial class frmFibonacci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFibonacci));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.dgvFibonacci = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLimite = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.pbFibonacci = new System.Windows.Forms.PictureBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblFig = new System.Windows.Forms.Label();
            this.picFibonacci = new System.Windows.Forms.PictureBox();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFibonacci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFibonacci)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFibonacci)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.dgvFibonacci);
            this.pnlControl.Controls.Add(this.lblLimite);
            this.pnlControl.Controls.Add(this.btnGenerar);
            this.pnlControl.Controls.Add(this.txtLimite);
            this.pnlControl.Location = new System.Drawing.Point(0, 47);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(433, 621);
            this.pnlControl.TabIndex = 11;
            // 
            // dgvFibonacci
            // 
            this.dgvFibonacci.AllowUserToAddRows = false;
            this.dgvFibonacci.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvFibonacci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFibonacci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFibonacci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFibonacci.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFibonacci.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvFibonacci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFibonacci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFibonacci.GridColor = System.Drawing.Color.Black;
            this.dgvFibonacci.Location = new System.Drawing.Point(104, 83);
            this.dgvFibonacci.Name = "dgvFibonacci";
            this.dgvFibonacci.ReadOnly = true;
            this.dgvFibonacci.RowTemplate.Height = 24;
            this.dgvFibonacci.Size = new System.Drawing.Size(262, 535);
            this.dgvFibonacci.TabIndex = 15;
            this.dgvFibonacci.Visible = false;
            this.dgvFibonacci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFibonacci_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Columna 1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLimite.Location = new System.Drawing.Point(6, 13);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(100, 32);
            this.lblLimite.TabIndex = 12;
            this.lblLimite.Text = "Límite:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenerar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.SlateGray;
            this.btnGenerar.Location = new System.Drawing.Point(252, 7);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 41);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.White;
            this.txtLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimite.ForeColor = System.Drawing.Color.Black;
            this.txtLimite.Location = new System.Drawing.Point(104, 10);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(142, 38);
            this.txtLimite.TabIndex = 13;
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimite_KeyPress);
            // 
            // pbFibonacci
            // 
            this.pbFibonacci.Image = ((System.Drawing.Image)(resources.GetObject("pbFibonacci.Image")));
            this.pbFibonacci.Location = new System.Drawing.Point(-1, 40);
            this.pbFibonacci.Name = "pbFibonacci";
            this.pbFibonacci.Size = new System.Drawing.Size(750, 259);
            this.pbFibonacci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFibonacci.TabIndex = 0;
            this.pbFibonacci.TabStop = false;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.pnlTitulo);
            this.pnlContenido.Controls.Add(this.pbFibonacci);
            this.pnlContenido.Location = new System.Drawing.Point(440, 48);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(753, 620);
            this.pnlContenido.TabIndex = 12;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblFig);
            this.pnlTitulo.Controls.Add(this.picFibonacci);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 3);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(753, 620);
            this.pnlTitulo.TabIndex = 12;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // lblFig
            // 
            this.lblFig.AutoSize = true;
            this.lblFig.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFig.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblFig.Location = new System.Drawing.Point(239, 3);
            this.lblFig.Name = "lblFig";
            this.lblFig.Size = new System.Drawing.Size(265, 32);
            this.lblFig.TabIndex = 13;
            this.lblFig.Text = "Figura de Fibonacci";
            // 
            // picFibonacci
            // 
            this.picFibonacci.Image = ((System.Drawing.Image)(resources.GetObject("picFibonacci.Image")));
            this.picFibonacci.Location = new System.Drawing.Point(-1, 40);
            this.picFibonacci.Name = "picFibonacci";
            this.picFibonacci.Size = new System.Drawing.Size(750, 259);
            this.picFibonacci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFibonacci.TabIndex = 0;
            this.picFibonacci.TabStop = false;
            // 
            // frmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1193, 679);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.frmFibonacci_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFibonacci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFibonacci)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFibonacci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.DataGridView dgvFibonacci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.PictureBox pbFibonacci;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblFig;
        private System.Windows.Forms.PictureBox picFibonacci;
    }
}