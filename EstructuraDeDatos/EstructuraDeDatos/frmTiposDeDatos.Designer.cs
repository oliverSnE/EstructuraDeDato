namespace EstructuraDeDatos
{
    partial class frmTiposDeDatos
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
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.rAdt2 = new System.Windows.Forms.RadioButton();
            this.rAdt1 = new System.Windows.Forms.RadioButton();
            this.rChar = new System.Windows.Forms.RadioButton();
            this.rString = new System.Windows.Forms.RadioButton();
            this.rDecimal = new System.Windows.Forms.RadioButton();
            this.rDouble = new System.Windows.Forms.RadioButton();
            this.rInt = new System.Windows.Forms.RadioButton();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.btnIniciar);
            this.gbTipo.Controls.Add(this.rAdt2);
            this.gbTipo.Controls.Add(this.rAdt1);
            this.gbTipo.Controls.Add(this.rChar);
            this.gbTipo.Controls.Add(this.rString);
            this.gbTipo.Controls.Add(this.rDecimal);
            this.gbTipo.Controls.Add(this.rDouble);
            this.gbTipo.Controls.Add(this.rInt);
            this.gbTipo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gbTipo.Location = new System.Drawing.Point(12, 12);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(498, 480);
            this.gbTipo.TabIndex = 0;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Seleccione el tipo de dato:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnIniciar.Location = new System.Drawing.Point(354, 424);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(138, 50);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // rAdt2
            // 
            this.rAdt2.AutoSize = true;
            this.rAdt2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rAdt2.Location = new System.Drawing.Point(180, 351);
            this.rAdt2.Name = "rAdt2";
            this.rAdt2.Size = new System.Drawing.Size(111, 37);
            this.rAdt2.TabIndex = 6;
            this.rAdt2.TabStop = true;
            this.rAdt2.Text = "ADT 2";
            this.rAdt2.UseVisualStyleBackColor = true;
            // 
            // rAdt1
            // 
            this.rAdt1.AutoSize = true;
            this.rAdt1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rAdt1.Location = new System.Drawing.Point(180, 308);
            this.rAdt1.Name = "rAdt1";
            this.rAdt1.Size = new System.Drawing.Size(111, 37);
            this.rAdt1.TabIndex = 5;
            this.rAdt1.TabStop = true;
            this.rAdt1.Text = "ADT 1";
            this.rAdt1.UseVisualStyleBackColor = true;
            // 
            // rChar
            // 
            this.rChar.AutoSize = true;
            this.rChar.Location = new System.Drawing.Point(180, 222);
            this.rChar.Name = "rChar";
            this.rChar.Size = new System.Drawing.Size(96, 37);
            this.rChar.TabIndex = 4;
            this.rChar.TabStop = true;
            this.rChar.Text = "Char";
            this.rChar.UseVisualStyleBackColor = true;
            // 
            // rString
            // 
            this.rString.AutoSize = true;
            this.rString.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rString.Location = new System.Drawing.Point(180, 265);
            this.rString.Name = "rString";
            this.rString.Size = new System.Drawing.Size(126, 37);
            this.rString.TabIndex = 3;
            this.rString.TabStop = true;
            this.rString.Text = "String";
            this.rString.UseVisualStyleBackColor = true;
            // 
            // rDecimal
            // 
            this.rDecimal.AutoSize = true;
            this.rDecimal.Location = new System.Drawing.Point(180, 179);
            this.rDecimal.Name = "rDecimal";
            this.rDecimal.Size = new System.Drawing.Size(141, 37);
            this.rDecimal.TabIndex = 2;
            this.rDecimal.TabStop = true;
            this.rDecimal.Text = "Decimal";
            this.rDecimal.UseVisualStyleBackColor = true;
            // 
            // rDouble
            // 
            this.rDouble.AutoSize = true;
            this.rDouble.Location = new System.Drawing.Point(180, 136);
            this.rDouble.Name = "rDouble";
            this.rDouble.Size = new System.Drawing.Size(126, 37);
            this.rDouble.TabIndex = 1;
            this.rDouble.TabStop = true;
            this.rDouble.Text = "Double";
            this.rDouble.UseVisualStyleBackColor = true;
            // 
            // rInt
            // 
            this.rInt.AutoSize = true;
            this.rInt.Location = new System.Drawing.Point(177, 93);
            this.rInt.Name = "rInt";
            this.rInt.Size = new System.Drawing.Size(81, 37);
            this.rInt.TabIndex = 0;
            this.rInt.TabStop = true;
            this.rInt.Text = "Int";
            this.rInt.UseVisualStyleBackColor = true;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Location = new System.Drawing.Point(528, 12);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(719, 500);
            this.pnlContenido.TabIndex = 1;
            // 
            // frmTiposDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1545, 707);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.gbTipo);
            this.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmTiposDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTiposDeDatos_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rAdt2;
        private System.Windows.Forms.RadioButton rAdt1;
        private System.Windows.Forms.RadioButton rChar;
        private System.Windows.Forms.RadioButton rString;
        private System.Windows.Forms.RadioButton rDecimal;
        private System.Windows.Forms.RadioButton rDouble;
        private System.Windows.Forms.RadioButton rInt;
        private System.Windows.Forms.Button btnIniciar;
        public System.Windows.Forms.GroupBox gbTipo;
        public System.Windows.Forms.Panel pnlContenido;
    }
}