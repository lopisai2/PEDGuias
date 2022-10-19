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
namespace Guía_N__4___PED
{
    public partial class Form1 : Form
    {        
        Stack<Empleados> Pilatrabajadores = new Stack<Empleados>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Source0()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Pilatrabajadores.ToArray();
        }
        private void Limpiar()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            try
            {
                error1.Clear();
                Empleados empleado = new Empleados();
                empleado.Carnet = txt1.Text;
                empleado.Nombre = txt2.Text;
                if (Convert.ToInt64(txt3.Text) < 0)
                {
                    error1.SetError(txt3, "El Salario debe ser mayor o igual a cero.");
                }
                else
                {
                    empleado.Salario = Convert.ToInt64(txt3.Text);
                    empleado.Fecha = dtp1.Value;                    
                    Pilatrabajadores.Push(empleado);
                    Source0();
                    Limpiar();
                }
            }
            catch (Exception A)
            {

                if(string.IsNullOrEmpty(txt1.Text))
                {
                    error1.SetError(txt1,"El campo está vacío.");
                }
                if (string.IsNullOrEmpty(txt2.Text))
                {
                    error1.SetError(txt2, "El campo está vacío.");
                }
                if (string.IsNullOrEmpty(txt3.Text))
                {
                    error1.SetError(txt3, A.Message);
                }                              
            }
            
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pilatrabajadores.Count != 0)
                {
                    Empleados empleado = new Empleados();
                    empleado =Pilatrabajadores.Pop();
                    txt1.Text = empleado.Carnet;
                    txt2.Text = empleado.Nombre;
                    txt3.Text = empleado.Salario.ToString();
                    dtp1.Value = empleado.Fecha;
                    dataGridView1.DataSource = Pilatrabajadores.ToList();
                    MessageBox.Show("Se eliminó el registro", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No hay elementos dentro de la cola.");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
