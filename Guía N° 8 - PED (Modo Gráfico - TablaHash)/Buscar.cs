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
    public partial class Buscar : TestBase
    {
       public Hashtable h = new Hashtable();
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            foreach(string s in h.Keys)
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void btnstandar_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "Descripcion: ";
                if (h.ContainsKey(comboBox1.SelectedItem))
                {
                    label2.Visible = true;
                    label2.Text += h[comboBox1.SelectedItem];
                    MessageBox.Show("Clave encontrada.\nClave: " + comboBox1.SelectedItem + "\nDescripción: " + h[comboBox1.SelectedItem],"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.test = h;
            f.Show();
            this.Hide();
        }
    }
}
