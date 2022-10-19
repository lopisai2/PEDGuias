using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía_N_5___PED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void btncomp_Click(object sender, EventArgs e)
        {
            Parentesis clase = new Parentesis();
            string a = txtmath.Text;
            char[] texto = a.ToCharArray();
            bool test=true;
            Stack<char> comp = new Stack<char>();
            for(int i=0;i<texto.Length;i++)
            {
                if(clase.inicio(texto[i]))
                {
                    comp.Push(texto[i]);
                }
                else
                {
                    if (comp.Count == 0)
                    {
                        test = false;
                        
                    } else if (comp.Peek() == clase.Obtener(texto[i]))
                    {
                        comp.Pop();
                        test = true;
                    }else
                    {
                        test = false;
                        
                    }
                }
                
            }
            if (comp.Count != 0)
            {
                test = false;
            }
            else if (test)
            {
                MessageBox.Show(a + " es una expresion algebráica correcta");
            }
            else
            {
                MessageBox.Show(a + " No es una expresion algebráica correcta");
            }
        }

        private void btnpali_Click(object sender, EventArgs e)
        {
            Palindromo palindromo = new Palindromo();
            if(palindromo.Verificar(txtmath.Text))
            {
                MessageBox.Show("La palabra o frase '" + txtmath.Text + "' es un palíndromo", "Guía 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La palabra o frase '" + txtmath.Text + "' no es un palíndromo", "Guía 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
