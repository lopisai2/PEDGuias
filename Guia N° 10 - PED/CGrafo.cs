using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Guia_N__10___PED
{
    class CGrafo
    {
        public List<CVertice> nodos;

        public CGrafo()
        {
            nodos = new List<CVertice>();
        }

        public CVertice AgregarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;
        }

        public CVertice EliminarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor);
            nodos.Remove(nodo);
            return nodo;
        }

        public void AgregarVerticie (CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }
        public void EliminarVertice(CVertice nuevonodo)
        {
            nodos.Remove(nuevonodo);
        }

        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }

        public bool AgregarArco(string origen, string nDestino, int peso=1)
        {
            CVertice vOrigen, vnDestino;
            if((vOrigen=nodos.Find(v=>v.Valor==origen))==null)
            {
                throw new Exception("El nodo" + origen + " no existe dentro del grafo");
            }
            if((vnDestino=nodos.Find(v=>v.Valor==nDestino))==null)
            {
                throw new Exception("El nodo"+nDestino+" no Existe dentro del grafo");
            }
            return AgregarArco(vOrigen, vnDestino,peso);
        }
        public bool EliminarArco(string origen, string nDestino, int peso=1)
        {
            CVertice vOrigen, vnDestino;
            vOrigen = nodos.Find(v => v.Valor == origen);
            vnDestino = nodos.Find(v => v.Valor == nDestino);
            if(vOrigen==vnDestino)
            {
               
            }else
            {
                return false;
            }
            return EliminarArco(vOrigen, vnDestino);
        }

        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso)
        {
            if(origen.ListaAdyacencia.Find(v=>v.nDestino==nDestino)==null)
            {
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));                
                return true;
            }else
            {                
                return false;
            }
            
        }

        public bool EliminarArco(CVertice origen, CVertice nDestino)
        {
            if(origen.ListaAdyacencia.Find(v=>v.nDestino==nDestino)!=null)
            {                
                origen.ListaAdyacencia.RemoveAll(c => c.nDestino == nDestino);
                return true;                
            }
            return false;
        }
        public void DibujarGrafo(Graphics g)
        {
            foreach(CVertice nodo in nodos)
            {
                nodo.DibujarArco(g);
            }
            foreach(CVertice nodo in nodos)
            {
                nodo.DibujarVertice(g);
            }
                
        }

        public CVertice DetectarPunto(Point posicionmouse)
        {
            foreach(CVertice nodoaActual in nodos)
            {
                if(nodoaActual.DetectarPunto(posicionmouse))
                {
                    return nodoaActual;
                }
            }
            return null;
        }

        public void RestablecerGrafo(Graphics g)
        {
            foreach(CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach(CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.Color = Color.Black;
                }
            }

            DibujarGrafo(g);
        }
    }
}
