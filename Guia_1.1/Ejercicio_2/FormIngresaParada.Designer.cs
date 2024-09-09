namespace Ejercicio_2
{
    partial class FormIngresaParada
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
            this.gbParada = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbHLlegada = new System.Windows.Forms.TextBox();
            this.tbMLlegada = new System.Windows.Forms.TextBox();
            this.tbMSalida = new System.Windows.Forms.TextBox();
            this.tbHSalida = new System.Windows.Forms.TextBox();
            this.tbAscienden = new System.Windows.Forms.TextBox();
            this.tbDescienden = new System.Windows.Forms.TextBox();
            this.gbParada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParada
            // 
            this.gbParada.Controls.Add(this.tbDescienden);
            this.gbParada.Controls.Add(this.tbAscienden);
            this.gbParada.Controls.Add(this.tbMSalida);
            this.gbParada.Controls.Add(this.tbHSalida);
            this.gbParada.Controls.Add(this.tbMLlegada);
            this.gbParada.Controls.Add(this.tbHLlegada);
            this.gbParada.Controls.Add(this.btnCancelar);
            this.gbParada.Controls.Add(this.btnCargar);
            this.gbParada.Controls.Add(this.label4);
            this.gbParada.Controls.Add(this.label3);
            this.gbParada.Controls.Add(this.label2);
            this.gbParada.Controls.Add(this.label1);
            this.gbParada.Location = new System.Drawing.Point(12, 12);
            this.gbParada.Name = "gbParada";
            this.gbParada.Size = new System.Drawing.Size(220, 186);
            this.gbParada.TabIndex = 0;
            this.gbParada.TabStop = false;
            this.gbParada.Text = "Parada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llegada (HH:MM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salida (HH:MM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ascienden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descienden";
            // 
            // btnCargar
            // 
            this.btnCargar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCargar.Location = new System.Drawing.Point(6, 144);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 36);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(139, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbHLlegada
            // 
            this.tbHLlegada.Location = new System.Drawing.Point(139, 25);
            this.tbHLlegada.Name = "tbHLlegada";
            this.tbHLlegada.Size = new System.Drawing.Size(28, 20);
            this.tbHLlegada.TabIndex = 6;
            // 
            // tbMLlegada
            // 
            this.tbMLlegada.Location = new System.Drawing.Point(173, 25);
            this.tbMLlegada.Name = "tbMLlegada";
            this.tbMLlegada.Size = new System.Drawing.Size(28, 20);
            this.tbMLlegada.TabIndex = 7;
            // 
            // tbMSalida
            // 
            this.tbMSalida.Location = new System.Drawing.Point(173, 53);
            this.tbMSalida.Name = "tbMSalida";
            this.tbMSalida.Size = new System.Drawing.Size(28, 20);
            this.tbMSalida.TabIndex = 9;
            // 
            // tbHSalida
            // 
            this.tbHSalida.Location = new System.Drawing.Point(139, 53);
            this.tbHSalida.Name = "tbHSalida";
            this.tbHSalida.Size = new System.Drawing.Size(28, 20);
            this.tbHSalida.TabIndex = 8;
            // 
            // tbAscienden
            // 
            this.tbAscienden.Location = new System.Drawing.Point(139, 87);
            this.tbAscienden.Name = "tbAscienden";
            this.tbAscienden.Size = new System.Drawing.Size(62, 20);
            this.tbAscienden.TabIndex = 10;
            // 
            // tbDescienden
            // 
            this.tbDescienden.Location = new System.Drawing.Point(139, 113);
            this.tbDescienden.Name = "tbDescienden";
            this.tbDescienden.Size = new System.Drawing.Size(62, 20);
            this.tbDescienden.TabIndex = 11;
            // 
            // FormIngresaParada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 208);
            this.Controls.Add(this.gbParada);
            this.Name = "FormIngresaParada";
            this.Text = "Ingreso Datos Parada";
            this.gbParada.ResumeLayout(false);
            this.gbParada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParada;
        public System.Windows.Forms.TextBox tbDescienden;
        public System.Windows.Forms.TextBox tbAscienden;
        public System.Windows.Forms.TextBox tbMSalida;
        public System.Windows.Forms.TextBox tbHSalida;
        public System.Windows.Forms.TextBox tbMLlegada;
        public System.Windows.Forms.TextBox tbHLlegada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}