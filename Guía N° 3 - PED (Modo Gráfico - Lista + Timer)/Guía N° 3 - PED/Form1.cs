using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N__3___PED
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> iconos = new List<string>()
        {
            "!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z"
        };
        Label primerclick = null;
        Label segundoclick = null;

        private void Asignar()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconlabel = control as Label;
                if(iconlabel!=null)
                {
                    int numerorandom = random.Next(iconos.Count);
                    iconlabel.Text = iconos[numerorandom];
                    iconos.RemoveAt(numerorandom);
                }
                iconlabel.ForeColor = iconlabel.BackColor;

            }
        }
        public Form1()
        {
            InitializeComponent();
            Asignar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timer1.Stop();
            primerclick.ForeColor = primerclick.BackColor;
            segundoclick.ForeColor = segundoclick.BackColor;
            primerclick = null;
            segundoclick = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled==true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if(clickedlabel.ForeColor==Color.Black)
                return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
               
                timer1.Start();
            }
            
        }
        private void VerificaGana()
        {       
            int res = 0;
            foreach (Control control in tableLayoutPanel1.Controls)                
            {                
                Label a = control as Label;
                if(a.ForeColor==Color.Black)
                {
                    res++;
                }
                
            }
            if (res == 16)
            {
                MessageBox.Show("Felicidades, has terminado el juego.", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }

                timer1.Start();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                

                timer1.Start();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
               
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
             
                timer1.Start();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
               
                timer1.Start();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                
                timer1.Start();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
              
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
               
                timer1.Start();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                VerificaGana();
                timer1.Start();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
               
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                
                timer1.Start();
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
               
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
               
                timer1.Start();
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
               
                timer1.Start();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
             return; 
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
               
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
               
                timer1.Start();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                ;
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                
                timer1.Start();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                
                timer1.Start();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
               
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor =Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                
                timer1.Start();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            { return; }
            Label clickedlabel = sender as Label; //Verifica que se ha clikeado
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
               
                if (primerclick == null)
                {
                    primerclick = clickedlabel;
                    primerclick.ForeColor = Color.Black;
                    return;
                }
                else
                segundoclick = clickedlabel;
                segundoclick.ForeColor = Color.Black;
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;
                    VerificaGana();
                    return;
                }
                
                timer1.Start();
            }
        }
    }
}
