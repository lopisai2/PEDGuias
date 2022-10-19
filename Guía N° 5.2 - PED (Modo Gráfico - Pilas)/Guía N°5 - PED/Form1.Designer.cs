
namespace Guía_N_5___PED
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
            this.txtmath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncomp = new System.Windows.Forms.Button();
            this.btnpali = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(153, 51);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(100, 20);
            this.txtmath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expresión ";
            // 
            // btncomp
            // 
            this.btncomp.Location = new System.Drawing.Point(116, 141);
            this.btncomp.Name = "btncomp";
            this.btncomp.Size = new System.Drawing.Size(137, 23);
            this.btncomp.TabIndex = 2;
            this.btncomp.Text = "Comprobar Expresión Algebráica";
            this.btncomp.UseVisualStyleBackColor = true;
            this.btncomp.Click += new System.EventHandler(this.btncomp_Click);
            // 
            // btnpali
            // 
            this.btnpali.Location = new System.Drawing.Point(116, 98);
            this.btnpali.Name = "btnpali";
            this.btnpali.Size = new System.Drawing.Size(137, 23);
            this.btnpali.TabIndex = 3;
            this.btnpali.Text = "Comprobar Palíndromo";
            this.btnpali.UseVisualStyleBackColor = true;
            this.btnpali.Click += new System.EventHandler(this.btnpali_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpali);
            this.Controls.Add(this.btncomp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmath);
            this.Name = "Form1";
            this.Text = "Guía 5 - Ejercicio 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncomp;
        private System.Windows.Forms.Button btnpali;
        private System.Windows.Forms.Button button1;
    }
}

