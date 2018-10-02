namespace EstructuraDeDatos
{
    partial class frmBusquedaBinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaBinaria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblNumElemento = new System.Windows.Forms.Label();
            this.gbBinario = new System.Windows.Forms.GroupBox();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbBinario.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtElemento.ForeColor = System.Drawing.Color.SlateGray;
            this.txtElemento.Location = new System.Drawing.Point(313, 49);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(353, 38);
            this.txtElemento.TabIndex = 4;
            this.txtElemento.TextChanged += new System.EventHandler(this.txtElemento_TextChanged);
            this.txtElemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElemento_KeyPress);
            // 
            // lblNumElemento
            // 
            this.lblNumElemento.AutoSize = true;
            this.lblNumElemento.Location = new System.Drawing.Point(53, 52);
            this.lblNumElemento.Name = "lblNumElemento";
            this.lblNumElemento.Size = new System.Drawing.Size(301, 32);
            this.lblNumElemento.TabIndex = 3;
            this.lblNumElemento.Text = "Número de elementos:";
            // 
            // gbBinario
            // 
            this.gbBinario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBinario.Controls.Add(this.lblEncontrado);
            this.gbBinario.Controls.Add(this.pnlInfo);
            this.gbBinario.Controls.Add(this.dgvBusqueda);
            this.gbBinario.Controls.Add(this.btnBuscar);
            this.gbBinario.Controls.Add(this.lblBuscar);
            this.gbBinario.Controls.Add(this.txtBuscar);
            this.gbBinario.Controls.Add(this.btnRandom);
            this.gbBinario.Controls.Add(this.lblLimite);
            this.gbBinario.Controls.Add(this.txtLimite);
            this.gbBinario.Controls.Add(this.lblNumElemento);
            this.gbBinario.Controls.Add(this.txtElemento);
            this.gbBinario.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gbBinario.Location = new System.Drawing.Point(13, 13);
            this.gbBinario.Name = "gbBinario";
            this.gbBinario.Size = new System.Drawing.Size(1461, 793);
            this.gbBinario.TabIndex = 5;
            this.gbBinario.TabStop = false;
            this.gbBinario.Text = "Búsqueda Binaria";
            this.gbBinario.Enter += new System.EventHandler(this.gbBinario_Enter);
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.Location = new System.Drawing.Point(726, 524);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(161, 32);
            this.lblEncontrado.TabIndex = 29;
            this.lblEncontrado.Text = "Encontrado";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.txtInfo);
            this.pnlInfo.Location = new System.Drawing.Point(972, 49);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(445, 696);
            this.pnlInfo.TabIndex = 28;
            // 
            // picInfo
            // 
            this.picInfo.Image = ((System.Drawing.Image)(resources.GetObject("picInfo.Image")));
            this.picInfo.Location = new System.Drawing.Point(55, 4);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(373, 300);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 30;
            this.picInfo.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtInfo.ForeColor = System.Drawing.Color.SlateGray;
            this.txtInfo.Location = new System.Drawing.Point(55, 344);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(373, 294);
            this.txtInfo.TabIndex = 29;
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(707, 49);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusqueda.RowHeadersWidth = 65;
            this.dgvBusqueda.RowTemplate.Height = 24;
            this.dgvBusqueda.Size = new System.Drawing.Size(240, 472);
            this.dgvBusqueda.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscar.Location = new System.Drawing.Point(514, 340);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 39);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(196, 272);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(111, 32);
            this.lblBuscar.TabIndex = 23;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtBuscar.ForeColor = System.Drawing.Color.SlateGray;
            this.txtBuscar.Location = new System.Drawing.Point(313, 269);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(353, 38);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRandom.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnRandom.Location = new System.Drawing.Point(514, 155);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(152, 39);
            this.btnRandom.TabIndex = 22;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(207, 111);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(100, 32);
            this.lblLimite.TabIndex = 5;
            this.lblLimite.Text = "Límite:";
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtLimite.ForeColor = System.Drawing.Color.SlateGray;
            this.txtLimite.Location = new System.Drawing.Point(313, 111);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(353, 38);
            this.txtLimite.TabIndex = 6;
            this.txtLimite.TextChanged += new System.EventHandler(this.txtLimite_TextChanged);
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimite_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1502, 846);
            this.Controls.Add(this.gbBinario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBusquedaBinaria";
            this.Text = "frmBusquedaBinaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBusquedaBinaria_Load);
            this.gbBinario.ResumeLayout(false);
            this.gbBinario.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblNumElemento;
        private System.Windows.Forms.GroupBox gbBinario;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}