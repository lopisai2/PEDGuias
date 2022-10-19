using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Guía_N__9___PED
{
    public partial class App : Form
    {
        int x0, y0, tam;
        bool ec = false;
        bool estado = false;
        int n = 0;
        int[] Arreglo_Numeros;
        int i = 1;
        Button[] Arreglo; //Arreglo de botones para simular valores ingresados.

        public App()
        {
            InitializeComponent();
            tam = page1.Width / 2;
            x0 = tam;
            y0 = 20;
            textBox1.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int y = 0;
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                Array.Resize<int>(ref Arreglo_Numeros, i + 1);
                for (int x = 0; x < Arreglo_Numeros.Length; x++)
                {
                    if (Arreglo_Numeros[x] == num)
                    {
                        MessageBox.Show("El dato ya existe en el árbol Heap.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        y = num;
                        break;
                    }

                }
                if (y == num)
                {
                    y = 0;
                }
                else
                {
                    Arreglo_Numeros[i] = num;
                    Array.Resize<Button>(ref Arreglo, i + 1);
                    Arreglo[i] = new Button();
                    Arreglo[i].Text = Arreglo_Numeros[i].ToString();
                    Arreglo[i].Height = 50;
                    Arreglo[i].Width = 50;
                    Arreglo[i].BackColor = Color.GreenYellow;
                    Arreglo[i].Location = new Point(x0, y0) + new Size(-20, 0);

                    //Dibujar el Árbol y crear los niveles

                    if ((i + 1) == Math.Pow(2, n + 1)) // Saber el nivel de acuerdo a los nodos del arbol
                    {
                        n++;
                        tam = tam / 2;
                        x0 = tam;
                        y0 += 60; //Se incrementa para que el nivel siguiente se dibuje 60 unidades más abajo.
                    }
                    else
                    {
                        x0 += (2 * tam); //Se desplaza x dos veces el tamaño.
                    }
                    i++;
                    estado = true;
                    ec = false;
                    page1.Refresh();
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }

            catch (Exception A)
            {
                MessageBox.Show("Error.\n" + A, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            // Resetear los valores

            n = 0;
            i = 1;
            tam = page1.Width / 2;
            x0 = tam;
            y0 = 20;
            page1.Controls.Clear();
            page1.Refresh();
            Array.Resize<int>(ref Arreglo_Numeros, i + 1);
            Array.Resize<Button>(ref Arreglo, i + 1);
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            if(i==1)
            {
                MessageBox.Show("No hay elementos que ordenar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                btnadd.Enabled = false;
                btnclean.Enabled = false;
                btnsort.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if(!ec)
                {
                    Heap_Num();
                }
                else
                {
                    HPN();
                }
                btnadd.Enabled = true;
                btnclean.Enabled = true;
                btnsort.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }
        public void intercambio(ref Button[] botones, int a, int b)
        {
            string temp = botones[a].Text;
            Point pa = botones[a].Location;
            Point pb = botones[b].Location;

            int diferenciaX = Math.Abs(pa.X - pb.X);
            int diferenciaY = Math.Abs(pa.Y - pb.Y);

            int x = 10;
            int y = 10;
            int t = 70;

            while(y!=diferenciaY+10)
            {
                Thread.Sleep(t);
                botones[a].Location += new Size(0, -10);
                botones[b].Location += new Size(0, -10);
                y += 10;
            }

            while(x!=diferenciaX-diferenciaX%10 +10)
            {
                if(pa.X<pb.X)
                {
                    Thread.Sleep(t);
                    botones[a].Location += new Size(+10, 0);
                    botones[b].Location += new Size(-10, 0);
                    x += 10;
                }
                else
                {
                    Thread.Sleep(t);
                    botones[a].Location += new Size(-10, 0);
                    botones[a].Location += new Size(+10, 0);
                    x += 10;
                }

            }

            botones[a].Text = botones[b].Text;
            botones[b].Text = temp;
            botones[b].Location = pb;
            botones[a].Location = pa;
            estado = true;
            page1.Refresh();
            
        }
        public void Max_Num(int[]a,int x, int indice, ref Button[] botones)
        {
            int izquierdo = indice * 2;
            int derecho = (indice * 2) + 1;
            int mayor = 0;

            if(izquierdo<x&&a[izquierdo]>a[indice])
            {
                mayor = izquierdo;
            }else
            {
                mayor = indice;
            }

            if(derecho<x&&a[derecho]>a[mayor])
            {
                mayor = derecho;
            }
            if(mayor!=indice)
            {
                int temporal = a[indice]; //Conserva el valor del indice de manera temporal
                a[indice] = a[mayor];
                a[mayor] = temporal;
                intercambio(ref Arreglo, mayor, indice);
                Max_Num(a, x, mayor, ref botones);
            }

        }
        public void Min_Num(int[] a, int x, int indice, ref Button[] botones)
        {
            try
            {
                int izquierdo = indice * 2;
                int derecho = (indice * 2) + 1;
                int mayor = 0;

                if (izquierdo > x && a[izquierdo] < a[indice])
                {
                    mayor = izquierdo;
                }
                else
                {
                    mayor = indice;
                }

                if (derecho > x && a[derecho] < a[mayor])
                {
                    mayor = derecho;
                }
                if (mayor != indice)
                {
                    int temporal = a[indice]; //Conserva el valor del indice de manera temporal
                    a[indice] = a[mayor];
                    a[mayor] = temporal;
                    intercambio(ref Arreglo, mayor, indice);
                    Min_Num(a, x, mayor, ref botones);
                }

            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public void Heap_Num()
        {
            ec = true;
            int x = Arreglo.Length;
            for(int i=(x)/2;i>0;i--)
            {
                Max_Num(Arreglo_Numeros, x, i, ref Arreglo);
            }
        }

        public void Heap_Num1()
        {
            ec = true;
            int x = Arreglo.Length;
            for (int i = x / 2; i > 0; i--)
            {
                Min_Num(Arreglo_Numeros, x, i, ref Arreglo);
            }
        }

        public void HPN()
        {
            int temp;
            int x = Arreglo_Numeros.Length;

            for(int i=x-1;i>=1;i--)
            {
                intercambio(ref Arreglo, i, 1);
                temp = Arreglo_Numeros[i];
                Arreglo_Numeros[i] = Arreglo_Numeros[1];
                Arreglo_Numeros[1] = temp;
                x--;
            }
        }

        public void Dibujar_Arreglo(ref Button[] botones, ref TabPage tb)
        {
            for(int j=1;j<botones.Length;j++)
            {
                tb.Controls.Add(this.Arreglo[j]);
            }
        }
        public void Dibujar_Ramas(ref Button[] botones, ref TabPage tb, PaintEventArgs e)
        {
            Pen lapiz = new Pen(Color.Gray, 1.5f);
            Graphics g;
            g = e.Graphics;

            for(int j=1;j<Arreglo.Length;j++)
            {
                if(Arreglo[(2*j)]!=null)
                {
                    g.DrawLine(lapiz, Arreglo[j].Location.X, Arreglo[j].Location.Y + 20, Arreglo[(2 * j)].Location.X + 20, Arreglo[(2 * j)].Location.Y);
                }
                if(Arreglo[(2*j)+1]!=null)
                {
                    g.DrawLine(lapiz, Arreglo[j].Location.X + 40, Arreglo[j].Location.Y + 20, Arreglo[(2 * j)+1].Location.X + 20, Arreglo[(2 * j) + 1].Location.Y);
                }
            }
        }
        private void page1_Paint(object sender, PaintEventArgs e)
        {
            if(estado)
            {
                try
                {
                    Dibujar_Arreglo(ref Arreglo, ref page1);
                    Dibujar_Ramas(ref Arreglo, ref page1, e);
                }
                catch (Exception)
                {

                    
                }
                estado = false;
            }
        }
        
        private void btnsort2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                MessageBox.Show("No hay elementos que ordenar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnadd.Enabled = false;
                btnclean.Enabled = false;
                btnsort.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (!ec)
                {
                    Heap_Num1();
                }
                else
                {
                    HPN();
                }
                btnadd.Enabled = true;
                btnclean.Enabled = true;
                btnsort.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

    }
}
