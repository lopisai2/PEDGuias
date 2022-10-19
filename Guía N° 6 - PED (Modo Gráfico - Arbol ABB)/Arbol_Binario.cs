using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Guía_5___PED
{
    class Arbol_Binario
    {
        public NodoArbol Raiz;
        public NodoArbol aux;
        public int suma = 0;
        public int sumanodos = 0;

        public Arbol_Binario()
        {
            aux = new NodoArbol();
        }

        public Arbol_Binario(NodoArbol nuevaraiz)
        {
            Raiz = nuevaraiz;
            
        }
        public void Preorden(NodoArbol raiz,TextBox a)
        {           
            if(raiz!=null)
            {
                a.Text+=" "+(raiz.info.ToString());
                Preorden(raiz.Izquierdo,a);
                Preorden(raiz.Derecho,a);                
            }
            
        }
        public void Enorden(NodoArbol raiz, TextBox a)
        {            
            if (raiz != null)
            {                
               Enorden(raiz.Izquierdo, a);
                a.Text +=" "+ (raiz.info.ToString());
                Enorden(raiz.Derecho, a);
            }

        }
        public void PostOrden(NodoArbol raiz, TextBox a)
        {            
            if (raiz != null)
            {
                PostOrden(raiz.Izquierdo, a);                
                PostOrden(raiz.Derecho, a);
                a.Text +=" "+ (raiz.info.ToString());
            }

        }

        public void Insertar(int x)
        {
            if(Raiz==null)
            {
                Raiz = new NodoArbol(x, null, null, null);
                Raiz.nivel = 0;
                Raiz.suma += x;
                Raiz.sumanodos++;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
                Raiz.suma += x;
                Raiz.sumanodos++;
            }
        }
       
        public void Eliminar(int x)
        {
            if(Raiz==null)
            {
                Raiz = new NodoArbol(x, null, null, null);
                Raiz.suma = 0;
                Raiz.sumanodos = 0;
            }
            else
            {
                Raiz.Eliminar(x, ref Raiz);
                Raiz.suma -= x;
                Raiz.sumanodos--;
            }
        }

        public void Buscar(int x)
        { 
            if(Raiz!=null)
            {
                Raiz.buscar(x, Raiz);
            }
        }

        public void DibujarArbol(Graphics grafo, Font fuente, Brush relleno, Brush rellenofuente, Pen lapiz, Brush encuentro)
        {
            int x = 400;
            int y = 75;
            if(Raiz==null)
            {
                return;
            }
            Raiz.posicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo,lapiz);
            Raiz.DibujarNodo(grafo, fuente, relleno, rellenofuente, encuentro, lapiz);
        }
        public int x1 = 400;
        public int x2 = 75;

        public void Colorear(Graphics grafo, Font fuente, Brush relleno, Brush rellenofuente, Pen lapiz, NodoArbol Raiz,bool post,bool inor,bool preor)
        {
            Brush entorno = Brushes.Red;
            if(inor==true)
            {
                if(Raiz!=null)
                {
                    Colorear(grafo, fuente, relleno, rellenofuente, lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.Colorear(grafo, fuente, entorno, rellenofuente, lapiz);
                    Thread.Sleep(300);
                    Raiz.Colorear(grafo, fuente, relleno, rellenofuente, lapiz);
                    Colorear(grafo, fuente, relleno, rellenofuente, lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if(preor==true)
            {
                if(Raiz!=null)
                {
                    Raiz.Colorear(grafo, fuente, entorno, rellenofuente, lapiz);
                    Thread.Sleep(300);

                    Raiz.Colorear(grafo, fuente, relleno, rellenofuente, lapiz);
                    Colorear(grafo, fuente, relleno, rellenofuente, lapiz, Raiz.Izquierdo, post, inor, preor);
                    Colorear(grafo, fuente, relleno, rellenofuente, lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if(post==true)
            {
                if(Raiz!=null)
                {
                    Colorear(grafo, fuente, relleno, rellenofuente, lapiz, Raiz.Izquierdo, post, inor, preor);
                    Colorear(grafo, fuente, relleno, rellenofuente, lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.Colorear(grafo, fuente, entorno, rellenofuente, lapiz);
                    Thread.Sleep(300);
                    Raiz.Colorear(grafo, fuente, relleno, rellenofuente, lapiz);
                }
            }
        }
    }
}
