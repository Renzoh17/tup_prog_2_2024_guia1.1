namespace Ejercicio_3
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
            this.lbResumen = new System.Windows.Forms.ListBox();
            this.btnRegistrarPeaje = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResumen
            // 
            this.lbResumen.FormattingEnabled = true;
            this.lbResumen.Location = new System.Drawing.Point(12, 12);
            this.lbResumen.Name = "lbResumen";
            this.lbResumen.Size = new System.Drawing.Size(597, 420);
            this.lbResumen.TabIndex = 0;
            // 
            // btnRegistrarPeaje
            // 
            this.btnRegistrarPeaje.Location = new System.Drawing.Point(615, 12);
            this.btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            this.btnRegistrarPeaje.Size = new System.Drawing.Size(114, 62);
            this.btnRegistrarPeaje.TabIndex = 1;
            this.btnRegistrarPeaje.Text = "RegistrarPeaje";
            this.btnRegistrarPeaje.UseVisualStyleBackColor = true;
            this.btnRegistrarPeaje.Click += new System.EventHandler(this.btnRegistrarPeaje_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(615, 80);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(114, 62);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "Ver Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnRegistrarPeaje);
            this.Controls.Add(this.lbResumen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbResumen;
        private System.Windows.Forms.Button btnRegistrarPeaje;
        private System.Windows.Forms.Button btnResumen;
    }
}

