
namespace Guía_N__2___PED
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.list1 = new System.Windows.Forms.ListBox();
            this.cboxcolors2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneraser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.x02 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.y01 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.y02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.areadibujo = new System.Windows.Forms.PictureBox();
            this.txtspace = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.btn21 = new System.Windows.Forms.Button();
            this.cboxcolors = new System.Windows.Forms.ComboBox();
            this.colorlapiz = new System.Windows.Forms.Label();
            this.espacio = new System.Windows.Forms.Label();
            this.cantlineas = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tiempo1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.list1);
            this.tabPage1.Controls.Add(this.cboxcolors2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ejercicio 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Color";
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(616, 6);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(156, 95);
            this.list1.TabIndex = 1;
            // 
            // cboxcolors2
            // 
            this.cboxcolors2.FormattingEnabled = true;
            this.cboxcolors2.Location = new System.Drawing.Point(631, 134);
            this.cboxcolors2.Name = "cboxcolors2";
            this.cboxcolors2.Size = new System.Drawing.Size(121, 21);
            this.cboxcolors2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 418);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneraser);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.x02);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.y01);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.y02);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.x01);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.areadibujo);
            this.tabPage2.Controls.Add(this.txtspace);
            this.tabPage2.Controls.Add(this.txtcant);
            this.tabPage2.Controls.Add(this.btn21);
            this.tabPage2.Controls.Add(this.cboxcolors);
            this.tabPage2.Controls.Add(this.colorlapiz);
            this.tabPage2.Controls.Add(this.espacio);
            this.tabPage2.Controls.Add(this.cantlineas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ejercicio 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneraser
            // 
            this.btneraser.Location = new System.Drawing.Point(62, 353);
            this.btneraser.Name = "btneraser";
            this.btneraser.Size = new System.Drawing.Size(99, 47);
            this.btneraser.TabIndex = 22;
            this.btneraser.Text = "Borrar Lineas";
            this.btneraser.UseVisualStyleBackColor = true;
            this.btneraser.Click += new System.EventHandler(this.btneraser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Puntos iniciales y finales";
            // 
            // x02
            // 
            this.x02.Location = new System.Drawing.Point(63, 217);
            this.x02.Name = "x02";
            this.x02.Size = new System.Drawing.Size(24, 20);
            this.x02.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "X2";
            // 
            // y01
            // 
            this.y01.Location = new System.Drawing.Point(161, 175);
            this.y01.Name = "y01";
            this.y01.Size = new System.Drawing.Size(24, 20);
            this.y01.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y1";
            // 
            // y02
            // 
            this.y02.Location = new System.Drawing.Point(161, 217);
            this.y02.Name = "y02";
            this.y02.Size = new System.Drawing.Size(24, 20);
            this.y02.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y2";
            // 
            // x01
            // 
            this.x01.Location = new System.Drawing.Point(63, 175);
            this.x01.Name = "x01";
            this.x01.Size = new System.Drawing.Size(24, 20);
            this.x01.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X1";
            // 
            // areadibujo
            // 
            this.areadibujo.Location = new System.Drawing.Point(241, 6);
            this.areadibujo.Name = "areadibujo";
            this.areadibujo.Size = new System.Drawing.Size(543, 410);
            this.areadibujo.TabIndex = 12;
            this.areadibujo.TabStop = false;
            this.areadibujo.Click += new System.EventHandler(this.areadibujo_Click);
            // 
            // txtspace
            // 
            this.txtspace.Location = new System.Drawing.Point(62, 67);
            this.txtspace.Name = "txtspace";
            this.txtspace.Size = new System.Drawing.Size(100, 20);
            this.txtspace.TabIndex = 11;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(63, 25);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 10;
            this.txtcant.TextChanged += new System.EventHandler(this.txtcant_TextChanged);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(62, 289);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(99, 47);
            this.btn21.TabIndex = 9;
            this.btn21.Text = "Dibujar lineas";
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            // 
            // cboxcolors
            // 
            this.cboxcolors.FormattingEnabled = true;
            this.cboxcolors.Location = new System.Drawing.Point(63, 107);
            this.cboxcolors.Name = "cboxcolors";
            this.cboxcolors.Size = new System.Drawing.Size(100, 21);
            this.cboxcolors.TabIndex = 8;
            // 
            // colorlapiz
            // 
            this.colorlapiz.AutoSize = true;
            this.colorlapiz.Location = new System.Drawing.Point(9, 110);
            this.colorlapiz.Name = "colorlapiz";
            this.colorlapiz.Size = new System.Drawing.Size(31, 13);
            this.colorlapiz.TabIndex = 7;
            this.colorlapiz.Text = "Color";
            // 
            // espacio
            // 
            this.espacio.AutoSize = true;
            this.espacio.Location = new System.Drawing.Point(9, 67);
            this.espacio.Name = "espacio";
            this.espacio.Size = new System.Drawing.Size(45, 13);
            this.espacio.TabIndex = 5;
            this.espacio.Text = "Espacio";
            this.espacio.Click += new System.EventHandler(this.label2_Click);
            // 
            // cantlineas
            // 
            this.cantlineas.AutoSize = true;
            this.cantlineas.Location = new System.Drawing.Point(9, 25);
            this.cantlineas.Name = "cantlineas";
            this.cantlineas.Size = new System.Drawing.Size(49, 13);
            this.cantlineas.TabIndex = 3;
            this.cantlineas.Text = "Cantidad";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ejercicio 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage3_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(786, 418);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ir al ejercicio 3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tiempo1
            // 
            this.tiempo1.Enabled = true;
            this.tiempo1.Tick += new System.EventHandler(this.tiempo1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guía N°2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.ComboBox cboxcolors;
        private System.Windows.Forms.Label colorlapiz;
        private System.Windows.Forms.Label espacio;
        private System.Windows.Forms.Label cantlineas;
        private System.Windows.Forms.TextBox txtspace;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.PictureBox areadibujo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x02;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneraser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxcolors2;
        private System.Windows.Forms.Timer tiempo1;
        private System.Windows.Forms.Button button1;
    }
}

