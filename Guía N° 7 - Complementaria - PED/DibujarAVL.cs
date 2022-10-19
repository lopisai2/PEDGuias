using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
namespace Guía_N__7___Complementaria___PED
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

        public void PreOrden(AVL Raiz, TextBox A,int z)
        {
            if (Raiz != null)
            {
                if(z==0)
                {
                    PreOrden(Raiz.NodoIzquierdo, A,z);
                    A.Text += " " + Raiz.Dato;
                    PreOrden(Raiz.NodoDerecho, A,z);
                }
                else
                {
                    PreOrden(Raiz.NodoIzquierdo, A,z);
                    A.Text += " " + (Raiz.Valor.ToString());
                    PreOrden(Raiz.NodoDerecho, A,z);
                }
                
            }

        }
        public void EnOrden(AVL Raiz, TextBox A,int z)
        {
            if (Raiz != null)
            {
                if(z==0)
                {
                    A.Text += " " + Raiz.Dato;
                    EnOrden(Raiz.NodoIzquierdo, A, z);
                    EnOrden(Raiz.NodoDerecho, A, z);
                }
                else
                {
                    A.Text += " " + (Raiz.Valor.ToString());
                    EnOrden(Raiz.NodoIzquierdo, A, z);
                    EnOrden(Raiz.NodoDerecho, A, z);
                }
                
            }
        }
        public void PostOrden(AVL Raiz, TextBox A,int z)
        {
            if (Raiz != null)
            {
                if(z==0)
                {
                    PostOrden(Raiz.NodoIzquierdo, A, z);
                    PostOrden(Raiz.NodoDerecho, A, z);
                    A.Text += " " + (Raiz.Dato);
                }else
                {
                    PostOrden(Raiz.NodoIzquierdo, A, z);
                    PostOrden(Raiz.NodoDerecho, A, z);
                    A.Text += " " + (Raiz.Valor.ToString());
                }
                
            }
        }
        public void Insertar(int dato, Label A)
        {
            if (Raiz == null)
            {
                Raiz = new AVL(dato, null, null, null);
            }
            else
            {
                Raiz = Raiz.Insertar(dato, Raiz, A);
            }
        }

        public AVL Eliminar(int dato)
        {

            if (Raiz == null)
            {
                return Raiz = new AVL(dato, null, null, null);

            }
            else
            {
                return Raiz.Eliminar(dato, ref Raiz);
            }

        }

        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodoRecorrido(ref int xmin, ref int ymin)
        {
            CoordenadaY = (int)(ymin + Radio / 2);
            CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }

        public void Colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, bool post, bool inor, bool preor, int z)
        {


            if (inor == true)
            {
                if (Raiz != null)
                {
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor,z);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz,z);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz,z);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor,z);
                }
            }
            else if (preor == true)

            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Pens.Black,z);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Pens.Black,z);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor, z);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor, z);
                }
            }
            else if (post == true)

            {
                if (Raiz != null)
                {
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, post, inor, preor, z);
                    Colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, post, inor, preor, z);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, z);
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, z);
                }
            }
        }

        public void ColorearB(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, AVL Raiz, int busqueda,int z)
        {
            

            if (Raiz != null)
            {
                Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, z);
                if (busqueda < Raiz.Valor)
                {
                    Thread.Sleep(500);
                    Raiz.colorear(grafo, fuente, Relleno, Relleno, Lapiz, z);
                    ColorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoIzquierdo, busqueda, z);
                }
                else
                {
                    if (busqueda > Raiz.Valor)
                    {
                        Thread.Sleep(500);
                        Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, z);
                        ColorearB(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.NodoDerecho, busqueda, z);
                    }
                    else

                    {
                        Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, z);
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, string dato, Brush encuentro,int z)
        {
            int x = 500;
            int y = 40;

            if (Raiz == null) return;

            Raiz.PosiciondelNodo(ref x, y);

            Raiz.DibujarRamas(grafo, Lapiz);

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, dato, encuentro,z);

        }

        public int x1 = 100;
        public int y2 = 75;

        public void RestablecerValore()
        {
            x1 = 500;
            y2 = 40;
        }

        public void buscar(int x)
        {
            if (Raiz == null)
            {
                MessageBox.Show("Árbol Vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                Raiz.Buscar(x, Raiz);
            }
        }
    }
}
