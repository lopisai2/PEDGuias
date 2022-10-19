using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Guía_N_8___PED
{
    
    public partial class Form1 : Form
    {        
        
        public Hashtable test = null;
        public Form1()
        { 
            InitializeComponent();
            
        }       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Añadir c = new Añadir();
            if (test == null)
            {
                c.Show();
                this.Hide();
            }else
            {
                c.a = test;
                c.Show();
                this.Hide();
            }
        }
      
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (test == null)
            {
                MessageBox.Show("No hay datos en la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Buscar b = new Buscar();
                b.h = test;
                b.Show();
                this.Hide();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Mostrar m = new Mostrar();
            
            if(test==null)
            {
                MessageBox.Show("No hay datos en la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    m.b = test;
                    m.Show();
                    this.Hide();
            }
               
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(test==null)
            {
                MessageBox.Show("No hay datos en la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Eliminar E = new Eliminar();
                E.h = test;
                E.Show();
                this.Hide();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Salir del Menú?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
