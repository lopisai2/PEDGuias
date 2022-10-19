using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Guía_N__5_Complementaria___PED
{
    
    public partial class App : Form
    {
        
        Stack<Almacen1> pila1 = new Stack<Almacen1>();
        Stack<Almacen1> pila2 = new Stack<Almacen1>();
        public App()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Almacen1 info = new Almacen1();
                info.Dato = Convert.ToDouble(txtvalor.Text);
                pila1.Push(info);
                dgv1.DataSource = null;
                dgv1.DataSource = pila1.ToArray();
                txtvalor.Clear();
                txtvalor.Focus();
                Refresh();
            }
            catch (Exception A)
            {

                MessageBox.Show("El dato no puede añadirse a la pila.\n" + A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void App_Load(object sender, EventArgs e)
        {
            txtvalor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Almacen1 info = new Almacen1();
                info = pila1.Pop();
                Thread.Sleep(300);
                Refresh();
                while (info.Dato != Convert.ToDouble(txtvalor.Text))
                {
                    pila2.Push(info);
                    dgv1.DataSource = null;
                    dgv1.DataSource = pila1.ToList();
                    Thread.Sleep(100);
                    Refresh();
                    dgv2.DataSource = null;
                    dgv2.DataSource = pila2.ToArray();
                    Thread.Sleep(100);
                    Refresh();
                    info = pila1.Pop();
                    Thread.Sleep(300);
                    Refresh();
                }
                dgv1.DataSource = pila1.ToArray();
                Thread.Sleep(100);
                Refresh();
                while (pila2.Count != 0)
                {
                    info = pila2.Pop();
                    pila1.Push(info);
                    dgv1.DataSource = null;
                    dgv1.DataSource = pila1.ToArray();
                    Thread.Sleep(100);
                    Refresh();
                    dgv2.DataSource = null;
                    dgv2.DataSource = pila2.ToList();
                    Thread.Sleep(100);
                    Refresh();
                    Thread.Sleep(300);
                    Refresh();
                }
                txtvalor.Clear();
                txtvalor.Focus();
                MessageBox.Show("El dato fue removido exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception A)
            {
                MessageBox.Show("El dato no puede quitarse.\n" + A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
