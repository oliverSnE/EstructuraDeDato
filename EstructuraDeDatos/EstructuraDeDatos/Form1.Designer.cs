﻿namespace EstructuraDeDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.unidad1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBienvenida = new System.Windows.Forms.TextBox();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidad1ToolStripMenuItem,
            this.unidad2ToolStripMenuItem,
            this.unidad3ToolStripMenuItem,
            this.unidad4ToolStripMenuItem,
            this.unidad5ToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 28);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // unidad1ToolStripMenuItem
            // 
            this.unidad1ToolStripMenuItem.Name = "unidad1ToolStripMenuItem";
            this.unidad1ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.unidad1ToolStripMenuItem.Text = "Unidad 1";
            // 
            // unidad2ToolStripMenuItem
            // 
            this.unidad2ToolStripMenuItem.Name = "unidad2ToolStripMenuItem";
            this.unidad2ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.unidad2ToolStripMenuItem.Text = "Unidad 2";
            // 
            // unidad3ToolStripMenuItem
            // 
            this.unidad3ToolStripMenuItem.Name = "unidad3ToolStripMenuItem";
            this.unidad3ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.unidad3ToolStripMenuItem.Text = "Unidad 3";
            // 
            // unidad4ToolStripMenuItem
            // 
            this.unidad4ToolStripMenuItem.Name = "unidad4ToolStripMenuItem";
            this.unidad4ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.unidad4ToolStripMenuItem.Text = "Unidad 4";
            // 
            // unidad5ToolStripMenuItem
            // 
            this.unidad5ToolStripMenuItem.Name = "unidad5ToolStripMenuItem";
            this.unidad5ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.unidad5ToolStripMenuItem.Text = "Unidad 5";
            // 
            // txtBienvenida
            // 
            this.txtBienvenida.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienvenida.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBienvenida.Location = new System.Drawing.Point(13, 32);
            this.txtBienvenida.Multiline = true;
            this.txtBienvenida.Name = "txtBienvenida";
            this.txtBienvenida.Size = new System.Drawing.Size(775, 406);
            this.txtBienvenida.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBienvenida);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem unidad1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad5ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBienvenida;
    }
}

