using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace Guía_N_8___PED
{
    public class HashTable1
    {
        private string clave;
        private string descripcion;
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Hashtable tabla = new Hashtable();
      
        
        
    }
}
