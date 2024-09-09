using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        Peaje peaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            FormCargaPeaje vtnCP = new FormCargaPeaje();
            while(vtnCP.ShowDialog() == DialogResult.OK)
            {
                peaje = new Peaje();
                peaje.RegistrarResumenDia(Convert.ToInt32(vtnCP.nudDias.Value), Convert.ToInt32(vtnCP.tbCantidadAutos.Text));
            }
            vtnCP.Dispose();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            int cant;
            int[] diasMP = peaje.LosDiasMayoresAlPromedio(out cant);
            lbResumen.Items.Clear();
            lbResumen.Items.Add($"El promedio de vehiculos ingresados es: {peaje.PromCantVehiculosMes}");
            lbResumen.Items.Add("Los dias que ingresaron mas autos que el promedio:");
            for (int i = 0; i < cant; i++) lbResumen.Items.Add(diasMP[i]);
            lbResumen.Items.Add($"El tercio del mes con mayor movimiento fue el: {peaje.TercioDelMesMayor()}");
        }
    }
}
