﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Guia_N__11___PED
{
    class CArco
    {
        public CVertice nDestino;
        public int peso;
        public float grosor_flecha;
        public Color Color;

        /*public CArco(CVertice destino):this(destino,1)
        {
            this.nDestino = destino;
        }*/

        public CArco(CVertice destino, int peso)
        {
            this.nDestino = destino;
            this.peso = peso;
            this.grosor_flecha = 2;
            this.Color = Color.Red;
        }
    }
}
