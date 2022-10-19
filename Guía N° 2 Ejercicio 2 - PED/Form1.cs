using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N_2_Ejercicio_2___PED
{
    public partial class App : Form
    {
        Graphics area;
        public App()
        {
            InitializeComponent();
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

                MessageBox.Show("Coordenadas Incorrectas. " + A.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btneraser_Click(object sender, EventArgs e)
        {
            area.Clear(Color.White);
        }

        private void App_Load(object sender, EventArgs e)
        {
            cboxcolors.Items.Add("Amarillo");
            cboxcolors.Items.Add("Rojo");
            cboxcolors.Items.Add("Azul");
            cboxcolors.Items.Add("Negro");
            area = areadibujo.CreateGraphics();
        }
    }
}
