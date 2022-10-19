using System;

namespace Guía_N_3._1___PED
{
    
    class nodo
    {
        public int dato; //Información del nodo.
        public nodo siguiente; //Enlace del nodo.
    }
    class Lista
    {
        public int x =0;
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
                while(terc.siguiente!=null)
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
                Console.Write("{0} ->\t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0} ->\t", puntero.dato);
                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string op, x = null;
                Lista nuevalista = new Lista();
                do
                {
                    
                    int y, z;
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine("*A.Insertar al frente.                                          *");
                    Console.WriteLine("*B.Insertar al final.                                           *");
                    Console.WriteLine("*C.Insertar en una posición específica.                         *");                    
                    Console.WriteLine("*D.Insertar ascendentemente.                                    *");
                    Console.WriteLine("*E.Eliminar al frente.                                          *");
                    Console.WriteLine("*F.Eliminar al final.                                           *");
                    Console.WriteLine("*G.Mostrar lista.                                               *");
                    Console.WriteLine("*F.Salir.                                                       *");
                    Console.WriteLine("*****************************************************************");
                    op = Console.ReadLine();
                    switch (op)
                    {
                        case "A":
                        case "a":
                            {
                                Console.Write("Ingresa el valor a continuación:");
                                y = Convert.ToInt32(Console.ReadLine());
                                nuevalista.Insertaralinicio(y);
                                Console.WriteLine("Dato agregado a la lista.");

                                break;
                            }
                        case "B":
                        case "b":
                            {
                                Console.Write("Ingresa el valor a continuación:");
                                y = Convert.ToInt32(Console.ReadLine());
                                nuevalista.Insertaralfinal(y);
                                Console.WriteLine("Dato agregado a la lista.");
                                break;
                            }
                        case "C":
                        case "c":
                            {
                                Console.Write("Ingresa el valor a continuación:");
                                y = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Ingresa la posición en la lista");
                                z = Convert.ToInt32(Console.ReadLine());
                                nuevalista.InsertarEspecifico(y,z);
                                Console.WriteLine("Dato agregado a la lista. {0}",(nuevalista.x));
                                break;
                            }
                        case "D":
                        case "d":
                            {
                                Console.Write("Ingresa el valor a continuación:");
                                y = Convert.ToInt32(Console.ReadLine());
                                nuevalista.Orden(y);
                                Console.WriteLine("Dato agregado a la lista. {0}", (nuevalista.x));
                                break;
                                
                            }
                        case "E":
                        case "e":
                            {
                                nuevalista.EliminarInicio();
                                break;
                                
                            }
                        case "F":
                        case "f":
                            {
                                nuevalista.EliminarFinal();
                                break;
                                
                            }
                        case "G":
                        case "g":
                            {
                                nuevalista.MostrarContenido();                                
                                break;
                            }
                        case "H":
                        case "h":
                            {
                                Console.WriteLine("Pulse una tecla para salir.");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                            }
                    }

                    Console.WriteLine("¿Continuar en el menú?(S/N)");
                    x = Console.ReadLine();
                    while ((x == "N" && x == "n") || (x != "s" && x != "S"))
                    {
                        if (x == "n" || x == "N")
                        {
                            Console.WriteLine("Salir del programa?(S/N)");
                            x = Console.ReadLine();
                            if (x == "S" || x == "s")
                            {
                                Environment.Exit(0);
                            }
                        }
                        if ((x != "n" && x != "N") && (x != "S" && x != "s"))
                        {
                            Console.WriteLine("Opción inválida.");
                        }
                        Console.WriteLine("¿Continuar en el menú?(S/N)");
                        x = Console.ReadLine();
                    }
                    Console.Clear();
                } while (x == "S" || x == "s");

            }
            catch (Exception A)
            {

                Console.WriteLine(A.Message);
            }
        }
            
    }
}
