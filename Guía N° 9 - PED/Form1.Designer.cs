
namespace Guía_N__9___PED
{
    partial class App
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsort = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnsort2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page1);
            this.tabControl1.Location = new System.Drawing.Point(12, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // page1
            // 
            this.page1.Location = new System.Drawing.Point(4, 22);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(1232, 508);
            this.page1.TabIndex = 0;
            this.page1.Text = "Heap";
            this.page1.UseVisualStyleBackColor = true;
            this.page1.Paint += new System.Windows.Forms.PaintEventHandler(this.page1_Paint);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(341, 30);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(84, 44);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnsort2);
            this.groupBox1.Controls.Add(this.btnsort);
            this.groupBox1.Controls.Add(this.btnclean);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(142, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
           
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(809, 30);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(84, 44);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(701, 30);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(84, 44);
            this.btnsort.TabIndex = 3;
            this.btnsort.Text = "Maximizante";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(472, 30);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(84, 44);
            this.btnclean.TabIndex = 2;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnsort2
            // 
            this.btnsort2.Location = new System.Drawing.Point(611, 30);
            this.btnsort2.Name = "btnsort2";
            this.btnsort2.Size = new System.Drawing.Size(84, 44);
            this.btnsort2.TabIndex = 3;
            this.btnsort2.Text = "Minimizante";
            this.btnsort2.UseVisualStyleBackColor = true;
            this.btnsort2.Click += new System.EventHandler(this.btnsort2_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "App";
            this.Text = "Guía #9 - PED";
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnsort2;
    }
}

