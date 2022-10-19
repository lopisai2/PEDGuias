
namespace Guía_N__8_Complementaria___PED
{
    partial class Consultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnconsult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkey
            // 
            this.txtkey.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkey.Location = new System.Drawing.Point(104, 74);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(100, 25);
            this.txtkey.TabIndex = 9;
            this.txtkey.Leave += new System.EventHandler(this.txtkey_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "DUI:";
            // 
            // btnconsult
            // 
            this.btnconsult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnconsult.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsult.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsult.Location = new System.Drawing.Point(12, 172);
            this.btnconsult.Name = "btnconsult";
            this.btnconsult.Size = new System.Drawing.Size(79, 33);
            this.btnconsult.TabIndex = 7;
            this.btnconsult.Text = "Buscar";
            this.btnconsult.UseVisualStyleBackColor = false;
            this.btnconsult.Click += new System.EventHandler(this.btnconsult_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsult);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnconsult, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtkey, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconsult;
    }
}