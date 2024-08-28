using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto(tbMarca.Text, Convert.ToInt32(tbModelo.Text), Convert.ToDouble(tbValorFabricacion.Text));
            Resultados vtnResultados = new Resultados();
            vtnResultados.lbResultados.Items.Clear();
            vtnResultados.lbResultados.Items.Add(moto.VerDescripcion());
            vtnResultados.lbResultados.Items.Add("Descripcion Lineal: " + moto.CalcularDepreciacionLineal(Convert.ToInt32(tbAñoACalcular.Text), Convert.ToInt32(tbVidaUtil.Text)).ToString("$0.00"));
            vtnResultados.lbResultados.Items.Add("Descripcion Anual: " + moto.CalcularDepreciacionAnual(Convert.ToInt32(tbAñoACalcular.Text), Convert.ToDouble(tbTasaDepreciacion.Text)).ToString("$0.00"));
            if(vtnResultados.ShowDialog() == DialogResult.OK)
            {
                tbMarca.Clear();
                tbModelo.Clear();
                tbAñoACalcular.Clear();
                tbValorFabricacion.Clear();
                tbTasaDepreciacion.Clear();
                tbVidaUtil.Clear();
            }
            vtnResultados.Dispose();
            
        }
    }
}
