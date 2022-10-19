using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Guía_N__7___Complementaria___PED
{
    public partial class App : Form
    {
        DibujarAVL miarbol = new DibujarAVL();
        Graphics g;
        int b, z;

        public App()
        {
            InitializeComponent(); 
            
            
        }
        private void App_Load(object sender, EventArgs e)
        {
                    
            
        }
        private static bool ValidarLetras(string test)
        {
            string expresion1 = "^([A-Z]{1})";
            string expresion2 = "^(^[a-z]{1})";
            if(Regex.IsMatch(test,expresion1)||Regex.IsMatch(test,expresion2))
            {
                if (Regex.Replace(test, expresion1, string.Empty).Length == 0 || Regex.Replace(test, expresion2, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }else
            {
                return false;
            }
        }
       private static bool ValidarNumeros(string test)
        {
            string expresion = "^([0-9]{1,99}$)";
            if(Regex.IsMatch(test,expresion))
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void txtdato_TextChanged(object sender, EventArgs e)
        {
            if (z == 0)
            {
                if (ValidarLetras(txtdato.Text))
                {

                }
                else
                {
                    txtdato.Clear();
                    txtdato.Focus();
                }

            }
            else if(z==1)
            {
                if(ValidarNumeros(txtdato.Text))
                {

                }else
                {
                    txtdato.Clear();
                    txtdato.Focus();
                }

            }
        }

        private void rbtnletras_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnletras.Checked==true)
            {
                z = 0;
                rbtnnumeros.Checked = false;
                rbtnnumeros.Enabled = false;
                txtdato.Enabled = true;
                txtdato.Focus();
            }
        }

        private void rbtnnumeros_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnnumeros.Checked==true)
            {
                z = 1;
                rbtnletras.Checked = false;
                rbtnletras.Enabled = false;
                txtdato.Enabled = true;
                txtdato.Focus();
            }
        }
        private void Arbolvacio()
        {
            rbtnletras.Enabled = true;
            rbtnnumeros.Enabled = true;
            rbtnnumeros.Checked = false;
            rbtnletras.Checked = false;
            miarbol.Raiz = null;
            txtdato.Enabled = false;
            lblmaxaltura.Text = "0";
            MessageBox.Show("La raíz fue eliminada. El árbol está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (z == 0)
                {
                    miarbol.Insertar(Encoding.ASCII.GetBytes(txtdato.Text)[0], lblrotacion);
                    lblmaxaltura.Text = miarbol.Raiz.getearAltura(miarbol.Raiz).ToString();
                }
                if (z == 1)
                {
                    miarbol.Insertar(Convert.ToInt32(txtdato.Text), lblrotacion);
                    lblmaxaltura.Text = miarbol.Raiz.getearAltura(miarbol.Raiz).ToString();
                }
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtdato.Clear();
                txtdato.Focus();
                this.Cursor = Cursors.WaitCursor;
                Refresh();
                this.Cursor = Cursors.Default;
            }


        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (z == 0)
                {
                    miarbol.buscar(Encoding.ASCII.GetBytes(txtdato.Text)[0]);
                }
                else
                {
                    miarbol.buscar(Convert.ToInt32(txtdato.Text));
                }
                b = 4;                
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }finally
            {
                txtdato.Focus();
                txtdato.SelectAll();
                this.Cursor = Cursors.WaitCursor;
                Refresh();
                this.Cursor = Cursors.Default;
            }
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (z == 0)
                {
                    miarbol.buscar(Encoding.ASCII.GetBytes(txtdato.Text)[0]);
                    if (miarbol.Raiz == null)
                    {

                    }
                    else if (miarbol.Raiz.z == 1)
                    {
                        if (miarbol.Raiz.getearAltura(miarbol.Raiz) == 1)
                        {
                            Arbolvacio();
                        }
                        else if (miarbol.Raiz.getearAltura(miarbol.Raiz) > 1)
                        {
                            miarbol.Eliminar(Encoding.ASCII.GetBytes(txtdato.Text)[0]);
                            lblmaxaltura.Text = miarbol.Raiz.getearAltura(miarbol.Raiz).ToString();
                        }
                    }

                }
                if (z == 1)
                {
                    if (miarbol.Raiz == null)
                    {

                    }else
                    if (miarbol.Raiz.z == 1)
                    {
                        if (miarbol.Raiz.getearAltura(miarbol.Raiz) == 1)
                        {
                            Arbolvacio();
                        }
                        else if (miarbol.Raiz.getearAltura(miarbol.Raiz) > 1)
                        {
                            miarbol.Eliminar(Convert.ToInt32(txtdato.Text));
                            lblmaxaltura.Text = miarbol.Raiz.getearAltura(miarbol.Raiz).ToString();
                        }
                    }
                }                
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }finally
            {
                txtdato.Clear();
                txtdato.Focus();
                this.Cursor = Cursors.WaitCursor;
                Refresh();
                this.Cursor = Cursors.Default;
            }
            
        }

        private void txtdato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnnumeros.Checked == false && rbtnletras.Checked == false)
            {
                e.Handled = true;

            }else
            if(e.KeyChar==(char)Keys.Enter)
            {
                btninsertar_Click(sender, e);
            }
        }

        private void rbtnenorden_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnenorden.Checked==true)
            {
                txtrecorrido.Clear();
                miarbol.EnOrden(miarbol.Raiz, txtrecorrido,z);
                rbtnpreorden.Checked = false;
                rbtnpostorden.Checked = false;
                b = 2;
                this.Cursor = Cursors.WaitCursor;
                Refresh();
                this.Cursor = Cursors.Default;
                txtdato.Focus();
            }
        }

        private void rbtnpreorden_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnpreorden.Checked==true)
            {
                txtrecorrido.Clear();
                miarbol.PreOrden(miarbol.Raiz, txtrecorrido,z);
                rbtnenorden.Checked = false;
                rbtnpostorden.Checked = false;
                b = 1;
                this.Cursor = Cursors.WaitCursor;
                Refresh();
                this.Cursor = Cursors.Default;
                txtdato.Focus();
            }
        }

        private void rbtnpostorden_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnpostorden.Checked==true)
            {
                txtrecorrido.Clear();
                miarbol.PostOrden(miarbol.Raiz, txtrecorrido,z);
                rbtnenorden.Checked = false;
                rbtnpreorden.Checked = false;
                b = 3;
                this.Cursor = Cursors.WaitCursor;
                Refresh();
                this.Cursor = Cursors.Default;
                txtdato.Focus();
            }
        }

        private void App_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            if (miarbol.Raiz != null)
            {
                miarbol.DibujarArbol(g, this.Font, Brushes.White, Brushes.Black, Pens.White, string.Concat((char)miarbol.Raiz.Valor), Brushes.Red, z);                
                if (b == 1)
                {
                    miarbol.Colorear(g, this.Font, Brushes.Cyan, Brushes.White, Pens.White, miarbol.Raiz, false, false, true, z);
                    b = 0;
                }
                if (b == 2)
                {
                    miarbol.Colorear(g, this.Font, Brushes.Brown, Brushes.White, Pens.White, miarbol.Raiz, false, true, false, z);
                    b = 0;
                }
                if (b == 3)
                {
                    miarbol.Colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.White, miarbol.Raiz, true, false, false, z);
                    b = 0;
                }
                if(b==4)
                {
                    if(z==0)
                    {
                        miarbol.ColorearB(g, this.Font, Brushes.Yellow, Brushes.Black, Pens.White, miarbol.Raiz, Encoding.ASCII.GetBytes(txtdato.Text)[0], z);
                        
                    }
                    if(z==1)
                    {
                        miarbol.ColorearB(g, this.Font, Brushes.Yellow, Brushes.Black, Pens.White, miarbol.Raiz, Convert.ToInt32(txtdato.Text), z);
                    }                    
                    b = 0;
                }
            }
        }
    }
}
