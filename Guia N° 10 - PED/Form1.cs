using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Guia_N__10___PED
{
    public partial class App : Form
    {
        private CGrafo grafo;
        private CVertice nuevoNodo;
        private CVertice NodoOrigen;
        private CVertice NodoDestino;
        private int var_control = 0;
        private Vertice ventanaVertice;
        private Arco ventanaArco;
        int a = 0; // Se cambia el valor a 1
        int b = 0; // Para que el solo se muestre una vez el mensaje*
        public App()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;            
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true
                );
        }

        private void pizarra_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                if (grafo == null)
                {

                }
                else
                    grafo.DibujarGrafo(e.Graphics);
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pizarra_MouseLeave(object sender, EventArgs e)
        {
            pizarra.Refresh();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nuevoNodo = new CVertice();
            var_control = 2;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {            
            var_control = 4;
            if (a == 0)
            {
                MessageBox.Show("Para eliminar una arista, selecciona el nodo de donde inicia la arista y arrastra el ratón sin soltar el click hasta el nodo donde terminar (donde apunta la flecha)", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            a = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {            
            var_control = 3;
            if (b == 0)
            {
                MessageBox.Show("Para eliminar el vértice, solo haz click en el que deseas.\nSi de dicho vértice salía una arista, esta también se eliminará.\nSi al vértice llegaba una arista, entonces dicha arista no se eliminará.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            b = 1;
        }

        private void pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1:
                    {
                        ventanaArco.ShowDialog();
                        if (ventanaArco.control)
                        {
                            if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                            {
                                if (grafo.AgregarArco(NodoOrigen, NodoDestino, int.Parse(ventanaArco.txtarco.Text)))
                                {
                                }
                                else
                                {
                                    MessageBox.Show("Ya existe un arco entre los vértices: " + NodoOrigen.Valor + " y " + NodoDestino.Valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            var_control = 0;
                            NodoOrigen = null;
                            NodoDestino = null;
                            pizarra.Refresh();
                        }else
                        {
                            var_control = 0;
                            NodoOrigen = null;
                            NodoDestino = null;
                            pizarra.Refresh();
                        }
                    }
                    break;
                case 4:
                    {
                        {
                            if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                            {
                                if (grafo.EliminarArco(NodoOrigen, NodoDestino))
                                {                                    
                                    MessageBox.Show("Se eliminó el arco entre los vértices:" +NodoOrigen.Valor+" y "+NodoDestino.Valor,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }

                            }
                            NodoOrigen = null;
                            NodoDestino = null;                            
                            var_control = 0;
                            pizarra.Refresh();
                        }
                    }
                    break;
            }
        }

        private void pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 2:
                    {
                        if (nuevoNodo != null)
                        {
                            int posX = e.Location.X;
                            int posY = e.Location.Y;
                            if (posX < nuevoNodo.Dimensiones.Width / 2)
                            {
                                posX = nuevoNodo.Dimensiones.Width / 2;

                            }
                            else if (posX > pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            {
                                posX = pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;
                            }

                            if (posY < nuevoNodo.Dimensiones.Height / 2)
                            {
                                posY = nuevoNodo.Dimensiones.Height / 2;
                            }
                            else if (posY > pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2)
                            {
                                posY = pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;
                            }

                            nuevoNodo.Posicion = new Point(posX, posY);
                            pizarra.Refresh();
                            nuevoNodo.DibujarVertice(pizarra.CreateGraphics());
                        }
                    }
                    break;

                case 1:
                    {
                        AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                        bigArrow.BaseCap = LineCap.Triangle;
                        pizarra.Refresh();
                        pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
                        {
                            CustomEndCap = bigArrow
                        }, NodoOrigen.Posicion, e.Location
                            );
                    }
                    break;              
            }
        }

        private void pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                {
                    if (var_control == 3)
                    {
                        grafo.EliminarVertice(NodoOrigen);
                        MessageBox.Show("Se eliminó el vértice: "+NodoOrigen.Valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var_control = 0;
                        pizarra.Refresh();
                    }
                    else if (var_control == 4)
                    {
                        var_control = 4;
                        pizarra.Refresh();
                    }
                    else
                    {
                        var_control = 1;
                    }

                }
                if (nuevoNodo != null && NodoOrigen == null)
                {
                   if(var_control==2)
                    {
                        ventanaVertice.Visible = false;
                        ventanaVertice.control = false;                        
                        ventanaVertice.ShowDialog();

                        if (ventanaVertice.control)
                        {
                            grafo.AgregarVerticie(nuevoNodo);
                            if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null)
                            {
                                nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                            }

                            else
                            {
                                MessageBox.Show("El nodo " + ventanaVertice.txtVertice.Text + " ya existe en el Grafo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            nuevoNodo = null;
                            var_control = 0;
                            pizarra.Refresh();
                            
                        }else
                        {
                            nuevoNodo = null;
                            var_control = 0;
                            pizarra.Refresh();
                        }
                    }
                }

            }

            if (e.Button == MouseButtons.Right)
            {
                if (var_control == 0)
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSCrearVertice.Text = "Nodo " + NodoOrigen.Valor;
                    }
                    else
                    {
                        pizarra.ContextMenuStrip = this.CMSCrearVertice;
                    }
                }
            }
        }


    }
}
