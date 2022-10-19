using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_N__11___PED
{
    public class Temp
    {
        private string distancia;
        private string nodo_Origen;
        private string nodo_Destino;

        public string Nodo_Origen
        {
            get => nodo_Origen;
            set => nodo_Origen = value;
        }

        public string Nodo_Destino
        {
            get => nodo_Destino;
            set => nodo_Destino = value;
        }
        public string Distancia
        {
            get => distancia;
            set => distancia = value;
        }
    }
}
