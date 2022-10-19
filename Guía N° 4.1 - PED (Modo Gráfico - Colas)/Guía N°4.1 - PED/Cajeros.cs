using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guía_N_4._1___PED
{
    class Cajero1
    {
        private string nombre;
        public string Persona
        {
            get=> nombre;

            set 
            {
                nombre = value;

                if(Persona=="")
                {

                }

            }
            
        }
    }
    class Cajero2:Cajero1
    {

    }
    class Cajero3:Cajero1
    {

    }
    class Cajero4:Cajero1
    {
        
    }
}
