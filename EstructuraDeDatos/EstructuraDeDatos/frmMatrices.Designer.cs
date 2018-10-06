namespace EstructuraDeDatos
{
    partial class frmMatrices
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
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.dgvSumaMatrices = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblL1 = new System.Windows.Forms.Label();
            this.lblL2 = new System.Windows.Forms.Label();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.txtL2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaMatrices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AllowUserToAddRows = false;
            this.dgvMatriz1.AllowUserToDeleteRows = false;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz1.Location = new System.Drawing.Point(12, 75);
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.RowTemplate.Height = 24;
            this.dgvMatriz1.Size = new System.Drawing.Size(379, 292);
            this.dgvMatriz1.TabIndex = 0;
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.AllowUserToAddRows = false;
            this.dgvMatriz2.AllowUserToDeleteRows = false;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz2.Location = new System.Drawing.Point(397, 75);
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.RowTemplate.Height = 24;
            this.dgvMatriz2.Size = new System.Drawing.Size(379, 292);
            this.dgvMatriz2.TabIndex = 1;
            // 
            // dgvSumaMatrices
            // 
            this.dgvSumaMatrices.AllowUserToAddRows = false;
            this.dgvSumaMatrices.AllowUserToDeleteRows = false;
            this.dgvSumaMatrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumaMatrices.Location = new System.Drawing.Point(782, 75);
            this.dgvSumaMatrices.Name = "dgvSumaMatrices";
            this.dgvSumaMatrices.ReadOnly = true;
            this.dgvSumaMatrices.RowTemplate.Height = 24;
            this.dgvSumaMatrices.Size = new System.Drawing.Size(379, 292);
            this.dgvSumaMatrices.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(485, 730);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(132, 52);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.BackColor = System.Drawing.Color.Transparent;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(470, 350);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(86, 91);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "+";
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Transparent;
            this.btnSuma.Location = new System.Drawing.Point(1010, 350);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(47, 120);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "=";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblL1
            // 
            this.lblL1.AutoSize = true;
            this.lblL1.Location = new System.Drawing.Point(443, 645);
            this.lblL1.Name = "lblL1";
            this.lblL1.Size = new System.Drawing.Size(52, 31);
            this.lblL1.TabIndex = 6;
            this.lblL1.Text = "L1:";
            // 
            // lblL2
            // 
            this.lblL2.AutoSize = true;
            this.lblL2.Location = new System.Drawing.Point(443, 689);
            this.lblL2.Name = "lblL2";
            this.lblL2.Size = new System.Drawing.Size(52, 31);
            this.lblL2.TabIndex = 7;
            this.lblL2.Text = "L2:";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(501, 642);
            this.txtL1.Name = "txtL1";
            this.txtL1.Size = new System.Drawing.Size(101, 38);
            this.txtL1.TabIndex = 8;
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(501, 686);
            this.txtL2.Name = "txtL2";
            this.txtL2.Size = new System.Drawing.Size(101, 38);
            this.txtL2.TabIndex = 9;
            // 
            // frmMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 790);
            this.Controls.Add(this.txtL2);
            this.Controls.Add(this.txtL1);
            this.Controls.Add(this.lblL2);
            this.Controls.Add(this.lblL1);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.dgvSumaMatrices);
            this.Controls.Add(this.dgvMatriz2);
            this.Controls.Add(this.dgvMatriz1);
            this.Controls.Add(this.lblSuma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMatrices";
            this.Text = "frmMatrices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMatrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaMatrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz1;
        private System.Windows.Forms.DataGridView dgvMatriz2;
        private System.Windows.Forms.DataGridView dgvSumaMatrices;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblL1;
        private System.Windows.Forms.Label lblL2;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.TextBox txtL2;
    }
}