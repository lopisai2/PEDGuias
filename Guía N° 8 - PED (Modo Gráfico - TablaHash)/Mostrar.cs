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
    public partial class Mostrar : TestBase
    {        
        public Hashtable b = new Hashtable();
        public Mostrar()
        {
            InitializeComponent();
            
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            foreach (string s in b.Keys)
                    {
                        label1.Text += "\n" + s + "\n";
                    }
                    foreach (string s in b.Values)
                    {
                        label2.Text += "\n" + s + "\n";
                    }                
          
        }
     

        private void btnstandar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.test = b;
            f.Show();
            this.Hide();
        }
    }
}
