
namespace Guía_N__7___Complementaria___PED
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
            this.txtdato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnnumeros = new System.Windows.Forms.RadioButton();
            this.rbtnletras = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnpostorden = new System.Windows.Forms.RadioButton();
            this.rbtnenorden = new System.Windows.Forms.RadioButton();
            this.rbtnpreorden = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtrecorrido = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblrotacion = new System.Windows.Forms.Label();
            this.lblmaxaltura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(84, 83);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(100, 20);
            this.txtdato.TabIndex = 0;
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
            this.txtdato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdato_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btninsertar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnnumeros);
            this.groupBox1.Controls.Add(this.rbtnletras);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdato);
            this.groupBox1.Location = new System.Drawing.Point(845, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(247, 50);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(124, 23);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(247, 81);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(124, 23);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(247, 19);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(124, 23);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Arbol AVL";
            // 
            // rbtnnumeros
            // 
            this.rbtnnumeros.AutoSize = true;
            this.rbtnnumeros.Location = new System.Drawing.Point(119, 47);
            this.rbtnnumeros.Name = "rbtnnumeros";
            this.rbtnnumeros.Size = new System.Drawing.Size(67, 17);
            this.rbtnnumeros.TabIndex = 3;
            this.rbtnnumeros.TabStop = true;
            this.rbtnnumeros.Text = "Números";
            this.rbtnnumeros.UseVisualStyleBackColor = true;
            this.rbtnnumeros.CheckedChanged += new System.EventHandler(this.rbtnnumeros_CheckedChanged);
            // 
            // rbtnletras
            // 
            this.rbtnletras.AutoSize = true;
            this.rbtnletras.Location = new System.Drawing.Point(50, 47);
            this.rbtnletras.Name = "rbtnletras";
            this.rbtnletras.Size = new System.Drawing.Size(54, 17);
            this.rbtnletras.TabIndex = 2;
            this.rbtnletras.TabStop = true;
            this.rbtnletras.Text = "Letras";
            this.rbtnletras.UseVisualStyleBackColor = true;
            this.rbtnletras.CheckedChanged += new System.EventHandler(this.rbtnletras_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato:";
            // 
            // rbtnpostorden
            // 
            this.rbtnpostorden.AutoSize = true;
            this.rbtnpostorden.Location = new System.Drawing.Point(6, 86);
            this.rbtnpostorden.Name = "rbtnpostorden";
            this.rbtnpostorden.Size = new System.Drawing.Size(78, 17);
            this.rbtnpostorden.TabIndex = 7;
            this.rbtnpostorden.TabStop = true;
            this.rbtnpostorden.Text = "Post Orden";
            this.rbtnpostorden.UseVisualStyleBackColor = true;
            this.rbtnpostorden.CheckedChanged += new System.EventHandler(this.rbtnpostorden_CheckedChanged);
            // 
            // rbtnenorden
            // 
            this.rbtnenorden.AutoSize = true;
            this.rbtnenorden.Location = new System.Drawing.Point(6, 19);
            this.rbtnenorden.Name = "rbtnenorden";
            this.rbtnenorden.Size = new System.Drawing.Size(70, 17);
            this.rbtnenorden.TabIndex = 6;
            this.rbtnenorden.TabStop = true;
            this.rbtnenorden.Text = "En Orden";
            this.rbtnenorden.UseVisualStyleBackColor = true;
            this.rbtnenorden.CheckedChanged += new System.EventHandler(this.rbtnenorden_CheckedChanged);
            // 
            // rbtnpreorden
            // 
            this.rbtnpreorden.AutoSize = true;
            this.rbtnpreorden.Location = new System.Drawing.Point(6, 53);
            this.rbtnpreorden.Name = "rbtnpreorden";
            this.rbtnpreorden.Size = new System.Drawing.Size(73, 17);
            this.rbtnpreorden.TabIndex = 8;
            this.rbtnpreorden.TabStop = true;
            this.rbtnpreorden.Text = "Pre Orden";
            this.rbtnpreorden.UseVisualStyleBackColor = true;
            this.rbtnpreorden.CheckedChanged += new System.EventHandler(this.rbtnpreorden_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtrecorrido);
            this.groupBox2.Controls.Add(this.rbtnpreorden);
            this.groupBox2.Controls.Add(this.rbtnpostorden);
            this.groupBox2.Controls.Add(this.rbtnenorden);
            this.groupBox2.Location = new System.Drawing.Point(845, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorridos";
            // 
            // txtrecorrido
            // 
            this.txtrecorrido.Location = new System.Drawing.Point(90, 50);
            this.txtrecorrido.Name = "txtrecorrido";
            this.txtrecorrido.Size = new System.Drawing.Size(100, 20);
            this.txtrecorrido.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblrotacion);
            this.groupBox3.Controls.Add(this.lblmaxaltura);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(1054, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Adicional";
            // 
            // lblrotacion
            // 
            this.lblrotacion.AutoSize = true;
            this.lblrotacion.Location = new System.Drawing.Point(28, 90);
            this.lblrotacion.Name = "lblrotacion";
            this.lblrotacion.Size = new System.Drawing.Size(0, 13);
            this.lblrotacion.TabIndex = 11;
            // 
            // lblmaxaltura
            // 
            this.lblmaxaltura.AutoSize = true;
            this.lblmaxaltura.Location = new System.Drawing.Point(90, 32);
            this.lblmaxaltura.Name = "lblmaxaltura";
            this.lblmaxaltura.Size = new System.Drawing.Size(0, 13);
            this.lblmaxaltura.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Última rotación realizada en el árbol: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Altura del Árbol: ";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "App";
            this.Text = "AVL Letras y Números";
            this.Load += new System.EventHandler(this.App_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.App_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnnumeros;
        private System.Windows.Forms.RadioButton rbtnletras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnpostorden;
        private System.Windows.Forms.RadioButton rbtnenorden;
        private System.Windows.Forms.RadioButton rbtnpreorden;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblrotacion;
        private System.Windows.Forms.Label lblmaxaltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrecorrido;
    }
}

