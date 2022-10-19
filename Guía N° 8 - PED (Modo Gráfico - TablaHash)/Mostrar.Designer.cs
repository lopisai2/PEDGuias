
namespace Guía_N_8___PED
{
    partial class Mostrar
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
            this.SuspendLayout();
            // 
            // btnstandar
            // 
            this.btnstandar.Location = new System.Drawing.Point(148, 239);
            this.btnstandar.Text = "Cerrar";
            this.btnstandar.Click += new System.EventHandler(this.btnstandar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 67);
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.Text = "Clave";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(246, 67);
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.Text = "Descripción";
            this.label2.Visible = false;
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 312);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}