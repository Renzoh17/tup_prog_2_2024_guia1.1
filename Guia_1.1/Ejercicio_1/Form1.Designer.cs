namespace Ejercicio_1
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
            this.lMarca = new System.Windows.Forms.Label();
            this.lModelo = new System.Windows.Forms.Label();
            this.lañoACalcular = new System.Windows.Forms.Label();
            this.lValorFabricacion = new System.Windows.Forms.Label();
            this.lTasaDepreciacion = new System.Windows.Forms.Label();
            this.lVidaUtil = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.tbTasaDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.tbAñoACalcular = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(36, 33);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(37, 13);
            this.lMarca.TabIndex = 0;
            this.lMarca.Text = "Marca";
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(36, 74);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(69, 13);
            this.lModelo.TabIndex = 1;
            this.lModelo.Text = "Modelo (año)";
            // 
            // lañoACalcular
            // 
            this.lañoACalcular.AutoSize = true;
            this.lañoACalcular.Location = new System.Drawing.Point(36, 115);
            this.lañoACalcular.Name = "lañoACalcular";
            this.lañoACalcular.Size = new System.Drawing.Size(76, 13);
            this.lañoACalcular.TabIndex = 2;
            this.lañoACalcular.Text = "Año a Calcular";
            // 
            // lValorFabricacion
            // 
            this.lValorFabricacion.AutoSize = true;
            this.lValorFabricacion.Location = new System.Drawing.Point(36, 157);
            this.lValorFabricacion.Name = "lValorFabricacion";
            this.lValorFabricacion.Size = new System.Drawing.Size(113, 13);
            this.lValorFabricacion.TabIndex = 3;
            this.lValorFabricacion.Text = "Valor de Fabricacion $";
            // 
            // lTasaDepreciacion
            // 
            this.lTasaDepreciacion.AutoSize = true;
            this.lTasaDepreciacion.Location = new System.Drawing.Point(359, 33);
            this.lTasaDepreciacion.Name = "lTasaDepreciacion";
            this.lTasaDepreciacion.Size = new System.Drawing.Size(115, 13);
            this.lTasaDepreciacion.TabIndex = 4;
            this.lTasaDepreciacion.Text = "Tasa de Depreciacion ";
            // 
            // lVidaUtil
            // 
            this.lVidaUtil.AutoSize = true;
            this.lVidaUtil.Location = new System.Drawing.Point(359, 74);
            this.lVidaUtil.Name = "lVidaUtil";
            this.lVidaUtil.Size = new System.Drawing.Size(78, 13);
            this.lVidaUtil.TabIndex = 5;
            this.lVidaUtil.Text = "Vida Util (años)";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(163, 30);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 6;
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(163, 154);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabricacion.TabIndex = 7;
            // 
            // tbTasaDepreciacion
            // 
            this.tbTasaDepreciacion.Location = new System.Drawing.Point(480, 30);
            this.tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            this.tbTasaDepreciacion.Size = new System.Drawing.Size(77, 20);
            this.tbTasaDepreciacion.TabIndex = 8;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(480, 71);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(77, 20);
            this.tbVidaUtil.TabIndex = 9;
            // 
            // tbAñoACalcular
            // 
            this.tbAñoACalcular.Location = new System.Drawing.Point(163, 112);
            this.tbAñoACalcular.Name = "tbAñoACalcular";
            this.tbAñoACalcular.Size = new System.Drawing.Size(100, 20);
            this.tbAñoACalcular.TabIndex = 10;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(163, 71);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(39, 186);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 43);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular Costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(163, 186);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 43);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 241);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbAñoACalcular);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasaDepreciacion);
            this.Controls.Add(this.tbValorFabricacion);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lVidaUtil);
            this.Controls.Add(this.lTasaDepreciacion);
            this.Controls.Add(this.lValorFabricacion);
            this.Controls.Add(this.lañoACalcular);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.lMarca);
            this.Name = "Form1";
            this.Text = "Concesionaria de Motos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Label lañoACalcular;
        private System.Windows.Forms.Label lValorFabricacion;
        private System.Windows.Forms.Label lTasaDepreciacion;
        private System.Windows.Forms.Label lVidaUtil;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbValorFabricacion;
        private System.Windows.Forms.TextBox tbTasaDepreciacion;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.TextBox tbAñoACalcular;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
    }
}

