
namespace Guía_N_8___PED
{
    partial class Añadir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstandar
            // 
            this.btnstandar.Location = new System.Drawing.Point(15, 224);
            this.btnstandar.Size = new System.Drawing.Size(75, 27);
            this.btnstandar.Text = "Añadir";
            this.btnstandar.Click += new System.EventHandler(this.btnstandar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.Text = "Descripcion";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(99, 53);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(100, 20);
            this.txtkey.TabIndex = 3;
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(99, 123);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(100, 20);
            this.txtvalue.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Añadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.txtkey);
            this.Name = "Añadir";
            this.Text = "Añadir";
            this.Controls.SetChildIndex(this.btnstandar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtkey, 0);
            this.Controls.SetChildIndex(this.txtvalue, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Button button1;
    }
}