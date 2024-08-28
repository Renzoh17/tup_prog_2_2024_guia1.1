using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Moto
    {
        private string marca;
        private int modelo;
        private double valorFabricacion;

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.valorFabricacion = valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            return valorFabricacion - (valorFabricacion * (añoACalcular - modelo) / vidaUtil);
        }
        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            return valorFabricacion * Math.Pow((1 - tasaDepreciacion), (añoACalcular - modelo));
        }
        public string VerDescripcion()
        {
            return "Marca: " + marca + ", Modelo: " + modelo + ", Valor Fabricacion: $" + valorFabricacion;
        }
    }
}
