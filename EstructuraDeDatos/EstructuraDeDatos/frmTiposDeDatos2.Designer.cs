namespace EstructuraDeDatos
{
    partial class frmTiposDeDatos2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDeDatos2));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbContenido = new System.Windows.Forms.GroupBox();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.Colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.lblElementoSeleccionado = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.picVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbContenido
            // 
            this.gbContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContenido.Controls.Add(this.picVolver);
            this.gbContenido.Controls.Add(this.dgvMatriz);
            this.gbContenido.Controls.Add(this.lblSeleccionado);
            this.gbContenido.Controls.Add(this.lblElementoSeleccionado);
            this.gbContenido.Controls.Add(this.btnReiniciar);
            this.gbContenido.Controls.Add(this.btnCapturar);
            this.gbContenido.Controls.Add(this.txtAltura);
            this.gbContenido.Controls.Add(this.txtBase);
            this.gbContenido.Controls.Add(this.txtElemento);
            this.gbContenido.Controls.Add(this.lblAltura);
            this.gbContenido.Controls.Add(this.lblBase);
            this.gbContenido.Controls.Add(this.lblElemento);
            this.gbContenido.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gbContenido.Location = new System.Drawing.Point(12, 7);
            this.gbContenido.Name = "gbContenido";
            this.gbContenido.Size = new System.Drawing.Size(1022, 646);
            this.gbContenido.TabIndex = 0;
            this.gbContenido.TabStop = false;
            this.gbContenido.Text = "groupBox1";
            this.gbContenido.Enter += new System.EventHandler(this.gbContenido_Enter);
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvMatriz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colum1,
            this.Column1,
            this.Colum3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriz.Location = new System.Drawing.Point(6, 266);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatriz.Size = new System.Drawing.Size(1010, 114);
            this.dgvMatriz.TabIndex = 24;
            this.dgvMatriz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellContentClick_1);
            // 
            // Colum1
            // 
            this.Colum1.HeaderText = "Columna 1";
            this.Colum1.Name = "Colum1";
            this.Colum1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Columna 2";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Colum3
            // 
            this.Colum3.HeaderText = "Columna 3";
            this.Colum3.Name = "Colum3";
            this.Colum3.ReadOnly = true;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(462, 209);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(195, 33);
            this.lblSeleccionado.TabIndex = 23;
            this.lblSeleccionado.Text = "Seleccionado";
            this.lblSeleccionado.Visible = false;
            // 
            // lblElementoSeleccionado
            // 
            this.lblElementoSeleccionado.AutoSize = true;
            this.lblElementoSeleccionado.Location = new System.Drawing.Point(6, 209);
            this.lblElementoSeleccionado.Name = "lblElementoSeleccionado";
            this.lblElementoSeleccionado.Size = new System.Drawing.Size(450, 33);
            this.lblElementoSeleccionado.TabIndex = 22;
            this.lblElementoSeleccionado.Text = "Elemento [0,0] Seleccionado =";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReiniciar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnReiniciar.Location = new System.Drawing.Point(773, 158);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(152, 39);
            this.btnReiniciar.TabIndex = 21;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click_1);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapturar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnCapturar.Location = new System.Drawing.Point(615, 158);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(152, 39);
            this.btnCapturar.TabIndex = 20;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click_1);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtAltura.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtAltura.Location = new System.Drawing.Point(267, 86);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(264, 39);
            this.txtAltura.TabIndex = 17;
            this.txtAltura.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtBase.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtBase.Location = new System.Drawing.Point(267, 41);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(264, 39);
            this.txtBase.TabIndex = 18;
            this.txtBase.Visible = false;
            // 
            // txtElemento
            // 
            this.txtElemento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtElemento.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtElemento.Location = new System.Drawing.Point(267, 158);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(264, 39);
            this.txtElemento.TabIndex = 19;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(141, 89);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(120, 33);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(171, 44);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(90, 33);
            this.lblBase.TabIndex = 15;
            this.lblBase.Text = "Base:";
            this.lblBase.Visible = false;
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(6, 158);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(255, 33);
            this.lblElemento.TabIndex = 16;
            this.lblElemento.Text = "Elemento [0,0] =";
            // 
            // picVolver
            // 
            this.picVolver.Image = ((System.Drawing.Image)(resources.GetObject("picVolver.Image")));
            this.picVolver.Location = new System.Drawing.Point(12, 39);
            this.picVolver.Name = "picVolver";
            this.picVolver.Size = new System.Drawing.Size(32, 32);
            this.picVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVolver.TabIndex = 25;
            this.picVolver.TabStop = false;
            this.picVolver.Click += new System.EventHandler(this.picVolver_Click);
            // 
            // frmTiposDeDatos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1040, 658);
            this.Controls.Add(this.gbContenido);
            this.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTiposDeDatos2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTiposDeDatos2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTiposDeDatos2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbContenido.ResumeLayout(false);
            this.gbContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox gbContenido;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum3;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label lblElementoSeleccionado;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.PictureBox picVolver;
    }
}