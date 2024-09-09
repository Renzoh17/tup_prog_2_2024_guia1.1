namespace Ejercicio_2
{
    partial class FormMain
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
            this.btnIniciarViaje = new System.Windows.Forms.Button();
            this.btnIngresaParada = new System.Windows.Forms.Button();
            this.gbFinalizarParada = new System.Windows.Forms.GroupBox();
            this.btnFinalizarViaje = new System.Windows.Forms.Button();
            this.tbMFinalizar = new System.Windows.Forms.TextBox();
            this.tbHFinalizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFinalizarParada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarViaje
            // 
            this.btnIniciarViaje.Location = new System.Drawing.Point(12, 12);
            this.btnIniciarViaje.Name = "btnIniciarViaje";
            this.btnIniciarViaje.Size = new System.Drawing.Size(265, 36);
            this.btnIniciarViaje.TabIndex = 0;
            this.btnIniciarViaje.Text = "Iniciar Viaje";
            this.btnIniciarViaje.UseVisualStyleBackColor = true;
            this.btnIniciarViaje.Click += new System.EventHandler(this.btnIniciarViaje_Click);
            // 
            // btnIngresaParada
            // 
            this.btnIngresaParada.Enabled = false;
            this.btnIngresaParada.Location = new System.Drawing.Point(12, 54);
            this.btnIngresaParada.Name = "btnIngresaParada";
            this.btnIngresaParada.Size = new System.Drawing.Size(265, 36);
            this.btnIngresaParada.TabIndex = 1;
            this.btnIngresaParada.Text = "Ingresa Parada";
            this.btnIngresaParada.UseVisualStyleBackColor = true;
            this.btnIngresaParada.Click += new System.EventHandler(this.btnIngresaParada_Click);
            // 
            // gbFinalizarParada
            // 
            this.gbFinalizarParada.Controls.Add(this.btnFinalizarViaje);
            this.gbFinalizarParada.Controls.Add(this.tbMFinalizar);
            this.gbFinalizarParada.Controls.Add(this.tbHFinalizar);
            this.gbFinalizarParada.Controls.Add(this.label1);
            this.gbFinalizarParada.Enabled = false;
            this.gbFinalizarParada.Location = new System.Drawing.Point(12, 96);
            this.gbFinalizarParada.Name = "gbFinalizarParada";
            this.gbFinalizarParada.Size = new System.Drawing.Size(265, 81);
            this.gbFinalizarParada.TabIndex = 3;
            this.gbFinalizarParada.TabStop = false;
            this.gbFinalizarParada.Text = "Finalizar Parada";
            // 
            // btnFinalizarViaje
            // 
            this.btnFinalizarViaje.Location = new System.Drawing.Point(140, 52);
            this.btnFinalizarViaje.Name = "btnFinalizarViaje";
            this.btnFinalizarViaje.Size = new System.Drawing.Size(119, 23);
            this.btnFinalizarViaje.TabIndex = 3;
            this.btnFinalizarViaje.Text = "Finalizar Viaje";
            this.btnFinalizarViaje.UseVisualStyleBackColor = true;
            this.btnFinalizarViaje.Click += new System.EventHandler(this.btnFinalizarViaje_Click);
            // 
            // tbMFinalizar
            // 
            this.tbMFinalizar.Location = new System.Drawing.Point(205, 26);
            this.tbMFinalizar.Name = "tbMFinalizar";
            this.tbMFinalizar.Size = new System.Drawing.Size(38, 20);
            this.tbMFinalizar.TabIndex = 2;
            // 
            // tbHFinalizar
            // 
            this.tbHFinalizar.Location = new System.Drawing.Point(161, 26);
            this.tbHFinalizar.Name = "tbHFinalizar";
            this.tbHFinalizar.Size = new System.Drawing.Size(38, 20);
            this.tbHFinalizar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Finalizacion (HH:MM)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 186);
            this.Controls.Add(this.gbFinalizarParada);
            this.Controls.Add(this.btnIngresaParada);
            this.Controls.Add(this.btnIniciarViaje);
            this.Name = "FormMain";
            this.Text = "Colectivo";
            this.gbFinalizarParada.ResumeLayout(false);
            this.gbFinalizarParada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarViaje;
        private System.Windows.Forms.Button btnIngresaParada;
        private System.Windows.Forms.GroupBox gbFinalizarParada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMFinalizar;
        private System.Windows.Forms.TextBox tbHFinalizar;
        private System.Windows.Forms.Button btnFinalizarViaje;
    }
}

