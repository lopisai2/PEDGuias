
namespace Guía_N_4._1___PED
{
    partial class Form1
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
            this.cola01 = new System.Windows.Forms.DataGridView();
            this.cola03 = new System.Windows.Forms.DataGridView();
            this.cola02 = new System.Windows.Forms.DataGridView();
            this.cola04 = new System.Windows.Forms.DataGridView();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cola01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola04)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cola01
            // 
            this.cola01.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.cola01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cola01.Location = new System.Drawing.Point(6, 19);
            this.cola01.Name = "cola01";
            this.cola01.Size = new System.Drawing.Size(130, 150);
            this.cola01.TabIndex = 0;
            this.cola01.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cola01_CellContentClick);
            // 
            // cola03
            // 
            this.cola03.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.cola03.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cola03.Location = new System.Drawing.Point(6, 207);
            this.cola03.Name = "cola03";
            this.cola03.Size = new System.Drawing.Size(130, 150);
            this.cola03.TabIndex = 1;
            // 
            // cola02
            // 
            this.cola02.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.cola02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cola02.Location = new System.Drawing.Point(142, 19);
            this.cola02.Name = "cola02";
            this.cola02.Size = new System.Drawing.Size(130, 150);
            this.cola02.TabIndex = 2;
            // 
            // cola04
            // 
            this.cola04.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.cola04.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cola04.Location = new System.Drawing.Point(142, 207);
            this.cola04.Name = "cola04";
            this.cola04.Size = new System.Drawing.Size(130, 150);
            this.cola04.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(75, 29);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 33);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(29, 81);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(146, 49);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Ingresar al Banco";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir del Banco";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "Salir de la Aplicacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cola01);
            this.groupBox1.Controls.Add(this.cola03);
            this.groupBox1.Controls.Add(this.cola02);
            this.groupBox1.Controls.Add(this.cola04);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 338);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajeros";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cajero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nombre);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Location = new System.Drawing.Point(329, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 166);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrar al Banco";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(535, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 166);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salir del Banco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Guía 4.1 Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cola01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cola04)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cola01;
        private System.Windows.Forms.DataGridView cola03;
        private System.Windows.Forms.DataGridView cola02;
        private System.Windows.Forms.DataGridView cola04;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

