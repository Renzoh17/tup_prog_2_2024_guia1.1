using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class FormMain : Form
    {
        Viaje viaje;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            FormInicioViaje vtnInicioViaje = new FormInicioViaje();
            if(vtnInicioViaje.ShowDialog() == DialogResult.OK)
            {
                viaje = new Viaje(Convert.ToInt32(vtnInicioViaje.tbHInicio.Text), Convert.ToInt32(vtnInicioViaje.tbMINICIO.Text), Convert.ToInt32(vtnInicioViaje.tbAsientos.Text));
                btnIniciarViaje.Enabled = false;
                btnIngresaParada.Enabled = true;
                gbFinalizarParada.Enabled = true;
            }
            vtnInicioViaje.Dispose();
        }

        private void btnIngresaParada_Click(object sender, EventArgs e)
        {
            FormIngresaParada vtnIngresaParada = new FormIngresaParada();
            if (vtnIngresaParada.ShowDialog() == DialogResult.OK)
            {
                viaje.RealizarParadas(Convert.ToInt32(vtnIngresaParada.tbHLlegada.Text), Convert.ToInt32(vtnIngresaParada.tbMLlegada.Text), Convert.ToInt32(vtnIngresaParada.tbHSalida.Text), Convert.ToInt32(vtnIngresaParada.tbMSalida.Text), Convert.ToInt32(vtnIngresaParada.tbAscienden.Text), Convert.ToInt32(vtnIngresaParada.tbDescienden.Text));
                FInforme vtninf = new FInforme();
                vtninf.lbInforme.Items.Add($"Descendieron: {vtnIngresaParada.tbDescienden.Text}");
                vtninf.lbInforme.Items.Add($"Ascendieron: {vtnIngresaParada.tbAscienden.Text}");
                vtninf.lbInforme.Items.Add($"Tiempo Demora(HH:MM): {viaje.HDemora}:{viaje.MDemora}");
                vtninf.ShowDialog();
            }
            vtnIngresaParada.Dispose();
        }

        private void btnFinalizarViaje_Click(object sender, EventArgs e)
        {
            viaje.Finalizar(Convert.ToInt32(tbHFinalizar.Text), Convert.ToInt32(tbMFinalizar.Text));
            FInforme vtninf = new FInforme();
            vtninf.lbInforme.Items.Add($"Cantidad de pasajeros transportados: {viaje.Transportados}");
            vtninf.lbInforme.Items.Add($"Tiempo total de recorrido(HH:MM): {viaje.HDuracionViaje}:{viaje.MDuracionViaje}");
            vtninf.ShowDialog();
            vtninf.Dispose();
            btnIniciarViaje.Enabled = true;
            btnIngresaParada.Enabled = false;
            btnFinalizarViaje.Enabled = false;
            tbHFinalizar.Clear();
            tbMFinalizar.Clear();
        }
    }
}
