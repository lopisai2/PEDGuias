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
    public partial class Añadir :TestBase
    {        
        public Hashtable a = new Hashtable();
        public Añadir()
        {
            InitializeComponent();
        }

        private void btnstandar_Click(object sender, EventArgs e)
        {
            try
            {
                
                a.Add(txtkey.Text, txtvalue.Text);
                txtkey.Focus();
                txtkey.Clear();
                txtvalue.Clear();

                Refresh();
                MessageBox.Show("Datos agregados a la Tabla Hash", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();            
            if(a.Count==0)
            {
                f.Show();
                this.Hide();
            }else
            {
                f.test = a;
                f.Show();
                this.Hide();
            }

        }
    }
}
