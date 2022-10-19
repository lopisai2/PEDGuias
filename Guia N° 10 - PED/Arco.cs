using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_N__10___PED
{
    public partial class Arco : Form
    {
        public bool control;
        public string dato;

        public Arco()
        {
            InitializeComponent();
            control = false;
            dato = "";
            txtarco.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtarco.Text))
            {
                MessageBox.Show("Debes ingresar un valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                control = true;
                Hide();
            }
        }

        private void Arco_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Arco_Load(object sender, EventArgs e)
        {
            txtarco.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            control = false;
            Hide();
        }

        private void Arco_Shown(object sender, EventArgs e)
        {
            txtarco.Clear();
            txtarco.Focus();
        }

        private void txtarco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnaceptar_Click(null, null);
            }
        }
    }
}
