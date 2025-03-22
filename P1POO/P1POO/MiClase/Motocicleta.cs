using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int nivelGasolina;
        private int kilometraje;
        private bool encendida;

        public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            nivelGasolina = 20;
            encendida = false;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            nivelGasolina--;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            nivelGasolina--;
        }

        public int NivelGasolina
        {
            get { return nivelGasolina; }
            private set
            {
                if (value < 0) nivelGasolina = 0;
                else if (value > 25) nivelGasolina = 25; 
                else nivelGasolina = value;
            }
        }

        public int nivelKilometraje 
        {
            get { return kilometraje; }
            private set
            {
                if (value >= 0)
                    kilometraje = value;
            }
        }

        public void Encender()
        {
            encendida = true;
        }

        public void Apagar()
        {
            encendida = false;
        }

    }
}
