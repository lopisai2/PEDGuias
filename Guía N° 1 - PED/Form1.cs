using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N__1___PED
{
    public partial class Calc : Form
    {
        Letras a=new Letras();
        
        public bool Is1, Is2,Es_op;
        public double num01, num02, resultado;
        public double operacion;

        public void limpiar_txt()
        {
            txt1.Clear();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            actualizarvalores("0");
        }

        private void num0_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            actualizarvalores("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            actualizarvalores("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            actualizarvalores("3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actualizarvalores("4");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualizarvalores("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actualizarvalores("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            actualizarvalores("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizarvalores("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizarvalores("9");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            actualizarvalores(".");
        }

        private void sum_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                num01 = Obtenervalor();
                Is1 = true;
                operacion = 0; //Indica suma el "0"

            }
        }

        private void rest_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                num01 = Obtenervalor();
                Is1 = true;
                operacion = 1; //Indica resta
            }

        }

        private void mul_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                num01 = Obtenervalor();
                Is1 = true;
                operacion = 2;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                num01 = Obtenervalor();
                
                Is1 = true;
                operacion = 3;
            }
        }

        private void sen_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                if (string.IsNullOrEmpty(txt1.Text))
                {
                    num01 = 1;
                }
                else
                {
                    num01 = Obtenervalor();
                }
                Is1 = true;
                operacion = 4;
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                if(string.IsNullOrEmpty(txt1.Text))
                {
                    num01 = 1;
                }
                else
                {
                    num01 = Obtenervalor();
                }
                Is1 = true;
                operacion = 5;
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                if (string.IsNullOrEmpty(txt1.Text))
                {
                    num01 = 1;
                }
                else
                {
                    num01 = Obtenervalor();
                }
                Is1 = true;
                operacion = 6;
            }
        }

        private void log10_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                if (string.IsNullOrEmpty(txt1.Text))
                {
                    num01 = 1;
                }
                else
                {
                    num01 = Obtenervalor();
                }
                Is1 = true;
                operacion = 7;
            }
        }

        private void In_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                if (string.IsNullOrEmpty(txt1.Text))
                {
                    num01 = 1;
                }
                else
                {
                    num01 = Obtenervalor();
                }
                Is1 = true;
                operacion = 8;
            }
        }

        private void pot_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                num01 = Obtenervalor();
                Is1 = true;
                operacion = 9;
            }
        }


        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacion == 0)
                {
                    if (Is1)
                    {
                        num02 = Obtenervalor();
                        actualizarvalores(operar(num01, num02, "+").ToString());
                        Is1 = false;

                    }
                }else
                if(operacion==1)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "-").ToString());
                    Is1 = false;
                }else
                if (operacion == 2)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "*").ToString());
                    Is1 = false;
                }else
                if (operacion == 3)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "/").ToString());
                    Is1 = false;
                }else
                if(operacion==4)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "sin").ToString());
                    Is1 = false;
                }
                else
                if(operacion==5)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "cos").ToString());
                    Is1 = false;
                }
                else
                if (operacion == 6)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "tan").ToString());
                    Is1 = false;
                }
                else
                if (operacion == 7)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "Log").ToString());
                    Is1 = false;
                }
                else
                if (operacion == 8)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "Ln").ToString());
                    Is1 = false;
                }
                else
                if (operacion == 9)
                {
                    num02 = Obtenervalor();
                    actualizarvalores(operar(num01, num02, "pot").ToString());
                    Is1 = false;
                }
                else
                {
                    MessageBox.Show("Seleccione una operación para realizar.");
                }
               // MessageBox.Show("La respuesta de la calculadores es de: "+a.conversionenletras(txt1.Text), "Respuesta", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            catch (Exception a)
            {

                MessageBox.Show("Esta operación requere dos o más operandos. "+a.Message);
            }
        }
        public double operar(double operador1, double operador2, string signo)
        {
            try
            {
                double Resultado = 0.0;
                double temp1;
                switch (signo)
                {
                    case "+":
                        {
                            Resultado = operador1 + operador2;
                            break;
                        }
                    case "-":
                        {
                            Resultado = operador1 - operador2;
                            break;
                        }
                    case "*":
                        {
                            Resultado = operador1 * operador2;
                            break;
                        }
                    case "/":
                        {
                            Resultado = operador1 / operador2;
                            break;
                        }
                    case "sin":
                        {
                            temp1 = operador2 * (Math.PI / 180);
                            Resultado = Math.Round(operador1 * (Math.Sin(temp1)), 2);
                            break;
                        }
                    case "cos":
                        {
                            temp1 = operador2 * (Math.PI / 180);
                            Resultado = Math.Round(operador1 * (Math.Cos(temp1)), 2);
                            break;
                        }
                    case "tan":
                        {
                            temp1 = operador2 * (Math.PI / 180);
                            Resultado = Math.Round(operador1 * (Math.Tan(temp1)), 2);
                            break;

                        }
                    case "Log":
                        {
                            Resultado = Math.Round(operador1 * Math.Log10(operador2), 2);
                            break;
                        }
                    case "Ln":
                        {
                            Resultado = Math.Round(operador1 * Math.Log(operador2), 2);
                            break;
                        }
                    case "pot":
                        {
                            Resultado = Math.Pow(operador1, operador2);
                            break;
                        }
                }
                return Resultado;
            }
            catch (Exception A)
            {

                throw new Exception(A.Message);
            }
            
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            limpiar_txt();
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            
        }

        public double Obtenervalor()
        {
            try
            {
                double valor = Convert.ToDouble(txt1.Text);
                limpiar_txt();
                return valor;
            }
            catch (Exception)
            {                
                return 0;
            }
            
        }
        public void actualizarvalores(String text)
        {
            txt1.Text = txt1.Text + text;
        }

        public Calc()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
    }
}
