using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;


namespace Guía_5___PED
{
    class NodoArbol
    {
        public int info;
        public int altura;
        public int nivel;
        public int suma = 0;
        public int sumanodos = 0;
        public NodoArbol Izquierdo;
        public NodoArbol Derecho;
        public NodoArbol Padre;
       // public Rectangle nodo;  //Dibujar Nodo

        private const int Radio = 30;
        private const int DistanciaHorizontal = 80;
        private const int DistanciaVertical = 10;
        private int CoordenadaX;
        private int CoordenadaY;
        Graphics col;
        private Arbol_Binario arbol;
        public NodoArbol()
        {

        }
        public Arbol_Binario Arbol
        {
            get
            { return arbol; }
            set
            { arbol = value; }
        }

        public NodoArbol(int nuevainfo, NodoArbol izquierdo, NodoArbol derecho, NodoArbol padre)
        {
            info = nuevainfo;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }
       
        public NodoArbol Insertar(int x, NodoArbol t, int nivel)
        {
            if (t == null)
            {
                t = new NodoArbol(x, null, null, null);                
                t.nivel = nivel;               
            }
            else if (x < t.info)
            {
                nivel++;
                t.Izquierdo = Insertar(x, t.Izquierdo, nivel);
            }
            else if (x > t.info)
            {
                nivel++;
                t.Derecho = Insertar(x, t.Derecho, nivel);
            }
            else
            {
                MessageBox.Show("El dato ya existe en el árbol", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sumanodos--;
                suma = suma - x;
            }                        
            return t;
        }
        
        public void Eliminar(int x, ref NodoArbol t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x > t.info)
                    {
                        Eliminar(x, ref t.Derecho);
                    }
                    else
                    {
                        NodoArbol Nodoeliminar = t;
                        if (Nodoeliminar.Derecho == null)
                        {
                            t = Nodoeliminar.Izquierdo;
                        }
                        else
                        {
                            if (Nodoeliminar.Izquierdo == null)
                            {
                                t = Nodoeliminar.Derecho;
                            }
                            else
                            {
                                if (alturas(t.Izquierdo) - alturas(t.Derecho) > 0)
                                {
                                    NodoArbol auxnodo = null;
                                    NodoArbol aux = t.Izquierdo;
                                    bool xbanderax = false;
                                    while (aux.Derecho != null)
                                    {
                                        auxnodo = aux;
                                        aux = aux.Derecho;
                                        xbanderax = true;
                                    }
                                    t.info = aux.info;
                                    Nodoeliminar = aux;
                                    if (xbanderax == true)
                                    {
                                        auxnodo.Derecho = aux.Izquierdo;
                                    }
                                    else
                                    {
                                        t.Izquierdo = aux.Izquierdo;
                                    }
                                }
                                else
                                {
                                    if (alturas(t.Derecho) - alturas(t.Izquierdo) > 0)
                                    {
                                        NodoArbol auxnodo = null;
                                        NodoArbol aux = t.Derecho;
                                        bool xbanderax = false;
                                        while (aux.Izquierdo != null)
                                        {
                                            auxnodo = aux;
                                            aux = aux.Izquierdo;
                                            xbanderax = true;
                                        }
                                        t.info = aux.info;
                                        Nodoeliminar = aux;
                                        if (xbanderax == true)
                                        {
                                            auxnodo.Izquierdo = aux.Derecho;
                                        }
                                        else
                                        {
                                            t.Derecho = aux.Derecho;
                                        }
                                    }
                                    else
                                    {
                                        if (alturas(t.Derecho) - alturas(t.Izquierdo) == 0)
                                        {
                                            NodoArbol auxnodo = null;
                                            NodoArbol aux = t.Izquierdo;
                                            bool xbanderax = false;
                                            while (aux.Derecho != null)
                                            {
                                                auxnodo = aux;
                                                aux = aux.Derecho;
                                                xbanderax = true;
                                            }
                                            t.info = aux.info;
                                            Nodoeliminar = aux;
                                            if (xbanderax == true)
                                            {
                                                auxnodo.Derecho = aux.Izquierdo;
                                            }
                                            else
                                            {
                                                t.Izquierdo = aux.Izquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay nodo en el árbol", "Error en la eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void buscar(int x, NodoArbol t)
        {
            if (t != null)
            {
                if (x == t.info)
                {
                    MessageBox.Show("Nodo encontrado en la posición X: " + t.CoordenadaX + " Y: " + t.CoordenadaY+"\nCon altura:"+t.nivel,"Arbol Binario",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    encontrado(t);
                }
                else
                {
                    if(x<t.info)
                    {
                        buscar(x, t.Izquierdo);
                    }
                    else
                    {
                        if(x>t.info)
                        {
                            buscar(x, t.Derecho);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void posicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 3);

            if(Izquierdo!=null)
            {
                Izquierdo.posicionNodo(ref xmin, ymin + Radio + DistanciaVertical);
            }
            if(Izquierdo!=null&&Derecho!=null)
            {
                xmin += DistanciaHorizontal;
            }
            if(Derecho!=null)
            {
                Derecho.posicionNodo(ref xmin, ymin + Radio + DistanciaVertical);
            }

            if(Izquierdo!=null&&Derecho!=null)
            {
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            }
            else if(Izquierdo!=null)
            {
                aux1 = Izquierdo.CoordenadaX;
                Izquierdo.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if(Derecho!=null)
            {
                aux2 = Derecho.CoordenadaX;
                Derecho.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        public void DibujarRamas(Graphics grafo, Pen lapiz)
        { 
            if(Izquierdo!=null)
            {
                grafo.DrawLine(lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, lapiz);
            }
            if(Derecho!=null)
            {
                grafo.DrawLine(lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, lapiz);
            }
        }

        public void DibujarNodo(Graphics grafo, Font fuente, Brush relleno, Brush rellenofuente, Brush encuentro,Pen lapiz)
        {
          
            col = grafo;
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            Rectangle prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(relleno, rect);
            grafo.DrawEllipse(lapiz, rect);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, rellenofuente, CoordenadaX, CoordenadaY,formato);
            grafo.DrawString(nivel.ToString(), fuente, Brushes.Red, CoordenadaX - 20, CoordenadaY - 20);
            if (Izquierdo!=null)
            {                
                Izquierdo.DibujarNodo(grafo, fuente, relleno, rellenofuente, encuentro, lapiz);
            }
            if(Derecho!=null)
            {
                
                Derecho.DibujarNodo(grafo, fuente, relleno, rellenofuente, encuentro, lapiz);
            }
        }
        public void Colorear (Graphics grafo, Font fuente, Brush relleno, Brush rellenofuente, Pen lapiz)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(relleno, rect);
            grafo.DrawEllipse(lapiz, rect);
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, rellenofuente, CoordenadaX, CoordenadaY,formato);
        }
        //Altura del arbol
        private static int alturas(NodoArbol t)
        {
            return t == null ?-1:t.altura;
        }
        public void encontrado(NodoArbol t)
        {
            Rectangle rec = new Rectangle(t.CoordenadaX, t.CoordenadaY, 40, 40);
        }
        public int getearalturaxd(NodoArbol t)
        {
            if (t == null)
            {
                return 0;
            }
            else
                return 1 + Math.Max(getearalturaxd(t.Izquierdo), getearalturaxd(t.Derecho));
        }
    }
}
