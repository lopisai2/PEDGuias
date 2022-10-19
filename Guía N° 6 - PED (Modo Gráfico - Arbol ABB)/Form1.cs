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

namespace Guía_5___PED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Dato = 0;
        int cont = 0;
        Arbol_Binario miArbol = new Arbol_Binario(null);
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            miArbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
            if (cont==1)
            {
                miArbol.Colorear(g, this.Font, Brushes.Red, Brushes.White, Pens.Black, miArbol.Raiz, false,false, true);
                cont = 0;
            }
            if (cont==2)
            {
                miArbol.Colorear(g, this.Font, Brushes.Yellow, Brushes.Black, Pens.Black, miArbol.Raiz, false,true, false);
                cont = 0;
            }
            if (cont ==3)
            {
                miArbol.Colorear(g, this.Font, Brushes.Brown, Brushes.White, Pens.Black, miArbol.Raiz, true, false, false);
                cont = 0;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt1.Text))
            {
                MessageBox.Show("Debe ingresar un valor.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dato = int.Parse(txt1.Text);
                if(Dato<=0||Dato>=100)
                {
                    MessageBox.Show("Solo se reciben valores de 1 a 99.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    miArbol.Insertar(Dato);
                    lblcantidadnodo.Text = miArbol.Raiz.sumanodos.ToString();
                    lblcantidadtotal.Text = miArbol.Raiz.suma.ToString();
                    lblmaxaltura.Text = miArbol.Raiz.getearalturaxd(miArbol.Raiz).ToString();
                    txt1.Clear();
                    txt1.Focus();                    
                    Refresh();                    
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("Debe ingresar un valor a eliminar.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dato = Convert.ToInt32(txt2.Text);
                if(Dato<=0||Dato>=100)
                {
                    MessageBox.Show("Solo se reciben valores de 1 a 99.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    miArbol.Eliminar(Dato);
                    lblcantidadnodo.Text = miArbol.Raiz.sumanodos.ToString();
                    lblcantidadtotal.Text = miArbol.Raiz.suma.ToString();
                    lblmaxaltura.Text = miArbol.Raiz.getearalturaxd(miArbol.Raiz).ToString();
                    txt2.Clear();
                    txt2.Focus();                    
                    Refresh();
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt3.Text))
            {
                MessageBox.Show("Debe ingresar un valor a buscar.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dato = Convert.ToInt32(txt3.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Solo se reciben valores de 1 a 99.", "Arbol Binario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    miArbol.Buscar(Dato);
                    txt3.Clear();
                    txt3.Focus();                    
                    Refresh();
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            cont = 1;
            miArbol.Preorden(miArbol.Raiz,textBox1);
          
            Refresh();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            cont = 2;
            miArbol.Enorden(miArbol.Raiz, textBox1);
        
            Refresh();            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            cont = 3;
            miArbol.PostOrden(miArbol.Raiz, textBox1);
          
            Refresh();            
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                btn1_Click(sender, e);
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn2_Click(sender, e);
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               btn3_Click(sender, e);
            }
        }
    }
}
