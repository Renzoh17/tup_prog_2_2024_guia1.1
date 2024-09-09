using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Peaje
    {
        
        public double PromCantVehiculosMes
        { 
            get 
            {
                int acum = 0;
                for (int i = 0; i < cantidades.Length; i++) acum += cantidades[i];
                return acum / 31d;
            } 
        }
        private int[] cantidades;
        
        public Peaje()
        {
            cantidades = new int[31];
            for(int i = 0; i < cantidades.Length; i++) cantidades[i] = 0;
        }

        public void RegistrarResumenDia(int dia, int cantidadVehiculos)
        {
            cantidades[dia - 1] = cantidadVehiculos;
        }
        public int[] LosDiasMayoresAlPromedio(out int cantDias)
        {
            cantDias = 0;
            int[] dias = new int[31];
            double prom = PromCantVehiculosMes;
            for(int i = 0; i < dias.Length; i++)
            {
                if (cantidades[i] > prom) dias[cantDias++] = i + 1;
            }
            return dias;
        }
        public int TercioDelMesMayor()
        {
            int[] tercios = new int[] {0,0,0};
            int mayor = 0;
            int m = 0;
            for (int i = 0; i < cantidades.Length; i++)
            {
                if (i < 10) tercios[0] += cantidades[i];
                else if(i < 20) tercios[1] += cantidades[i];
                else tercios[2] += cantidades[i];
            }

            for(int i = 1; i < 3; i++)
            {
                if (tercios[i] > tercios[m]) m = i;
            }
            mayor = m + 1;

            return mayor;
        }
    }
}
