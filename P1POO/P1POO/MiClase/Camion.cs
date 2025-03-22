﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        private int cargaGasolina;
        private int cargaActual;
        private int capacidadCarga;

        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            capacidadCarga = 1000;
            cargaGasolina = 300;
            cargaActual = 390;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaGasolina--;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            cargaGasolina--;
        }

        public int NivelGasolina() { return cargaGasolina; } 

        public void cargarGasolina(int cuanto)
        {
            cargaGasolina++;
        }

        public int CargaActual
        {
            get { return cargaActual; }
            private set
            {
                if (value < 0) cargaActual = 0;
                else if (value > capacidadCarga) cargaActual = capacidadCarga;
                else cargaActual = value;
            }
        }

        public int CapacidadCarga 
        {
            get { return capacidadCarga; }
            private set
            {
                if (value > 0) capacidadCarga = value;
            }
        }
    }
}