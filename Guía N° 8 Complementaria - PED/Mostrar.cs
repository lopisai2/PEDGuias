using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Guía_N__8_Complementaria___PED
{
    public partial class Mostrar : BaseOpciones
    {
        public Hashtable h = new Hashtable();
        
        public Mostrar()
        {
            InitializeComponent();
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            App app = new App();
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("?");
            dt.Columns.Add("Dui", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            DataRow row = null;            
            IDictionaryEnumerator enumerator = h.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string indice = (string)enumerator.Key;
                string valor = (string)enumerator.Value;
                row = dt.NewRow();
                row["Dui"] = indice;
                row["Nombre"] = valor;
                dt.Rows.Add(row);
            }
                dataGridView1.DataSource = null;            
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 230;
            dataGridView1.Columns[1].Width = 230;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
