using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Guía_N__7___PED
{
    class DibujarAVL
    {
        public AVL Raiz;
        public AVL aux;

        public DibujarAVL()
        {
            aux = new AVL();
        }

        public DibujarAVL(AVL Raiznueva)
        {
            Raiz = Raiznueva;
        }

        public void PreOrden(AVL Raiz,TextBox A)
        {
            if(Raiz!=null)
            {
                PreOrden(Raiz.NodoIzquierdo, A);
                A.Text += " " + (Raiz.valor.ToString());
                PreOrden(Raiz.NodoDerecho, A);
            }

        }
        public void EnOrden(AVL Raiz, TextBox A)
        {
            if(Raiz!=null)
            {
                A.Text += " " + (Raiz.valor.ToString());
                EnOrden(Raiz.NodoIzquierdo, A);
                EnOrden(Raiz.NodoDerecho, A);
            }
        }
        public void PostOrden(AVL Raiz,TextBox A)
        {
            if(Raiz!=null)
            {
                PostOrden(Raiz.NodoIzquierdo, A);
                PostOrden(Raiz.NodoDerecho, A);
                A.Text += " " + (Raiz.valor.ToString());
            }
        }
        public void Insertar(int dato,Label A)
        {
            if(Raiz==null)
            {
                Raiz = new AVL(dato, null, null, null);
            }else
            {
                Raiz=Raiz.Insertar(dato, Raiz,A);
            }
        }

        public void Eliminar(int dato)
        {
            if(Raiz==null)
            {
                Raiz = new AVL(dato, null, null, null);
            }else
            {
                Raiz.Eliminar(dato, ref Raiz);
            }
        }

        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodoRecorrido(ref int xmin,ref int ymin)
        {
            CoordenadaY = (int)(ymin + Radio / 2);
            CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }

        public void Colorear(Graphics grafo,Font fuente, Brush Relleno, Brush RellenoFuente,Pen Lapiz,AVL Raiz, bool post,bool inor, bool preor)
        {
            Brush entorno = Brushes.Aqua;

            if(inor==true)
            {
                if(Raiz!=null)
                {
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
                }
            }else if(preor==true)

            {
                if(Raiz!=null)
                {
                    Raiz.colorear(grafo, fuente,Relleno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
                }
            }else if(post==true)

            {
                if(Raiz!=null)
                {
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }

        public void ColorearB(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz,int busqueda)
        {
            Brush entorno = Brushes.Red;

            if(Raiz!=null)
            {
                Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                if(busqueda<Raiz.valor)
                {
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, entorno, Brushes.Blue, Lapiz);
                    ColorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, busqueda);
                }else
                {
                    if (busqueda > Raiz.valor)
                    {
                        Thread.Sleep(500);
                        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        ColorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, busqueda);
                    }else

                    {
                        Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public void DibujarArbol(Graphics grafo,Font fuente,Brush Relleno, Brush RellenoFuente, Pen Lapiz, int dato, Brush encuentro)
        {
            int x = 100;
            int y = 75;

            if (Raiz == null) return;

            Raiz.PosiciondelNodo(ref x, y);

            Raiz.DibujarRamas(grafo, Lapiz);

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, dato, encuentro);

        }

        public int x1 = 100;
        public int y2 = 75;

        public void RestablecerValore()
        {
            x1 = 100;
            y2 = 75;
        }

        public void buscar(int x)
        {
            if(Raiz==null)
            {
                MessageBox.Show("Árbol Vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                Raiz.Buscar(x, Raiz);
            }
        }   
    }
}
