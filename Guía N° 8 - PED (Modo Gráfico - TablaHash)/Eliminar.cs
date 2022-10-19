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
    public partial class Eliminar : Form
    {
        public Hashtable h = new Hashtable();
        public Eliminar()
        {
            InitializeComponent();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (h.ContainsKey(comboBox1.SelectedItem))
                {
                    h.Remove(comboBox1.SelectedItem);
                    MessageBox.Show("Clave Eliminada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Items.Clear();
                    foreach (string s in h.Keys)
                    {
                        comboBox1.Items.Add(s);
                    }
                    if(h.Count==0)
                    {
                        comboBox1.Text="";
                    }else
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Clave no encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if(h.Count==0)
            {
                h = null;
                Form1 f = new Form1();
                f.test = h;
                f.Show();
                this.Hide();
            }
            else
            {
                Form1 f = new Form1();
                f.test = h;
                f.Show();
                this.Hide();
            }
            
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            foreach (string s in h.Keys)
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
