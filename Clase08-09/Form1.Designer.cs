
namespace Clase08_09
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
            this.Boton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton1
            // 
            this.Boton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Boton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton1.Location = new System.Drawing.Point(304, 150);
            this.Boton1.Name = "Boton1";
            this.Boton1.Size = new System.Drawing.Size(221, 99);
            this.Boton1.TabIndex = 0;
            this.Boton1.Text = "Primer Boton";
            this.Boton1.UseVisualStyleBackColor = false;
            this.Boton1.Click += new System.EventHandler(this.show);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton1;
    }
}

