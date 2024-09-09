namespace Ejercicio_2
{
    partial class FInforme
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
            this.gbInforme = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbInforme = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInforme
            // 
            this.gbInforme.Controls.Add(this.btnCerrar);
            this.gbInforme.Controls.Add(this.lbInforme);
            this.gbInforme.Location = new System.Drawing.Point(12, 12);
            this.gbInforme.Name = "gbInforme";
            this.gbInforme.Size = new System.Drawing.Size(239, 206);
            this.gbInforme.TabIndex = 0;
            this.gbInforme.TabStop = false;
            this.gbInforme.Text = "Informe del viaje";
            // 
            // lbInforme
            // 
            this.lbInforme.FormattingEnabled = true;
            this.lbInforme.Location = new System.Drawing.Point(6, 19);
            this.lbInforme.Name = "lbInforme";
            this.lbInforme.Size = new System.Drawing.Size(227, 147);
            this.lbInforme.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrar.Location = new System.Drawing.Point(6, 172);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(227, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 230);
            this.Controls.Add(this.gbInforme);
            this.Name = "FInforme";
            this.Text = "FInforme";
            this.gbInforme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInforme;
        private System.Windows.Forms.Button btnCerrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListBox lbInforme;
    }
}