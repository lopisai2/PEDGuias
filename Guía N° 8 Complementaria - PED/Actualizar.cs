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
namespace Guía_N__8_Complementaria___PED
{
    public partial class Actualizar : BaseOpciones
    {
        public bool controlventana;
        public string dato;
        public string dato1;

        public Actualizar()
        {
            InitializeComponent();
            controlventana = false;
            dato = null;
            dato1 = null;
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                dato = txtkey.Text;
                dato1 = txtinfo.Text;
                controlventana = true;
                Hide();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                txtkey.Clear();
                txtinfo.Clear();
                txtkey.Focus();
                Refresh();
            }
        }

        private void txtkey_Leave(object sender, EventArgs e)
        {
            App app = new App();
            if(app.validameesta(txtkey))
            {
                errorcito.Clear();
            }
            else
            {
                errorcito.SetError(txtkey, "Formato de DUI incorrecto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlventana = false;
            Hide();
        }
    }
}
