using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N__2___PED
{
    public partial class Form1 : Form
    {
        Graphics area;

        int x, y, z; //Variables que representa la ubicacíon del mouse en el panel
        public Form1()
        {
            InitializeComponent();
            
            
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            switch (cboxcolors2.SelectedIndex)
            {
                case 0:
                    {
                        sb = new SolidBrush(Color.Yellow);
                        break;
                    }
                case 1:
                    {
                        sb = new SolidBrush(Color.Red);
                        break;
                    }
                case 2:
                    {
                        sb = new SolidBrush(Color.Blue);
                        break;
                    }
                case 3:
                    {
                        sb = new SolidBrush(Color.Black);
                        break;
                    }
            }
            if (list1.SelectedIndex==0)
            {
                
                g.DrawEllipse(lapiz, x, y, x-y,y-x);
                g.FillEllipse(sb, x, y, x-y,y-x);
            }
            if(list1.SelectedIndex==1)
            {                
                g.DrawRectangle(lapiz, x - 50, y - 50, x, y);
                g.FillRectangle(sb, x - 50, y - 50, x, y);
            }
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list1.Items.Add("Circulo");
            list1.Items.Add("Rectángulo");
            cboxcolors.Items.Add("Amarillo");
            cboxcolors.Items.Add("Rojo");
            cboxcolors.Items.Add("Azul");
            cboxcolors.Items.Add("Negro");
            cboxcolors2.Items.Add("Amarillo");
            cboxcolors2.Items.Add("Rojo");
            cboxcolors2.Items.Add("Azul");
            cboxcolors2.Items.Add("Negro");
            area = areadibujo.CreateGraphics();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btneraser_Click(object sender, EventArgs e)
        {
            area.Clear(Color.White);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        //Util
        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void tiempo1_Tick(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {

        }

        private void areadibujo_Click(object sender, EventArgs e)
        {

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            try
            {
                Pen lapicero = new Pen(Color.Black);
                switch (cboxcolors.SelectedIndex)
                {
                    case 0:
                        {
                            lapicero = new Pen(Color.Yellow);
                            break;
                        }
                    case 1:
                        {
                            lapicero = new Pen(Color.Red);
                            break;
                        }
                    case 2:
                        {
                            lapicero = new Pen(Color.Blue);
                            break;
                        }
                    case 3:
                        {
                            lapicero = new Pen(Color.Black);
                            break;
                        }
                }
                int interacciones = Convert.ToInt32(txtcant.Text);
                int espacios = Convert.ToInt32(txtspace.Text);



                int x1, y1, x2, y2;
                x1 = Convert.ToInt32(x01.Text);
                y1 = Convert.ToInt32(y01.Text);
                x2 = Convert.ToInt32(x02.Text);
                y2 = Convert.ToInt32(y02.Text);

                for (int i = 0; i < interacciones; i++)
                {
                    area.DrawLine(lapicero, x1, y1 + (espacios * i), x2, y2 + (espacios * i));
                }
            }
            catch (Exception A)
            {

                MessageBox.Show("Coordenadas Incorrectas. " + A.Message, "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
            z++;
            
        }
    }
}
