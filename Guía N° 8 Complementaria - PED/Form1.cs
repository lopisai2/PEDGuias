using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Guía_N__8_Complementaria___PED
{
    public partial class App : Form
    {
        public Hashtable tabla = new Hashtable();
        private Agregar ventanaadd;
        private Eliminar ventanadelete;
        private Actualizar ventanaupdate;
        private Consultar ventanaconsult;
        private Mostrar ventanashow;
        public App()
        {
            InitializeComponent();
            ventanaadd = new Agregar();
            ventanaconsult = new Consultar();
            ventanadelete = new Eliminar();
            ventanashow = new Mostrar();
            ventanaupdate = new Actualizar();
        }
        public bool validameesta(TextBox name)
        {
            Regex Expresion = new Regex("^[0-9]{7}-[0-9]{1}");
            if (Expresion.IsMatch(name.Text))
            {
                return true;
            }
            else
            {
                name.Clear();
                name.Focus();
                return false;
            }
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                ventanaadd.ShowDialog();
                if (ventanaadd.controlventana)
                {
                    MessageBox.Show(ventanaadd.dato);
                    tabla.Add(ventanaadd.dato,ventanaadd.dato1);
                    MessageBox.Show("Dui añadido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                ventanaupdate.ShowDialog();
                if(ventanaupdate.controlventana)
                {
                    if(tabla.ContainsKey(ventanaupdate.dato))
                    {
                        tabla.Remove(ventanaupdate.dato);
                        tabla.Add(ventanaupdate.dato, ventanaupdate.dato1);
                        MessageBox.Show("Dui Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Dui no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ventanadelete.ShowDialog();
                if(ventanadelete.controlventana)
                {
                    if(tabla.ContainsKey(ventanadelete.txtkey.Text))
                    {
                        tabla.Remove(ventanadelete.dato);
                        MessageBox.Show("El Dui y la información de este se ha eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Dui no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ventanashow.h = tabla;
            ventanashow.ShowDialog();
        }

        private void btnconsult_Click(object sender, EventArgs e)
        {
            try
            {
                ventanaconsult.ShowDialog();
                if (ventanaconsult.controlventana)
                {
                    if (tabla.ContainsKey(ventanaconsult.dato))
                    {
                        MessageBox.Show("El Dui: " + ventanaconsult.dato + "tiene el nombre de: " + tabla[ventanaconsult.dato], "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Dui no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception A)
            {

                MessageBox.Show(A.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
