using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Guia_N__11___PED
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
        List<CVertice> nodosRuta;
        List<CVertice> nodosOrdenados;
        bool buscarRuta = false, nuevoVertice = false, nuevoArco = false;
        private int numeronodos = 0;
        bool profundidad = false, anchura = false, nodoEncontrado = false;
        Queue cola = new Queue();
        
        
        private string destino = "", origen = "";
        private int distancia = 0;
        private int totalNodos;
        int[] parent;
        bool[] visitados;
        public App()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();
            nodosRuta = new List<CVertice>();
            nodosOrdenados = new List<CVertice>();
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
                {
                    grafo.DibujarGrafo(e.Graphics);
                    if (nuevoVertice)
                    {
                        CBVertice.Items.Clear();
                        CBVertice.SelectedIndex = -1;
                        CBNodoPartida.Items.Clear();
                        CBNodoPartida.SelectedIndex = -1;

                        foreach (CVertice nodo in grafo.nodos)
                        {
                            CBVertice.Items.Add(nodo.Valor);
                            CBNodoPartida.Items.Add(nodo.Valor);
                        }
                        nuevoVertice = false;
                    }
                    if (nuevoArco)
                    {
                        CBArco.Items.Clear();
                        CBArco.SelectedIndex = -1;
                        foreach (CVertice nodo in grafo.nodos)
                        {
                            foreach (CArco arco in nodo.ListaAdyacencia)
                            {
                                CBArco.Items.Add("(" + nodo.Valor + "," + arco.nDestino.Valor + ") peso: " + arco.peso);
                            }
                        }
                        nuevoArco = false;
                    }
                    if (buscarRuta)
                    {
                        foreach (CVertice nodo in nodosRuta)
                        {
                            nodo.colorear(e.Graphics);
                            Thread.Sleep(1000);
                            nodo.DibujarVertice(e.Graphics);
                        }
                        buscarRuta = false;
                    }
                    if (profundidad)
                    {                        
                        ordenarNodos();
                        lblrespuestacion.Text=origen;
                        foreach (CVertice nodo in nodosOrdenados)
                        {
                            if (!nodo.visitado)
                            {
                                recorridoProfundidad(nodo, e.Graphics,lblrespuestacion);                                
                            }
                        }
                        profundidad = false;
                        foreach (CVertice nodo in grafo.nodos)
                        {
                            nodo.visitado = false;
                        }
                    }
                    if (anchura)
                    {
                        distancia = 0;
                        cola = new Queue();
                        ordenarNodos();
                        lblrespuestacion.Text = origen;
                        foreach (CVertice nodo in nodosOrdenados)
                        {
                            if (!nodo.visitado && !nodoEncontrado)
                            {
                                recorridoAnchura(nodo, e.Graphics, destino,lblrespuestacion);
                            }
                        }
                        anchura = false;
                        nodoEncontrado = false;
                        foreach (CVertice nodo in grafo.nodos)
                        {
                            nodo.visitado = false;
                        }
                    }
                }


            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ordenarNodos()
        {
            nodosOrdenados = new List<CVertice>();
            bool est = false;

            foreach (CVertice nodo in grafo.nodos)
            {
                if (nodo.Valor == origen)
                {
                    nodosOrdenados.Add(nodo);
                    est = true;
                }
                else if (est)
                {
                    nodosOrdenados.Add(nodo);
                }
            }
            foreach (CVertice nodo in grafo.nodos)
            {
                if (nodo.Valor == origen)
                {
                    est = false;
                    break;
                }
                else if (est)
                {
                    nodosOrdenados.Add(nodo);
                }
            }
        }

        private void recorridoProfundidad(CVertice vertice, Graphics g, Label A)
        {
            vertice.visitado = true;
            vertice.colorear(g);
            Thread.Sleep(1000);
            vertice.DibujarVertice(g);            
            
            foreach (CArco adya in vertice.ListaAdyacencia)
            {
                if (!adya.nDestino.visitado)
                {
                    A.ForeColor = Color.Green;
                    A.Text += " " + adya.nDestino.Valor;
                    recorridoProfundidad(adya.nDestino, g,A);
                    
                }
            }
        }

        private void recorridoAnchura(CVertice vertice, Graphics g, string destino,Label A)
        {
            vertice.visitado = true;
            cola.Enqueue(vertice);
            vertice.colorear(g);
            Thread.Sleep(1000);
            vertice.DibujarArco(g);            
            if (vertice.Valor == destino)
            {
                nodoEncontrado = true;
                return;
            }
            while (cola.Count > 0)
            {
                CVertice aux = (CVertice)cola.Dequeue();
                foreach (CArco adya in aux.ListaAdyacencia)
                {
                    if (!adya.nDestino.visitado)
                    {
                        if (!nodoEncontrado)
                        {
                            adya.nDestino.visitado = true;
                            adya.nDestino.colorear(g);
                            Thread.Sleep(1000);
                            adya.nDestino.DibujarVertice(g);
                            if (destino != "")
                            {
                                distancia += adya.peso;
                                cola.Enqueue(adya.nDestino);                                
                            }                            

                            if (adya.nDestino.Valor == destino)
                            {
                                nodoEncontrado = true;                                
                                return;
                            }
                        }
                        A.ForeColor = Color.Yellow;
                        lblrespuestacion.Text += adya.nDestino.Valor;
                    }
                }
            }          
        }

        private void calcularMatricesInciales()
        {
            nodosRuta = new List<CVertice>();
            totalNodos = grafo.nodos.Count;
            parent = new int[totalNodos];
            visitados = new bool[totalNodos];
            List<Temp> filaDistancia = new List<Temp>();
            for (int i = 0; i < totalNodos; i++)
            {

                for (int j = 0; j < totalNodos; j++)
                {
                    if (i == j)
                    {
                        
                    }
                    else
                    {                        
                        for (int k = 0; k < grafo.nodos[i].ListaAdyacencia.Count; k++)
                        {
                            if (grafo.nodos[i].ListaAdyacencia[k].nDestino == grafo.nodos[j])
                            {
                                Temp temp = new Temp();
                                temp.Nodo_Origen = grafo.nodos[i].Valor.ToString();
                                temp.Nodo_Destino = grafo.nodos[j].Valor.ToString();
                                temp.Distancia = grafo.nodos[i].ListaAdyacencia[k].peso.ToString();
                                filaDistancia.Add(temp);
                            }
                        }
                        
                    }
                    
                }                
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filaDistancia;
            
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void btndeletever_Click(object sender, EventArgs e)
        {
            if (CBVertice.SelectedIndex > -1)
            {
                foreach (CVertice nodo in grafo.nodos)
                {
                    if (nodo.Valor == CBVertice.SelectedItem.ToString())
                    {
                        grafo.nodos.Remove(nodo);
                        nodo.ListaAdyacencia = new List<CArco>();
                        break;
                    }
                }
                foreach (CVertice nodo in grafo.nodos)
                {
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        if (arco.nDestino.Valor == CBVertice.SelectedItem.ToString())
                        {
                            nodo.ListaAdyacencia.Remove(arco);
                            break;
                        }
                    }
                }
                nuevoArco = true;
                nuevoVertice = true;
                CBVertice.SelectedIndex = -1;
                pizarra.Refresh();
            }
            else
            {
                lblrespuestacion.Text = "Seleccione un nodo";
                lblrespuestacion.ForeColor = Color.Red;
            }
        }

        private void btndeletearco_Click(object sender, EventArgs e)
        {
            if (CBArco.SelectedIndex > -1)
            {
                foreach (CVertice nodo in grafo.nodos)
                {
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        if ("(" + nodo.Valor + "," + arco.nDestino.Valor + ") peso: " + arco.peso == CBArco.SelectedItem.ToString())
                        {
                            nodo.ListaAdyacencia.Remove(arco);
                            break;
                        }
                    }
                }
                nuevoArco = true;
                nuevoVertice = true;
                CBArco.SelectedIndex = -1;
                pizarra.Refresh();
            }
            else
            {
                lblrespuestacion.Text = "Seleccione un arco";
                lblrespuestacion.ForeColor = Color.Red;
            }
        }

        private void btnprofundidad_Click(object sender, EventArgs e)
        {
            if (CBNodoPartida.SelectedIndex > -1)
            {
                profundidad = true;
                origen = CBNodoPartida.SelectedItem.ToString();
                pizarra.Refresh();
                CBNodoPartida.SelectedIndex = -1;
            }
            else
            {
                lblrespuestacion.Text = "Seleccione un nodo de partida";
                lblrespuestacion.ForeColor = Color.Red;
            }
        }

        private void btnanchura_Click(object sender, EventArgs e)
        {
            if (CBNodoPartida.SelectedIndex > -1)
            {
                origen = CBNodoPartida.SelectedItem.ToString();
                anchura = true;
                pizarra.Refresh();
                CBNodoPartida.SelectedIndex = -1;
            }
            else
            {
                lblrespuestacion.Text = "Seleccione un nodo de partida";
                lblrespuestacion.ForeColor = Color.Red;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtvertice.Text.Trim() != "")
            {
                if (grafo.BuscarVertice(txtvertice.Text) != null)
                {
                    lblrespuestacion.Text = "Si se encuentra el vertice " + txtvertice.Text;
                    lblrespuestacion.ForeColor = Color.Blue;
                }
                else
                {
                    lblrespuestacion.Text = "No se encuentra el vértice " + txtvertice.Text;
                    lblrespuestacion.ForeColor = Color.Red;
                }
            }
        }

        private void btndistancia_Click(object sender, EventArgs e)
        {
            calcularMatricesInciales();    
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
                                    int distancia = int.Parse(ventanaArco.txtarco.Text);
                                    NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                                }
                                else
                                {
                                    MessageBox.Show("Ya existe un arco entre los vértices: " + NodoOrigen.Valor + " y " + NodoDestino.Valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                nuevoArco = true;
                            }
                            var_control = 0;
                            nuevoArco = true;
                            NodoOrigen = null;
                            NodoDestino = null;
                            pizarra.Refresh();
                        }
                        else
                        {
                            var_control = 0;
                            nuevoArco = true;
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
                                    MessageBox.Show("Se eliminó el arco entre los vértices:" + NodoOrigen.Valor + " y " + NodoDestino.Valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            NodoOrigen = null;
                            NodoDestino = null;
                            nuevoArco = true;
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
                        MessageBox.Show("Se eliminó el vértice: " + NodoOrigen.Valor, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var_control = 0;
                        nuevoVertice = true;
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
                    if (var_control == 2)
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
                            nuevoVertice = true;
                            var_control = 0;
                            pizarra.Refresh();

                        }
                        else
                        {
                            nuevoNodo = null;
                            nuevoVertice = true;
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
