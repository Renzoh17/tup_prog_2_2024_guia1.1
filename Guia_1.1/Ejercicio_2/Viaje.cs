using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Viaje
    {
        private int transportados = 0;
        public int Transportados { get { return transportados; } }
        private int asientos;
        public int Asientos { get { return asientos; } }
        private int hDemora;
        public int HDemora { get { return hDemora; } }
        private int mDemora;
        public int MDemora { get { return mDemora; } }
        private int cantParadas;
        public int CantParadas { get { return cantParadas; } }
        private int hDuracionViaje;
        public int HDuracionViaje { get {  return hDuracionViaje; } }
        private int mDuracionViaje;
        public int MDuracionViaje { get { return mDuracionViaje; } }

        public Viaje(int hInicio, int mInicio, int asientos)
        {
            hDuracionViaje = hInicio;
            mDuracionViaje = mInicio;
            this.asientos = asientos;
        }

        public void RealizarParadas(int hLlegadaParada, int mLlegadaParada, int hSalidaParada, int mSalidaParada, int ascienden, int descienden)
        {
            cantParadas++;
            transportados += ascienden;
            asientos += descienden;
            asientos -= ascienden;
            hDemora = hSalidaParada - hLlegadaParada;
            mDemora = mSalidaParada - mLlegadaParada;
        }

        public void Finalizar(int hLlegada, int mLlegada)
        {
            hDuracionViaje = hLlegada - HDuracionViaje;
            mDuracionViaje = mLlegada - MDuracionViaje;
        }
    }
}
