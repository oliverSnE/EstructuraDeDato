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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rInt = new System.Windows.Forms.RadioButton();
            this.rDouble = new System.Windows.Forms.RadioButton();
            this.rDecimal = new System.Windows.Forms.RadioButton();
            this.rString = new System.Windows.Forms.RadioButton();
            this.rChar = new System.Windows.Forms.RadioButton();
            this.rAdt1 = new System.Windows.Forms.RadioButton();
            this.rAdt2 = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rAdt2);
            this.groupBox1.Controls.Add(this.rAdt1);
            this.groupBox1.Controls.Add(this.rChar);
            this.groupBox1.Controls.Add(this.rString);
            this.groupBox1.Controls.Add(this.rDecimal);
            this.groupBox1.Controls.Add(this.rDouble);
            this.groupBox1.Controls.Add(this.rInt);
            this.groupBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Dato";
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
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnIniciar.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIniciar.Location = new System.Drawing.Point(373, 522);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(138, 50);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmTiposDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(523, 588);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmTiposDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de datos";
            this.Load += new System.EventHandler(this.frmTiposDeDatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rAdt2;
        private System.Windows.Forms.RadioButton rAdt1;
        private System.Windows.Forms.RadioButton rChar;
        private System.Windows.Forms.RadioButton rString;
        private System.Windows.Forms.RadioButton rDecimal;
        private System.Windows.Forms.RadioButton rDouble;
        private System.Windows.Forms.RadioButton rInt;
        private System.Windows.Forms.Button btnIniciar;
    }
}