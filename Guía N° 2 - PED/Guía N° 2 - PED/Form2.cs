using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N__2___PED
{
    public partial class Form2 : Form
    {
        private int x31, y31;
        private Posicion objposicion;
        public Form2()
        {
            InitializeComponent();
            x31 = 50;
            y31 = 50;
            objposicion = Posicion.abajo;
        }
        enum Posicion
        {
            izquierda, derecha, abajo, arriba
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right)
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objposicion = Posicion.abajo;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha)
            {
                x31 += 10;
            }
            else if (objposicion == Posicion.izquierda)
            {
                x31 -= 10;
            }
            else if (objposicion == Posicion.arriba)
            {
                y31 -= 10;
            }
            else if (objposicion == Posicion.abajo)
            {
                y31 += 10;
            }
            Invalidate();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("image01.jpg"), x31, y31, 65, 65);
        }
    }
}
