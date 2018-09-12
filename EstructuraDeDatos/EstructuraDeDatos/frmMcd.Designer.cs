namespace EstructuraDeDatos
{
    partial class frmMcd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMcd));
            this.gbContenido = new System.Windows.Forms.GroupBox();
            this.lblR = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.picMcd = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gbContenido.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMcd)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenido
            // 
            this.gbContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContenido.Controls.Add(this.txtResultado);
            this.gbContenido.Controls.Add(this.pnlInfo);
            this.gbContenido.Controls.Add(this.lblR);
            this.gbContenido.Controls.Add(this.btnCapturar);
            this.gbContenido.Controls.Add(this.txtN2);
            this.gbContenido.Controls.Add(this.txtN1);
            this.gbContenido.Controls.Add(this.lbl2);
            this.gbContenido.Controls.Add(this.lbl1);
            this.gbContenido.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gbContenido.Location = new System.Drawing.Point(12, 12);
            this.gbContenido.Name = "gbContenido";
            this.gbContenido.Size = new System.Drawing.Size(1200, 647);
            this.gbContenido.TabIndex = 0;
            this.gbContenido.TabStop = false;
            this.gbContenido.Text = "MCD";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(299, 317);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(152, 32);
            this.lblR.TabIndex = 22;
            this.lblR.Text = "Resultado:";
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapturar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnCapturar.Location = new System.Drawing.Point(409, 215);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(152, 39);
            this.btnCapturar.TabIndex = 21;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // txtN2
            // 
            this.txtN2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtN2.ForeColor = System.Drawing.Color.SlateGray;
            this.txtN2.Location = new System.Drawing.Point(208, 151);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(353, 38);
            this.txtN2.TabIndex = 3;
            this.txtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN2_KeyPress);
            // 
            // txtN1
            // 
            this.txtN1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtN1.ForeColor = System.Drawing.Color.SlateGray;
            this.txtN1.Location = new System.Drawing.Point(208, 75);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(353, 38);
            this.txtN1.TabIndex = 2;
            this.txtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN1_KeyPress);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(56, 154);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(146, 32);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Número 2:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(56, 78);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Número 1:";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.txtInfo);
            this.pnlInfo.Controls.Add(this.picMcd);
            this.pnlInfo.Location = new System.Drawing.Point(655, 38);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(539, 501);
            this.pnlInfo.TabIndex = 23;
            // 
            // picMcd
            // 
            this.picMcd.Image = ((System.Drawing.Image)(resources.GetObject("picMcd.Image")));
            this.picMcd.Location = new System.Drawing.Point(64, 40);
            this.picMcd.Name = "picMcd";
            this.picMcd.Size = new System.Drawing.Size(433, 196);
            this.picMcd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMcd.TabIndex = 0;
            this.picMcd.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtInfo.Enabled = false;
            this.txtInfo.ForeColor = System.Drawing.Color.SlateGray;
            this.txtInfo.Location = new System.Drawing.Point(79, 273);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(404, 210);
            this.txtInfo.TabIndex = 24;
            this.txtInfo.Text = "Se define el máximo común divisor (MCD) de dos o más números enteros al mayor núm" +
    "ero entero que los divide sin dejar residuo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Máximo común divisor";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtResultado.ForeColor = System.Drawing.Color.SlateGray;
            this.txtResultado.Location = new System.Drawing.Point(192, 352);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(353, 38);
            this.txtResultado.TabIndex = 24;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMcd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1224, 671);
            this.Controls.Add(this.gbContenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMcd";
            this.Text = "frmMcd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMcd_Load);
            this.gbContenido.ResumeLayout(false);
            this.gbContenido.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMcd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenido;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox picMcd;
        private System.Windows.Forms.TextBox txtResultado;
    }
}