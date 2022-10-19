
namespace Guía_5___PED
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcantidadnodo = new System.Windows.Forms.Label();
            this.lblcantidadtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmaxaltura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Árbol Binario de Búsqueda";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 61);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 46);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Insertar Nodo";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 127);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 46);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Eliminar Nodo";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 197);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(91, 46);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Buscar Nodo";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(143, 75);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 4;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(143, 141);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(143, 211);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 6;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 267);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(91, 46);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "PreOrden\r\n";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 328);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(91, 46);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "EnOrden";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(143, 267);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(91, 46);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "PostOrden";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ordenamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad de Nodos";
            // 
            // lblcantidadnodo
            // 
            this.lblcantidadnodo.AutoSize = true;
            this.lblcantidadnodo.Location = new System.Drawing.Point(669, 408);
            this.lblcantidadnodo.Name = "lblcantidadnodo";
            this.lblcantidadnodo.Size = new System.Drawing.Size(0, 13);
            this.lblcantidadnodo.TabIndex = 16;
            // 
            // lblcantidadtotal
            // 
            this.lblcantidadtotal.AutoSize = true;
            this.lblcantidadtotal.Location = new System.Drawing.Point(458, 408);
            this.lblcantidadtotal.Name = "lblcantidadtotal";
            this.lblcantidadtotal.Size = new System.Drawing.Size(0, 13);
            this.lblcantidadtotal.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cantidad Total de Info:";
            // 
            // lblmaxaltura
            // 
            this.lblmaxaltura.AutoSize = true;
            this.lblmaxaltura.Location = new System.Drawing.Point(458, 375);
            this.lblmaxaltura.Name = "lblmaxaltura";
            this.lblmaxaltura.Size = new System.Drawing.Size(0, 13);
            this.lblmaxaltura.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Altura del árbol:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmaxaltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcantidadtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcantidadnodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simulador ABB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcantidadnodo;
        private System.Windows.Forms.Label lblcantidadtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmaxaltura;
        private System.Windows.Forms.Label label6;
    }
}

