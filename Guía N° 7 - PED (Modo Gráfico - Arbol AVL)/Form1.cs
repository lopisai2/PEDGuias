using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N__7___PED
{
    public partial class Original : Form
    {
        public Original()
        {
            InitializeComponent();
        }
        int cont = 0;
        int dato = 0;
        int datob = 0;
        int cont2 = 0;

        DibujarAVL arbolAVL = new DibujarAVL(null);
        DibujarAVL arbolAVL_Letra=new DibujarAVL(null);        
        Graphics g;
        int pintaR = 0;            
        private void Original_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            arbolAVL.DibujarArbol(g, this.Font, Brushes.Red, Brushes.White, Pens.White, datob, Brushes.White);
           
            if(pintaR==1)
            {
                arbolAVL.Colorear(g, this.Font, Brushes.Orange, Brushes.Black, Pens.Blue, arbolAVL.Raiz,false,false,true);
                pintaR = 0;
            
            }

            if(pintaR==2)
            {
                arbolAVL.ColorearB(g, this.Font, Brushes.White, Brushes.Black, Pens.White, arbolAVL.Raiz, int.Parse(txt1.Text));
                pintaR = 0;
            }
            if (pintaR == 3)
            {
                arbolAVL.Colorear(g, this.Font, Brushes.Yellow, Brushes.Black, Pens.Blue, arbolAVL.Raiz, false, true, false);
                pintaR = 0;

            }
            if (pintaR == 4)
            {
                arbolAVL.Colorear(g, this.Font, Brushes.Cyan, Brushes.Black, Pens.Blue, arbolAVL.Raiz, true, false,false);
                pintaR = 0;

            }
        }        
        private void rbtnpre_CheckedChanged(object sender, EventArgs e)
        {
            txt2.Clear();
            if(rbtnpre.Checked==true)
            {
                pintaR = 1;
                arbolAVL.PreOrden(arbolAVL.Raiz, txt2);
                rbtnin.Checked = false;
                rbtnpost.Checked = false;
                Refresh();
            }
        }

        private void rbtnin_CheckedChanged(object sender, EventArgs e)
        {
            txt2.Clear();
            if (rbtnin.Checked == true)
            {
                pintaR = 3;
                arbolAVL.EnOrden(arbolAVL.Raiz, txt2);
                rbtnpre.Checked = false;
                rbtnpost.Checked = false;
                Refresh();
            }
        }

        private void rbtnpost_CheckedChanged(object sender, EventArgs e)
        {
            txt2.Clear();
            if (rbtnpost.Checked == true)
            {
                pintaR = 4;
                arbolAVL.PostOrden(arbolAVL.Raiz, txt2);
                rbtnin.Checked = false;
                rbtnpre.Checked = false;
                Refresh();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            errorcito.Clear();
            if(String.IsNullOrEmpty(txt1.Text))
            {
                errorcito.SetError(txt1, "Valor necesario");
            }else
            {
                try
                {
                    dato = int.Parse(txt1.Text);
                    arbolAVL.Insertar(dato,lblalturanodo);
                    txt1.Clear();
                    txt1.Focus();                    
                    lblaltura.Text = arbolAVL.Raiz.getearAltura(arbolAVL.Raiz).ToString();
                    cont++;
                    Refresh();
                    Refresh();                  
                  
                }
                catch (Exception ex)
                {

                    errorcito.SetError(txt1, "Debe Ser numerico. " + ex.Message);
                }
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            errorcito.Clear();
            if(string.IsNullOrEmpty(txt1.Text))
            {
                errorcito.SetError(txt1,"Valor obligatoro");
            }
            else
            {
                try
                {
                    datob = int.Parse(txt1.Text);
                    arbolAVL.buscar(datob);
                    pintaR = 2;
                    Refresh();
                    txt1.Clear();
                }
                catch (Exception ex)
                {

                    errorcito.SetError(txt1, "Debe Ser numerico. " + ex.Message);
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            errorcito.Clear();
            if (string.IsNullOrEmpty(txt1.Text))
            {
                errorcito.SetError(txt1, "Valor obligatoro");
            }else
            {
                try
                {
                    dato = int.Parse(txt1.Text);
                    txt1.Clear();
                    arbolAVL.Eliminar(dato);
                    lblaltura.Text = arbolAVL.Raiz.getearAltura(arbolAVL.Raiz).ToString();
                    Refresh();
                    Refresh();
                    cont2++;
                    rbtnin.Checked = false;
                    rbtnpre.Checked = false;
                    rbtnpost.Checked = false;
                }
                catch (Exception ex)
                {

                    errorcito.SetError(txt1, "Debe Ser numerico. " + ex.Message);
                }
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblaltura.Visible = true;
            lblalturanodo.Visible = true;
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                errorcito.Clear();
                if (String.IsNullOrEmpty(txt1.Text))
                {
                    errorcito.SetError(txt1, "Valor necesario");
                }
                else
                {
                    try
                    {
                        lblalturanodo.Text = "";
                        dato = int.Parse(txt1.Text);
                        arbolAVL.Insertar(dato,lblalturanodo);
                        txt1.Clear();
                        txt1.Focus();
                        lblaltura.Text = arbolAVL.Raiz.getearAltura(arbolAVL.Raiz).ToString();
                        cont++;
                        Refresh();
                        Refresh();
                    }
                    catch (Exception ex)
                    {

                        errorcito.SetError(txt1, "Debe Ser numerico. " + ex.Message);
                    }
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Original_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblalturanodo_Click(object sender, EventArgs e)
        {

        }
    }
}
