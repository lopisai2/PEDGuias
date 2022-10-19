using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N_3._2___PED
{
    public partial class Form1 : Form
    {
        List<Lista> milista = new List<Lista>();
        Lista lalista = new Lista();

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.DataSource = milista;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            lalista.Insertaralinicio(Convert.ToInt32(txt1.Text));
            milista.Add(lalista);
            listBox1.DataSource = null;
            listBox1.DataSource = milista.ToArray();            
            Refresh();
            txt1.Clear();
            txt1.Focus();
        }
    }
}
