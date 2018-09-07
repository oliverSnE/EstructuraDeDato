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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblElementoSeleccionado = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.Colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(18, 169);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(255, 33);
            this.lblElemento.TabIndex = 0;
            this.lblElemento.Text = "Elemento [0,0] =";
            // 
            // txtElemento
            // 
            this.txtElemento.BackColor = System.Drawing.Color.GreenYellow;
            this.txtElemento.Location = new System.Drawing.Point(279, 169);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(264, 39);
            this.txtElemento.TabIndex = 1;
            this.txtElemento.Leave += new System.EventHandler(this.txtElemento_Leave);
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCapturar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCapturar.Location = new System.Drawing.Point(627, 169);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(152, 39);
            this.btnCapturar.TabIndex = 8;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnReiniciar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReiniciar.Location = new System.Drawing.Point(785, 169);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(152, 39);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblElementoSeleccionado
            // 
            this.lblElementoSeleccionado.AutoSize = true;
            this.lblElementoSeleccionado.Location = new System.Drawing.Point(18, 220);
            this.lblElementoSeleccionado.Name = "lblElementoSeleccionado";
            this.lblElementoSeleccionado.Size = new System.Drawing.Size(450, 33);
            this.lblElementoSeleccionado.TabIndex = 10;
            this.lblElementoSeleccionado.Text = "Elemento [0,0] Seleccionado =";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(474, 220);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(195, 33);
            this.lblSeleccionado.TabIndex = 11;
            this.lblSeleccionado.Text = "Seleccionado";
            this.lblSeleccionado.Visible = false;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvMatriz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colum1,
            this.Column1,
            this.Colum3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatriz.Location = new System.Drawing.Point(18, 276);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatriz.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMatriz.Size = new System.Drawing.Size(913, 246);
            this.dgvMatriz.TabIndex = 12;
            this.dgvMatriz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellContentClick);
            // 
            // Colum1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Colum1.DefaultCellStyle = dataGridViewCellStyle2;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(408, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 33);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(183, 55);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(90, 33);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base:";
            this.lblBase.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(153, 100);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(120, 33);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.GreenYellow;
            this.txtBase.Location = new System.Drawing.Point(279, 52);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(264, 39);
            this.txtBase.TabIndex = 1;
            this.txtBase.Visible = false;
            this.txtBase.Leave += new System.EventHandler(this.txtElemento_Leave);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.GreenYellow;
            this.txtAltura.Location = new System.Drawing.Point(279, 97);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(264, 39);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.Visible = false;
            this.txtAltura.Leave += new System.EventHandler(this.txtElemento_Leave);
            // 
            // frmTiposDeDatos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(943, 535);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblElementoSeleccionado);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblElemento);
            this.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.GreenYellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTiposDeDatos2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTiposDeDatos2";
            this.Load += new System.EventHandler(this.frmTiposDeDatos2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblElementoSeleccionado;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colum3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
    }
}