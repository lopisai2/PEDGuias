using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guía_N_3._2___PED
{

    class nodo
    {
        public int dato; //Información del nodo.
        public nodo siguiente; //Enlace del nodo.
    }
    class Lista
    {
        public int x = 0;
        public nodo inicio; //Para utilizar los atributos de la clase nodo.
        public Lista()
        {
            inicio = null;
        }
        public void Orden(int num)
        {
            nodo sec = new nodo();
            sec.dato = num;
            if (inicio == null)
            {
                inicio = sec;
            }
            else if (inicio.dato > sec.dato)
            {
                nodo terc;
                terc = inicio;
                inicio = sec;
                sec.siguiente = terc;

            }
            else
            {
                nodo terc;
                nodo quint;

                terc = inicio;
                quint = inicio;
                while (terc.siguiente != null)
                {
                    terc = terc.siguiente;
                    quint = terc;
                    quint.dato = terc.dato;
                    if (quint.dato > sec.dato)
                    {
                        break;
                    }
                }
                nodo cuart;
                cuart = quint.siguiente;
                quint.siguiente = sec;
                sec.siguiente = cuart;
            }
            x++;
        }
        public void Insertaralinicio(int item)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
                x++;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
                x++;
            }

        }

        public void Insertaralfinal(int item)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
                x++;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
                x++;
            }
        }
        public void InsertarEspecifico(int item, int pos)
        {

            nodo auxiliar = new nodo(); //Nodo que se está agregando
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (pos > x)
            {
                Insertaralfinal(item);

                Console.WriteLine("La posición en la lista no existe, se insertará en el final.");
            }
            if (pos <= x)
            {
                if (inicio == null)
                {
                    inicio = auxiliar;
                    x++;
                }
                else
                {
                    nodo puntero;
                    puntero = inicio; //Se viaja entre la lista
                    if (pos == 1)
                    {
                        inicio = auxiliar; //El nodo ahora es el inicial
                        auxiliar.siguiente = puntero; //El nodo que antes era el inicial está en la posicion 2
                    }
                    else
                    {
                        for (int i = 1; i < pos - 1; i++)
                        {
                            puntero = puntero.siguiente;
                            if (puntero.siguiente == null)
                                break;
                        }
                        nodo punteroexterno;
                        punteroexterno = puntero.siguiente; //Identifica el nodo final?
                        puntero.siguiente = auxiliar;// Toma la información del nodo que se está agregando, por ello ahora este es el nodo final
                        auxiliar.siguiente = punteroexterno;// 
                        x++;

                    }

                }
                
            }
            

        }
        public void EliminarInicio()
        {
            if (inicio == null)
            {

            }
            else
            {
                inicio = inicio.siguiente;
                x--;
            }
        }
        public void EliminarFinal()
        {
            if (inicio == null)
            {

            }
            else
            {
                nodo punteroanterior, punteroposterior;
                punteroanterior = inicio;
                punteroposterior = inicio;
                while (punteroposterior.siguiente != null)
                {
                    punteroanterior = punteroposterior;
                    punteroposterior = punteroposterior.siguiente;
                }
                punteroanterior.siguiente = null;
                x--;
            }

        }

        public void MostrarContenido()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    
                }
            }
        }

        public override string ToString()
        {
            return inicio.dato.ToString();
        }
    }
}
