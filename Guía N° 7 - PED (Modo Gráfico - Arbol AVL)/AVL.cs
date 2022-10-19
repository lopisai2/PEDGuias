using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Guía_N__7___PED
{
    class AVL
    {        
        public AVL NodoIzquierdo;
        public AVL NodoDerecho;
        public AVL NodoPadredelocho;
        public int valor;
        public int altura;
                
        private DibujarAVL arbol;

        public AVL()
        {

        }

        public DibujarAVL Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }
        //Constructor
        public AVL(int valorNuevo,AVL izquierdo, AVL derecho, AVL padre)
        {
            valor = valorNuevo;
            NodoIzquierdo = izquierdo;
            NodoDerecho = derecho;
            NodoPadredelocho = padre;
            altura = 0;
        }

        //Función para Insertar

        public AVL Insertar(int valorNuevo, AVL Raiz,Label A)
        {
            if(Raiz==null)
            {
                Raiz = new AVL(valorNuevo, null, null, null);
            }else if(valorNuevo<Raiz.valor)
            {
                Raiz.NodoIzquierdo = Insertar(valorNuevo, Raiz.NodoIzquierdo,A);
            }else if(valorNuevo>Raiz.valor)
            {
                Raiz.NodoDerecho = Insertar(valorNuevo, Raiz.NodoDerecho,A);
            }else
            {
                MessageBox.Show("Valor existente en el arbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Fase de Rotaciones - Verificar Simples o Dobles

            if (Alturas(Raiz.NodoIzquierdo) - Alturas(Raiz.NodoDerecho) == 2)
            {
                if (valorNuevo < Raiz.NodoIzquierdo.valor)
                {
                    Raiz = RotacionIzquierdaSimple(Raiz);
                    A.Text = " Rotacion Izquierda Simple";
                }
                else
                {
                    Raiz = RotacionIzquierdaDoble(Raiz);
                    A.Text = " Rotacion Izquierda Doble";
                }
            }else
            if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) == 2)
            {
                if (valorNuevo > Raiz.NodoDerecho.valor)
                {
                    Raiz = RotacionDerechaSimple(Raiz);
                    A.Text = " Rotacion Derecha Simple";
                }
                else
                {
                    Raiz = RotacionDerechaDoble(Raiz);
                    A.Text =" Rotacion Derecha Doble";
                }
            }           
            Raiz.altura = max(Alturas(Raiz.NodoIzquierdo), Alturas(Raiz.NodoDerecho))+1;            
            return Raiz;
        }

        //Función para conocer cuál raíz es mayor

        private static int max(int lhs,int  rhs)
        {
            if(lhs>rhs)
            {
                return lhs;
            }
            else
            {
                return rhs;
            }            
        }

        private static int Alturas(AVL Raiz)
        {
            if(Raiz==null)
            {
                return -1;
            }else
            {
                return Raiz.altura;
            }            
        }

        AVL nodoE, nodoP;
        public AVL Eliminar(int valorEliminar, ref AVL Raiz)
        {
            if(Raiz!=null)
            {                
                if(valorEliminar<Raiz.valor)
                {
                    nodoE = Raiz;
                    Eliminar(valorEliminar, ref Raiz.NodoIzquierdo);
                }else

                {
                    if(valorEliminar>Raiz.valor)
                    {
                        nodoE = Raiz;
                        Eliminar(valorEliminar, ref Raiz.NodoDerecho);
                    }else

                    {
                        AVL NodoEliminar = Raiz;

                        if(NodoEliminar.NodoDerecho==null)
                        {
                            Raiz = NodoEliminar.NodoIzquierdo;

                            if(Alturas(nodoE.NodoIzquierdo)-Alturas(nodoE.NodoDerecho)==2)
                            {
                                if (valorEliminar < nodoE.valor)
                                {
                                    nodoP = RotacionIzquierdaSimple(nodoE);
                                }
                                else

                                {
                                    nodoE = RotacionDerechaSimple(nodoE);
                                }
                            }
                            if(Alturas(nodoE.NodoDerecho)-Alturas(nodoE.NodoIzquierdo)==2)
                            {
                                if(valorEliminar>nodoE.NodoDerecho.valor)
                                {
                                    nodoE = RotacionDerechaSimple(nodoE);
                                }else

                                {
                                    nodoE = RotacionDerechaDoble(nodoE);
                                    nodoP = RotacionDerechaSimple(nodoE);
                                }
                            }
                        }else

                        {
                            if(NodoEliminar.NodoIzquierdo==null)
                            {
                                Raiz = NodoEliminar.NodoDerecho;
                            }else

                            {
                                if(Alturas(Raiz.NodoIzquierdo)-Alturas(Raiz.NodoDerecho)>0)
                                {
                                    AVL AuxiliarNodo = null;
                                    AVL Auxiliar = Raiz.NodoIzquierdo;
                                    bool xbanderax = false;

                                    while(Auxiliar.NodoDerecho!=null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.NodoDerecho;
                                        xbanderax = true;
                                    }

                                    Raiz.valor = Auxiliar.valor;
                                    NodoEliminar = Auxiliar;

                                    if(xbanderax==true)
                                    {
                                        AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
                                    }else

                                    {
                                        Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
                                    }
                                }else

                                {
                                    if(Alturas(Raiz.NodoDerecho)-Alturas(Raiz.NodoIzquierdo)>0)
                                    {
                                        AVL AuxiliarNodo = null;
                                        AVL Auxiliar = Raiz.NodoDerecho;
                                        bool xbanderax = false;

                                        while(Auxiliar.NodoIzquierdo!=null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.NodoIzquierdo;
                                            xbanderax = true;
                                        }

                                        Raiz.valor = Auxiliar.valor;
                                        NodoEliminar = Auxiliar;

                                        if(xbanderax==true)
                                        {
                                            AuxiliarNodo.NodoIzquierdo = Auxiliar.NodoDerecho;
                                        }else

                                        {
                                            Raiz.NodoDerecho = Auxiliar.NodoDerecho;
                                        }

                                    }else
                                    {
                                        if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) == 0)
                                        {
                                            AVL AuxiliarNodo = null;
                                            AVL Auxiliar = Raiz.NodoIzquierdo;
                                            bool xbanderax = false;

                                            while (Auxiliar.NodoDerecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.NodoDerecho;
                                                xbanderax = true;
                                            }

                                            Raiz.valor = Auxiliar.valor;
                                            NodoEliminar = Auxiliar;

                                            if (xbanderax == true)
                                            {
                                                AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
                                            }
                                            else

                                            {
                                                Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }else

            {
                MessageBox.Show("El nodo no existe en el árbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return nodoP;
        }

        //Rotaciones

        private static AVL RotacionIzquierdaSimple(AVL k2)
        {
            AVL k1 = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1.NodoDerecho;
            k1.NodoDerecho = k2;
            k2.altura = max(Alturas(k2.NodoIzquierdo), Alturas(k2.NodoDerecho))+1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), k2.altura) + 1;
            
            return k1;
        }

        private static AVL RotacionDerechaSimple(AVL k1)
        {
            AVL k2 = k1.NodoDerecho;
            k1.NodoDerecho = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), Alturas(k1.NodoDerecho))+1;
            k2.altura = max(Alturas(k2.NodoDerecho), k1.altura) + 1;
            return k2;
        }

        private static AVL RotacionIzquierdaDoble (AVL k3)
        {
            k3.NodoIzquierdo = RotacionDerechaSimple(k3.NodoIzquierdo);
            return RotacionIzquierdaSimple(k3);
        }

        private static AVL RotacionDerechaDoble(AVL k1)
        {
            k1.NodoDerecho = RotacionIzquierdaSimple(k1.NodoDerecho);
            return RotacionDerechaSimple(k1);
        }

        public int getearAltura(AVL nodoActual)
        {
            if(nodoActual==null)
            {
                return 0;
                
            }else
            return 1 + Math.Max(getearAltura(nodoActual.NodoIzquierdo), getearAltura(nodoActual.NodoDerecho));
        }

        public void Buscar(int valorbuscar,AVL Raiz)
        {
            if(Raiz!=null)
            {
                if(valorbuscar<Raiz.valor)
                {
                    Buscar(valorbuscar, Raiz.NodoIzquierdo);
                }else

                {
                    if(valorbuscar>Raiz.valor)
                    {
                        Buscar(valorbuscar, Raiz.NodoDerecho);
                    }
                }
            }else
            {
                MessageBox.Show("Valor no encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------Fase Dibujar Árbol------------------------------------//

        private const int Radio = 30;
        private const int DistanciaH = 40;
        private const int DistanciaV = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        public void PosiciondelNodo(ref int xmin,int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            //Sub Arbol Izquierdo

            if(NodoIzquierdo!=null)
            {
                NodoIzquierdo.PosiciondelNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            
            if ((NodoIzquierdo!=null)&&(NodoDerecho!=null))
            {
                xmin += DistanciaH;
            }

            //Sub Arbol Derecho*

            if (NodoDerecho != null)
            {
                NodoDerecho.PosiciondelNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if(NodoIzquierdo!=null)
            {
                if(NodoDerecho!=null)
                {
                    CoordenadaX = (int)((NodoIzquierdo.CoordenadaX + NodoDerecho.CoordenadaX) / 2);
                }else

                {
                    aux1 = NodoIzquierdo.CoordenadaX;
                    NodoIzquierdo.CoordenadaX = CoordenadaX - 40;
                    CoordenadaX = aux1;
                }
            }else if(NodoDerecho!=null)

            {
                aux2 = NodoDerecho.CoordenadaX;
                NodoDerecho.CoordenadaX = CoordenadaX + 40;
                CoordenadaX = aux2;
            }else

            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if(NodoIzquierdo!=null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, NodoIzquierdo.CoordenadaX, NodoIzquierdo.CoordenadaY);
                NodoIzquierdo.DibujarRamas(grafo, Lapiz);
            }
            if(NodoDerecho!=null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, NodoDerecho.CoordenadaX, NodoDerecho.CoordenadaY);
                NodoDerecho.DibujarRamas(grafo, Lapiz);
            }
        }

        public void DibujarNodo(Graphics grafo,Font fuente,Brush Relleno, Brush Rellenofuente,Pen Lapiz, int dato,Brush encuentro)
        {
            int x;
            x = Alturas(NodoDerecho)-Alturas(NodoIzquierdo);
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);

            if(valor==dato)
            {
                grafo.FillEllipse(encuentro, rect);

            }else
            {
                grafo.FillEllipse(encuentro, rect);
                grafo.FillEllipse(Relleno, rect);
            }
            grafo.DrawEllipse(Lapiz, rect);
            StringFormat formato1 = new StringFormat();
            StringFormat formato2 = new StringFormat();

            formato1.Alignment = StringAlignment.Center;
            formato2.Alignment = StringAlignment.Center;
            formato1.LineAlignment = StringAlignment.Center;
            formato2.LineAlignment = StringAlignment.Center;
            if(x==1)
            {
                grafo.DrawString(x.ToString(), fuente, Brushes.Black, CoordenadaX - 10, CoordenadaY - 20, formato2);
            }
            if (x == -1)
            {
                grafo.DrawString(x.ToString(), fuente, Brushes.Black, CoordenadaX - 10, CoordenadaY - 20, formato2);
            }
            if (x == 0)
            {
                grafo.DrawString(x.ToString(), fuente, Brushes.Black, CoordenadaX - 10, CoordenadaY - 20, formato2);
            }
            grafo.DrawString(valor.ToString(), fuente, Brushes.White, CoordenadaX, CoordenadaY, formato1);

            if(NodoIzquierdo!=null)
            {
                NodoIzquierdo.DibujarNodo(grafo, fuente, Brushes.Fuchsia, Rellenofuente, Lapiz, dato,encuentro);
            }
            if(NodoDerecho!=null)
            {
                NodoDerecho.DibujarNodo(grafo, fuente, Brushes.Green, Rellenofuente, Lapiz, dato, encuentro);
            }
        }

        public void colorear(Graphics grafo, Font fuente, Brush Rellenos, Brush Rellenofuente,Pen Lapiz)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX-Radio/2),(int)(CoordenadaY-Radio/2),Radio,Radio);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            grafo.DrawEllipse(Lapiz, rect);
            grafo.FillEllipse(Rellenos, rect);
            grafo.DrawString(valor.ToString(), fuente, Rellenofuente, CoordenadaX, CoordenadaY, formato);
        }
    }
}
