using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N_4._1___PED
{
    public partial class Form1 : Form
    {
        Queue<Cajero1> Cola1 = new Queue<Cajero1>();
        Queue<Cajero1> Cola2 = new Queue<Cajero1>();
        Queue<Cajero1> Cola3 = new Queue<Cajero1>();
        Queue<Cajero1> Cola4 = new Queue<Cajero1>();
        Cajero1 cajero1 = new Cajero1();
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
            cajero1.Persona = txtname.Text;
            Cola1.Enqueue(cajero1);
            cola01.DataSource = null;
            cola01.DataSource = Cola1.ToArray();
        }
        private void Caja2()
        {
            cajero1.Persona = txtname.Text;
            Cola2.Enqueue(cajero1);
            cola02.DataSource = null;
            cola02.DataSource = Cola2.ToArray();
        }
        private void Caja3()
        {
            cajero1.Persona = txtname.Text;
            Cola3.Enqueue(cajero1);
            cola03.DataSource = null;
            cola03.DataSource = Cola3.ToArray();
        }
        private void Caja4()
        {
            cajero1.Persona = txtname.Text;
            Cola4.Enqueue(cajero1);
            cola04.DataSource = null;
            cola04.DataSource = Cola4.ToArray();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Cajero1 cajero1 = new Cajero1();
            if (Cola1.Count == 0)
            {
                Caja1();
            }//1.Las cajas 1,2,3,4 tienen la misma cantidad de clientes
            else if (Cola1.Count == Cola2.Count && Cola1.Count == Cola3.Count && Cola1.Count == Cola4.Count && Cola2.Count == Cola3.Count && Cola2.Count == Cola4.Count && Cola3.Count == Cola4.Count)
            {
                Caja1();
            }
            else if ((Cola1.Count > Cola2.Count && Cola1.Count > Cola3.Count && Cola1.Count > Cola4.Count) && (Cola2.Count == Cola3.Count)&&Cola3.Count>Cola4.Count)
            {
                Caja4();

            }
            //2.La cola 1 tiene más que la caja 2. La cola 1 tiene más que la caja 3. La caja 1 tiene más que la caja 4. Además, y la cola 2 tiene lo mismo que la cola 3
            else if ((Cola1.Count > Cola2.Count && Cola1.Count > Cola3.Count && Cola1.Count > Cola4.Count) && (Cola2.Count == Cola3.Count))
            {
                Caja2();

            }
            else if ((Cola1.Count == Cola3.Count && Cola2.Count > Cola4.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count) && Cola1.Count == Cola4.Count)
            {
                Caja1();
            }
            else if ((Cola1.Count == Cola3.Count && Cola2.Count > Cola4.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count && Cola4.Count > Cola1.Count))
            {
                Caja1();
            }//24.La cola 4 tiene más que la cola 1.
            else if ((Cola1.Count == Cola3.Count && Cola2.Count > Cola4.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count))
            {
                Caja4();
            }
            else //3.La cola 2 tiene mas clientes que la cola 3, la cola 1 tiene más que la cola 2. Además. la caja 1 tiene más clientes que la caja 3 y caja 4, la caja 2 tiene más que la caja 4 y la caja 3 tiene más que la caja 4. SI
            if (((Cola2.Count > Cola3.Count) && (Cola1.Count > Cola2.Count) && (Cola1.Count > Cola3.Count && Cola1.Count > Cola4.Count && Cola2.Count > Cola4.Count && Cola3.Count > Cola4.Count)))
            {
                Caja4();
            }
            else //4.La caja 3 tiene más clientes que la caja 4, al igual que la caja 2 y caja 1. Además la cola 1 tiene lo mismo que la cola 2 y cola 3. SI
            if ((Cola3.Count > Cola4.Count && Cola2.Count > Cola4.Count && Cola1.Count > Cola4.Count) && (Cola1.Count == Cola2.Count && Cola1.Count == Cola3.Count))
            {
                Caja4();
            }//5.La Cola 2 tiene más que la caja 4, La cola 1 tiene lo mismo que la cola 3. Además la caja 1 tiene más que la caja 2 y caja 4; La cola 3 tiene más que la cola 2 y cola 4.  SI
            else if ((Cola2.Count > Cola4.Count && Cola1.Count == Cola3.Count) && (Cola1.Count > Cola2.Count && Cola1.Count > Cola4.Count) && Cola3.Count > Cola2.Count && Cola3.Count > Cola4.Count)
            {
                Caja4();
            }//6.La cola 1 tiene lo mismo que la cola 2 y la cola 3 lo mismo que la cola 4. Además, la cola 1 tiene más que la cola 3 y cola 4. SI
            else if (((Cola1.Count == Cola2.Count) && (Cola3.Count == Cola4.Count)) && (Cola1.Count > Cola3.Count && Cola1.Count > Cola4.Count))
            {
                Caja3();
            }//7.La cola 1,3 y 4 tienen más que la cola 2. Además la cola 1 tiene lo mismo que la cola 3 y la cola 1 tiene más que la cola 4. SI
            else if ((Cola1.Count > Cola2.Count && Cola3.Count > Cola2.Count && Cola4.Count > Cola2.Count) && (Cola1.Count == Cola3.Count && Cola1.Count > Cola4.Count))
            {
                Caja2();
            }//8.La cola 2 tiene los mismo que la cola 3, la cola 1 tiene lo mismo que la caja 4. Además, la Cola 1 tiene más que la cola 2 y 3; La cola 4 tiene más que la cola dos y cola 3. SI
            else if ((Cola2.Count == Cola3.Count && Cola1.Count == Cola4.Count) && (Cola1.Count > Cola2.Count && Cola1.Count > Cola3.Count && Cola4.Count > Cola2.Count && Cola4.Count > Cola3.Count))
            {
                Caja2();
            }//9.La cola 1 tiene lo mismo que la cola 2, la cola 2 tiene lo mismo que la cola 4. Además, la cola 3 tiene más que la cola 1,2 y 4. SI
            else if ((Cola1.Count == Cola2.Count && Cola2.Count == Cola4.Count) && (Cola3.Count > Cola1.Count && Cola3.Count > Cola2.Count && Cola3.Count > Cola4.Count))
            {
                Caja1();
            }//10.La cola 1 tiene lo mismo que la cola 3 y cola 4. Además la cola 2 tiene más que la cola 1,2 y 4. SI
            else if ((Cola1.Count == Cola3.Count && Cola1.Count == Cola4.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count && Cola2.Count > Cola4.Count))
            {
                Caja1();
            }//11. La cola 1 tiene lo mismo que la cola 4 y la cola 2 tiene lo mismo que la cola 3. Además la cola 3 tiene más que la cola 1 y cola 4; La cola 2 tien más que la cola 1 y cola 4. SI
            else if ((Cola1.Count == Cola4.Count && Cola2.Count == Cola3.Count) && (Cola3.Count > Cola1.Count && Cola3.Count > Cola4.Count && Cola2.Count > Cola1.Count && Cola2.Count > Cola4.Count))
            {
                Caja1();
            }//12. La cola 1 tiene lo mismo que la cola 3 y la cola 2 tiene más que la cola 4. Además, la cola 2 tiene más que la cola 1 y cola 3; La cola 4 tiene más que la cola 1 y 3. SI
            else if ((Cola1.Count == Cola3.Count && Cola2.Count > Cola4.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count && Cola4.Count > Cola1.Count && Cola4.Count > Cola3.Count))
            {
                Caja1();
            }//13. La cola 1 tiene más que a cola 3 y la cola 2 tiene más que la cola 4. Además, la cola 2 tiene más que la cola 1 y la cola 4 más que la cola 1. SI
            else if ((Cola1.Count > Cola3.Count && Cola2.Count > Cola4.Count) && (Cola2.Count > Cola1.Count && Cola4.Count > Cola1.Count))
            {
                Caja3();
            }//14. La cola 1 tiene lo mismo que la cola 4 y la cola 2 tiene más que la cola 3. Además, la cola 2 tiene más que la cola 1 y cola 3; La cola 2 y cola 3  tiene más que la cola 4
            else if ((Cola1.Count == Cola4.Count && Cola2.Count > Cola3.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count && Cola3.Count > Cola4.Count && Cola2.Count > Cola4.Count))
            {
                Caja1();
            }//15. La cola 1 tiene lo mismo que la cola 2 y la cola 3 tiene más que la cola 4. Además, la cola 1 tiene más que la cola 3 y cola 4; La cola 2 tiene más que la cola 3 y 4. SI
            else if ((Cola1.Count == Cola2.Count && Cola3.Count > Cola4.Count) && (Cola1.Count > Cola3.Count && Cola1.Count > Cola4.Count && Cola2.Count > Cola3.Count && Cola2.Count > Cola4.Count))
            {
                Caja4();
            }//16. La cola 3 tiene menos que la cola 2 y a cola 4 tiene menos que la cola 1. Además, la cola 1 tiene más que la cola 2 y cola 3; La cola 2 tiene más que la cola 3 y cola 4. SII
            else if ((Cola3.Count < Cola2.Count && Cola4.Count < Cola1.Count) && (Cola1.Count > Cola2.Count && Cola1.Count > Cola3.Count && Cola2.Count > Cola3.Count && Cola2.Count > Cola4.Count))
            {
                Caja3();
            }//17. La cola 1 tiene lo mismo que la cola 2 y la cola 4 tiene más que la cola 3. Además, la cola 1 tiene lo mismo que la cola 2 y la cola 2 lo mismo que la cola 4. EH
            else if ((Cola1.Count == Cola2.Count && Cola4.Count > Cola3.Count) && (Cola1.Count == Cola2.Count && Cola2.Count == Cola4.Count))
            {
                Caja3();
            }//18. La cola 1 tiene lo mismo que la cola 3 y la cola 2 tiene más que la cola 4. ERR
            else if ((Cola1.Count == Cola3.Count && Cola2.Count > Cola4.Count) && (Cola2.Count > Cola1.Count && Cola2.Count > Cola3.Count))
            {
                Caja1();
            }//19. La cola 2 tiene los mismo que la cola 4 y la cola 2 tiene más que la cola 3. La cola 1 tiene lo mismo que la cola 3.
            else if ((Cola2.Count == Cola4.Count) && (Cola2.Count > Cola3.Count) && (Cola1.Count == Cola3.Count))
            {
                Caja1();
            }//20. La cola 2 tiene lo mismo que la cola 4 y la cola 3 tiene lo mismo que la cola 1. Además, la cola 1 tiene más que la cola 2 y cola 4
            else if (((Cola2.Count == Cola4.Count) && (Cola3.Count == Cola1.Count)) && (Cola1.Count > Cola2.Count && Cola1.Count > Cola4.Count))
            {
                Caja2();
            }//21. La cola 1 tiene lo mismo que la cola 3 y la cola 2 y cola 4  tienen más que la cola 1.
            else if ((Cola1.Count == Cola3.Count) && (Cola2.Count > Cola1.Count) && (Cola4.Count > Cola1.Count))
            {
                Caja1();
            }
            else if ((Cola1.Count > Cola3.Count) && (Cola2.Count == Cola4.Count)&&Cola3.Count>Cola2.Count)
            {
                Caja2();
            }//22. La cola 1 tiene más que la cola 3 y la cola 2 tiene lo mismo que la cola 4.
            else if ((Cola1.Count > Cola3.Count) && (Cola2.Count == Cola4.Count))
            {
                Caja3();
            }//23. La cola 2 tiene más que la cola 4 y la cola 3 tiene más que la cola 2. Además la cola 1 tiene lo mismo que la cola 3.
            else if ((Cola2.Count > Cola4.Count) && (Cola3.Count >= Cola2.Count) && (Cola1.Count == Cola3.Count))
            {
                Caja4();
            }//25. La cola 1 tiene más que la cola 4, la cola 2 y cola 3 tiene más que la cola 1
            else if ((Cola1.Count > Cola4.Count) && ((Cola2.Count > Cola1.Count) && (Cola3.Count > Cola1.Count)))
            {
                Caja4();
            }
            else if (Cola2.Count > Cola1.Count && Cola3.Count == Cola4.Count && Cola2.Count > Cola3.Count && Cola1.Count > Cola3.Count)
            {
                Caja3();
            }//26. La cola 2 tiene más que la cola 1,3 y 4; La cola 3 y 4 tienen lo mismo.
            else if (Cola2.Count > Cola1.Count && Cola3.Count == Cola4.Count && Cola2.Count > Cola3.Count)
            {
                Caja1();
            }
            else if (Cola2.Count > Cola1.Count && Cola2.Count > Cola4.Count && Cola2.Count == Cola3.Count && Cola4.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola3.Count == Cola4.Count && Cola1.Count > Cola2.Count && Cola3.Count > Cola1.Count)
            {
                Caja2();
            }
            else if (Cola3.Count == Cola4.Count && Cola1.Count == Cola2.Count && Cola3.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola1.Count == Cola3.Count && Cola3.Count == Cola2.Count && Cola1.Count > Cola2.Count)
            {
                Caja2();
            }
            else if (Cola3.Count > Cola4.Count && Cola4.Count == Cola2.Count && Cola2.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola3.Count > Cola1.Count && Cola1.Count > Cola2.Count && Cola2.Count == Cola3.Count)
            {
                Caja2();
            }
            else if (Cola2.Count == Cola3.Count && Cola1.Count == Cola4.Count && Cola2.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola4.Count > Cola3.Count && Cola3.Count == Cola2.Count && Cola2.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola1.Count == Cola2.Count && Cola1.Count == Cola3.Count && Cola4.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola3.Count > Cola1.Count && Cola4.Count > Cola2.Count && Cola3.Count > Cola4.Count)
            {
                Caja2();
            }
            else if (Cola3.Count > Cola1.Count && Cola1.Count > Cola2.Count && Cola2.Count == Cola4.Count)
            {
                Caja2();
            }
            else if (Cola3.Count > Cola1.Count && Cola1.Count == Cola2.Count && Cola2.Count > Cola4.Count())
            {
                Caja4();
            }
            else if (Cola1.Count == Cola3.Count && Cola3.Count == Cola4.Count && Cola4.Count > Cola2.Count)
            {
                Caja2();
            }
            else if (Cola2.Count == Cola3.Count && Cola3.Count == Cola4.Count && Cola4.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola3.Count > Cola2.Count && Cola2.Count > Cola4.Count && Cola4.Count > Cola1.Count)
            {
                Caja1();
            }
            else if (Cola3.Count > Cola2.Count && Cola2.Count > Cola1.Count && Cola1.Count == Cola4.Count)
            {
                Caja1();
            }
            else if (Cola2.Count > Cola1.Count && Cola1.Count == Cola4.Count && Cola4.Count > Cola3.Count)
            {
                Caja3();
            }
            else if (Cola4.Count > Cola1.Count && Cola1.Count > Cola2.Count && Cola2.Count == Cola3.Count)
            {
                Caja2();
            }
            else if(Cola4.Count>Cola1.Count&&Cola1.Count==Cola2.Count&&Cola2.Count>Cola3.Count)
            {
                Caja3();
            }
            else if(Cola1.Count>Cola4.Count&&Cola4.Count>Cola2.Count&&Cola2.Count>Cola3.Count)
            {
                Caja3();
            }
            else if(Cola1.Count>Cola3.Count&&Cola3.Count>Cola2.Count&&Cola2.Count>Cola4.Count)
            {
                Caja4();
            }
            else if(Cola1.Count==Cola2.Count&&Cola2.Count>Cola4.Count&&Cola4.Count>Cola3.Count)
            {
                Caja3();
            }
            else if(Cola1.Count==Cola4.Count&&Cola4.Count>Cola3.Count&&Cola3.Count>Cola2.Count)
            {
                Caja2();
            }
            else if(Cola1.Count==Cola4.Count&&Cola4.Count>Cola2.Count&&Cola2.Count>Cola3.Count)
            {
                Caja3();
            }
            else if(Cola1.Count>Cola3.Count&&Cola3.Count>Cola4.Count&&Cola4.Count>Cola2.Count)
            {
                Caja2();
            }
            else if(Cola3.Count==Cola4.Count&&Cola4.Count>Cola2.Count&&Cola2.Count>Cola1.Count)
            {
                Caja1();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                if(Cola1.Count!=0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Cola1.Dequeue();
                    txtname.Text = cajero1.Persona;
                    cola01.DataSource = Cola1.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (Cola2.Count != 0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Cola2.Dequeue();
                    txtname.Text = cajero1.Persona;
                    cola02.DataSource = Cola2.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (Cola3.Count != 0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Cola3.Dequeue();
                    txtname.Text = cajero1.Persona;
                    cola03.DataSource = Cola3.ToList();
                }
                else
                {
                    MessageBox.Show("Cola Vacía", "Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (Cola4.Count != 0)
                {
                    Cajero1 cajero1 = new Cajero1();
                    cajero1 = Cola4.Dequeue();
                    txtname.Text = cajero1.Persona;
                    cola04.DataSource = Cola4.ToList();
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

        private void cola01_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
