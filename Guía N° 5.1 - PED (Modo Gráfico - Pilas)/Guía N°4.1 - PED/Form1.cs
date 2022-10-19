using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Usando Pilas en lugar de Colas
namespace Guía_N_4._1___PED
{
    public partial class Form1 : Form
    {
        
        Stack<Cajero1> Pila1 = new Stack<Cajero1>();
        Stack<Cajero1> Pila2 = new Stack<Cajero1>();
        Stack<Cajero1> Pila3 = new Stack<Cajero1>();
        Stack<Cajero1> Pila4 = new Stack<Cajero1>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Primer Cajero");
            comboBox1.Items.Add("Segundo Cajero");
            comboBox1.Items.Add("Tercer Cajero");
            comboBox1.Items.Add("Cuarto Cajero");
        }
        private void Caja1()
            {
            Cajero1 cajero1 = new Cajero1();
            cajero1.Persona = txtname.Text;
            Pila1.Push(cajero1);
            cola01.DataSource = null;
            cola01.DataSource = Pila1.ToArray();
        }
        private void Caja2()
        {
            Cajero1 cajero1 = new Cajero1();
            cajero1.Persona = txtname.Text;
            Pila2.Push(cajero1);
            cola02.DataSource = null;
            cola02.DataSource = Pila2.ToArray();
        }
        private void Caja3()
        {
            Cajero1 cajero1 = new Cajero1();
            cajero1.Persona = txtname.Text;
            Pila3.Push(cajero1);
            cola03.DataSource = null;
            cola03.DataSource = Pila3.ToArray();
        }
        private void Caja4()
        {
            Cajero1 cajero1 = new Cajero1();
            cajero1.Persona = txtname.Text;
            Pila4.Push(cajero1);
            cola04.DataSource = null;
            cola04.DataSource = Pila4.ToArray();
        }
        private void Limpiar()
        {
            txtname.Clear();
            txtname.Focus();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Cajero1 cajero1 = new Cajero1();
            if (Pila1.Count == 0)
            {
                Caja1();
                Limpiar();
            }//1.Las cajas 1,2,3,4 tienen la misma cantidad de clientes
            else if (Pila1.Count == Pila2.Count && Pila1.Count == Pila3.Count && Pila1.Count == Pila4.Count && Pila2.Count == Pila3.Count && Pila2.Count == Pila4.Count && Pila3.Count == Pila4.Count)
            {
                Caja1();
                Limpiar();
            }
            else if ((Pila1.Count > Pila2.Count && Pila1.Count > Pila3.Count && Pila1.Count > Pila4.Count) && (Pila2.Count == Pila3.Count)&&Pila3.Count>Pila4.Count)
            {
                Caja4();
                Limpiar();
            }
            //2.La cola 1 tiene más que la caja 2. La cola 1 tiene más que la caja 3. La caja 1 tiene más que la caja 4. Además, y la cola 2 tiene lo mismo que la cola 3
            else if ((Pila1.Count > Pila2.Count && Pila1.Count > Pila3.Count && Pila1.Count > Pila4.Count) && (Pila2.Count == Pila3.Count))
            {
                Caja2();
                Limpiar();
            }
            else if ((Pila1.Count == Pila3.Count && Pila2.Count > Pila4.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count) && Pila1.Count == Pila4.Count)
            {
                Caja1();
                Limpiar();
            }
            else if ((Pila1.Count == Pila3.Count && Pila2.Count > Pila4.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count && Pila4.Count > Pila1.Count))
            {
                Caja1();
                Limpiar();
            }//24.La cola 4 tiene más que la cola 1.
            else if ((Pila1.Count == Pila3.Count && Pila2.Count > Pila4.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count))
            {
                Caja4();
                Limpiar();
            }
            else //3.La cola 2 tiene mas clientes que la cola 3, la cola 1 tiene más que la cola 2. Además. la caja 1 tiene más clientes que la caja 3 y caja 4, la caja 2 tiene más que la caja 4 y la caja 3 tiene más que la caja 4. SI
            if (((Pila2.Count > Pila3.Count) && (Pila1.Count > Pila2.Count) && (Pila1.Count > Pila3.Count && Pila1.Count > Pila4.Count && Pila2.Count > Pila4.Count && Pila3.Count > Pila4.Count)))
            {
                Caja4();
                Limpiar();
            }
            else //4.La caja 3 tiene más clientes que la caja 4, al igual que la caja 2 y caja 1. Además la cola 1 tiene lo mismo que la cola 2 y cola 3. SI
            if ((Pila3.Count > Pila4.Count && Pila2.Count > Pila4.Count && Pila1.Count > Pila4.Count) && (Pila1.Count == Pila2.Count && Pila1.Count == Pila3.Count))
            {
                Caja4();
                Limpiar();
            }//5.La Cola 2 tiene más que la caja 4, La cola 1 tiene lo mismo que la cola 3. Además la caja 1 tiene más que la caja 2 y caja 4; La cola 3 tiene más que la cola 2 y cola 4.  SI
            else if ((Pila2.Count > Pila4.Count && Pila1.Count == Pila3.Count) && (Pila1.Count > Pila2.Count && Pila1.Count > Pila4.Count) && Pila3.Count > Pila2.Count && Pila3.Count > Pila4.Count)
            {
                Caja4();
                Limpiar();
            }//6.La cola 1 tiene lo mismo que la cola 2 y la cola 3 lo mismo que la cola 4. Además, la cola 1 tiene más que la cola 3 y cola 4. SI
            else if (((Pila1.Count == Pila2.Count) && (Pila3.Count == Pila4.Count)) && (Pila1.Count > Pila3.Count && Pila1.Count > Pila4.Count))
            {
                Caja3();
                Limpiar();
            }//7.La cola 1,3 y 4 tienen más que la cola 2. Además la cola 1 tiene lo mismo que la cola 3 y la cola 1 tiene más que la cola 4. SI
            else if ((Pila1.Count > Pila2.Count && Pila3.Count > Pila2.Count && Pila4.Count > Pila2.Count) && (Pila1.Count == Pila3.Count && Pila1.Count > Pila4.Count))
            {
                Caja2();
                Limpiar();
            }//8.La cola 2 tiene los mismo que la cola 3, la cola 1 tiene lo mismo que la caja 4. Además, la Cola 1 tiene más que la cola 2 y 3; La cola 4 tiene más que la cola dos y cola 3. SI
            else if ((Pila2.Count == Pila3.Count && Pila1.Count == Pila4.Count) && (Pila1.Count > Pila2.Count && Pila1.Count > Pila3.Count && Pila4.Count > Pila2.Count && Pila4.Count > Pila3.Count))
            {
                Caja2();
                Limpiar();
            }//9.La cola 1 tiene lo mismo que la cola 2, la cola 2 tiene lo mismo que la cola 4. Además, la cola 3 tiene más que la cola 1,2 y 4. SI
            else if ((Pila1.Count == Pila2.Count && Pila2.Count == Pila4.Count) && (Pila3.Count > Pila1.Count && Pila3.Count > Pila2.Count && Pila3.Count > Pila4.Count))
            {
                Caja1();
                Limpiar();
            }//10.La cola 1 tiene lo mismo que la cola 3 y cola 4. Además la cola 2 tiene más que la cola 1,2 y 4. SI
            else if ((Pila1.Count == Pila3.Count && Pila1.Count == Pila4.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count && Pila2.Count > Pila4.Count))
            {
                Caja1();
                Limpiar();
            }//11. La cola 1 tiene lo mismo que la cola 4 y la cola 2 tiene lo mismo que la cola 3. Además la cola 3 tiene más que la cola 1 y cola 4; La cola 2 tien más que la cola 1 y cola 4. SI
            else if ((Pila1.Count == Pila4.Count && Pila2.Count == Pila3.Count) && (Pila3.Count > Pila1.Count && Pila3.Count > Pila4.Count && Pila2.Count > Pila1.Count && Pila2.Count > Pila4.Count))
            {
                Caja1();
                Limpiar();
            }//12. La cola 1 tiene lo mismo que la cola 3 y la cola 2 tiene más que la cola 4. Además, la cola 2 tiene más que la cola 1 y cola 3; La cola 4 tiene más que la cola 1 y 3. SI
            else if ((Pila1.Count == Pila3.Count && Pila2.Count > Pila4.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count && Pila4.Count > Pila1.Count && Pila4.Count > Pila3.Count))
            {
                Caja1();
                Limpiar();
            }//13. La cola 1 tiene más que a cola 3 y la cola 2 tiene más que la cola 4. Además, la cola 2 tiene más que la cola 1 y la cola 4 más que la cola 1. SI
            else if ((Pila1.Count > Pila3.Count && Pila2.Count > Pila4.Count) && (Pila2.Count > Pila1.Count && Pila4.Count > Pila1.Count))
            {
                Caja3();
                Limpiar();
            }//14. La cola 1 tiene lo mismo que la cola 4 y la cola 2 tiene más que la cola 3. Además, la cola 2 tiene más que la cola 1 y cola 3; La cola 2 y cola 3  tiene más que la cola 4
            else if ((Pila1.Count == Pila4.Count && Pila2.Count > Pila3.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count && Pila3.Count > Pila4.Count && Pila2.Count > Pila4.Count))
            {
                Caja1();
                Limpiar();
            }//15. La cola 1 tiene lo mismo que la cola 2 y la cola 3 tiene más que la cola 4. Además, la cola 1 tiene más que la cola 3 y cola 4; La cola 2 tiene más que la cola 3 y 4. SI
            else if ((Pila1.Count == Pila2.Count && Pila3.Count > Pila4.Count) && (Pila1.Count > Pila3.Count && Pila1.Count > Pila4.Count && Pila2.Count > Pila3.Count && Pila2.Count > Pila4.Count))
            {
                Caja4();
                Limpiar();
            }//16. La cola 3 tiene menos que la cola 2 y a cola 4 tiene menos que la cola 1. Además, la cola 1 tiene más que la cola 2 y cola 3; La cola 2 tiene más que la cola 3 y cola 4. SII
            else if ((Pila3.Count < Pila2.Count && Pila4.Count < Pila1.Count) && (Pila1.Count > Pila2.Count && Pila1.Count > Pila3.Count && Pila2.Count > Pila3.Count && Pila2.Count > Pila4.Count))
            {
                Caja3();
                Limpiar();
            }//17. La cola 1 tiene lo mismo que la cola 2 y la cola 4 tiene más que la cola 3. Además, la cola 1 tiene lo mismo que la cola 2 y la cola 2 lo mismo que la cola 4. EH
            else if ((Pila1.Count == Pila2.Count && Pila4.Count > Pila3.Count) && (Pila1.Count == Pila2.Count && Pila2.Count == Pila4.Count))
            {
                Caja3();
                Limpiar();
            }//18. La cola 1 tiene lo mismo que la cola 3 y la cola 2 tiene más que la cola 4. ERR
            else if ((Pila1.Count == Pila3.Count && Pila2.Count > Pila4.Count) && (Pila2.Count > Pila1.Count && Pila2.Count > Pila3.Count))
            {
                Caja1();
                Limpiar();
            }//19. La cola 2 tiene los mismo que la cola 4 y la cola 2 tiene más que la cola 3. La cola 1 tiene lo mismo que la cola 3.
            else if ((Pila2.Count == Pila4.Count) && (Pila2.Count > Pila3.Count) && (Pila1.Count == Pila3.Count))
            {
                Caja1();
                Limpiar();
            }//20. La cola 2 tiene lo mismo que la cola 4 y la cola 3 tiene lo mismo que la cola 1. Además, la cola 1 tiene más que la cola 2 y cola 4
            else if (((Pila2.Count == Pila4.Count) && (Pila3.Count == Pila1.Count)) && (Pila1.Count > Pila2.Count && Pila1.Count > Pila4.Count))
            {
                Caja2();
                Limpiar();
            }//21. La cola 1 tiene lo mismo que la cola 3 y la cola 2 y cola 4  tienen más que la cola 1.
            else if ((Pila1.Count == Pila3.Count) && (Pila2.Count > Pila1.Count) && (Pila4.Count > Pila1.Count))
            {
                Caja1();
                Limpiar();
            }
            else if ((Pila1.Count > Pila3.Count) && (Pila2.Count == Pila4.Count)&&Pila3.Count>Pila2.Count)
            {
                Caja2();
                Limpiar();
            }//22. La cola 1 tiene más que la cola 3 y la cola 2 tiene lo mismo que la cola 4.
            else if ((Pila1.Count > Pila3.Count) && (Pila2.Count == Pila4.Count))
            {
                Caja3();
                Limpiar();
            }//23. La cola 2 tiene más que la cola 4 y la cola 3 tiene más que la cola 2. Además la cola 1 tiene lo mismo que la cola 3.
            else if ((Pila2.Count > Pila4.Count) && (Pila3.Count >= Pila2.Count) && (Pila1.Count == Pila3.Count))
            {
                Caja4();
                Limpiar();
            }//25. La cola 1 tiene más que la cola 4, la cola 2 y cola 3 tiene más que la cola 1
            else if ((Pila1.Count > Pila4.Count) && ((Pila2.Count > Pila1.Count) && (Pila3.Count > Pila1.Count)))
            {
                Caja4();
                Limpiar();
            }
            else if (Pila2.Count > Pila1.Count && Pila3.Count == Pila4.Count && Pila2.Count > Pila3.Count && Pila1.Count > Pila3.Count)
            {
                Caja3();
                Limpiar();
            }//26. La cola 2 tiene más que la cola 1,3 y 4; La cola 3 y 4 tienen lo mismo.
            else if (Pila2.Count > Pila1.Count && Pila3.Count == Pila4.Count && Pila2.Count > Pila3.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila2.Count > Pila1.Count && Pila2.Count > Pila4.Count && Pila2.Count == Pila3.Count && Pila4.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila3.Count == Pila4.Count && Pila1.Count > Pila2.Count && Pila3.Count > Pila1.Count)
            {
                Caja2();
                Limpiar();
            }
            else if (Pila3.Count == Pila4.Count && Pila1.Count == Pila2.Count && Pila3.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila1.Count == Pila3.Count && Pila3.Count == Pila2.Count && Pila1.Count > Pila2.Count)
            {
                Caja2();
                Limpiar();
            }
            else if (Pila3.Count > Pila4.Count && Pila4.Count == Pila2.Count && Pila2.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila3.Count > Pila1.Count && Pila1.Count > Pila2.Count && Pila2.Count == Pila3.Count)
            {
                Caja2();
                Limpiar();
            }
            else if (Pila2.Count == Pila3.Count && Pila1.Count == Pila4.Count && Pila2.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila4.Count > Pila3.Count && Pila3.Count == Pila2.Count && Pila2.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila1.Count == Pila2.Count && Pila1.Count == Pila3.Count && Pila4.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila3.Count > Pila1.Count && Pila4.Count > Pila2.Count && Pila3.Count > Pila4.Count)
            {
                Caja2();
                Limpiar();
            }
            else if (Pila3.Count > Pila1.Count && Pila1.Count > Pila2.Count && Pila2.Count == Pila4.Count)
            {
                Caja2();
                Limpiar();
            }
            else if (Pila3.Count > Pila1.Count && Pila1.Count == Pila2.Count && Pila2.Count > Pila4.Count())
            {
                Caja4();
                Limpiar();
            }
            else if (Pila1.Count == Pila3.Count && Pila3.Count == Pila4.Count && Pila4.Count > Pila2.Count)
            {
                Caja2();
                Limpiar();
            }
            else if (Pila2.Count == Pila3.Count && Pila3.Count == Pila4.Count && Pila4.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila3.Count > Pila2.Count && Pila2.Count > Pila4.Count && Pila4.Count > Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila3.Count > Pila2.Count && Pila2.Count > Pila1.Count && Pila1.Count == Pila4.Count)
            {
                Caja1();
                Limpiar();
            }
            else if (Pila2.Count > Pila1.Count && Pila1.Count == Pila4.Count && Pila4.Count > Pila3.Count)
            {
                Caja3();
                Limpiar();
            }
            else if (Pila4.Count > Pila1.Count && Pila1.Count > Pila2.Count && Pila2.Count == Pila3.Count)
            {
                Caja2();
                Limpiar();
            }
            else if(Pila4.Count>Pila1.Count&&Pila1.Count==Pila2.Count&&Pila2.Count>Pila3.Count)
            {
                Caja3();
                Limpiar();
            }
            else if(Pila1.Count>Pila4.Count&&Pila4.Count>Pila2.Count&&Pila2.Count>Pila3.Count)
            {
                Caja3();
                Limpiar();
            }

            else if(Pila1.Count>Pila3.Count&&Pila3.Count>Pila2.Count&&Pila2.Count>Pila4.Count)
            {
                Caja4();
                Limpiar();
            }
            else if(Pila1.Count==Pila2.Count&&Pila2.Count>Pila4.Count&&Pila4.Count>Pila3.Count)
            {
                Caja3();
                Limpiar();
            }
            else if(Pila1.Count==Pila4.Count&&Pila4.Count>Pila3.Count&&Pila3.Count>Pila2.Count)
            {
                Caja2();
                Limpiar();
            }
            else if(Pila1.Count==Pila4.Count&&Pila4.Count>Pila2.Count&&Pila2.Count>Pila3.Count)
            {
                Caja3();
                Limpiar();
            }
            else if(Pila1.Count>Pila3.Count&&Pila3.Count>Pila4.Count&&Pila4.Count>Pila2.Count)
            {
                Caja2();
                Limpiar();
            }
            else if(Pila3.Count==Pila4.Count&&Pila4.Count>Pila2.Count&&Pila2.Count>Pila1.Count)
            {
                Caja1();
                Limpiar();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                if(Pila1.Count!=0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Pila1.Pop();
                    txtname.Text = cajero1.Persona;
                    cola01.DataSource = Pila1.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (Pila2.Count != 0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Pila2.Pop();
                    txtname.Text = cajero1.Persona;
                    cola02.DataSource = Pila2.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (Pila3.Count != 0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Pila3.Pop();
                    txtname.Text = cajero1.Persona;
                    cola03.DataSource = Pila3.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (Pila4.Count != 0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Pila4.Pop();
                    txtname.Text = cajero1.Persona;
                    cola04.DataSource = Pila4.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres salir del Programa?","Banco",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
