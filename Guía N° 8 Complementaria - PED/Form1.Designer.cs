
namespace Guía_N__8_Complementaria___PED
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.btnconsult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnadd.Location = new System.Drawing.Point(129, 88);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(156, 80);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Agregar Datos";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnshow.Location = new System.Drawing.Point(489, 200);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(156, 80);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Mostar todos los  Datos";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.ForestGreen;
            this.btndelete.Location = new System.Drawing.Point(129, 200);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(156, 80);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Eliminar Datos";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnupload.Location = new System.Drawing.Point(489, 88);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(156, 80);
            this.btnupload.TabIndex = 3;
            this.btnupload.Text = "Actualizar Datos";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btnconsult
            // 
            this.btnconsult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsult.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsult.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnconsult.Location = new System.Drawing.Point(312, 297);
            this.btnconsult.Name = "btnconsult";
            this.btnconsult.Size = new System.Drawing.Size(156, 80);
            this.btnconsult.TabIndex = 4;
            this.btnconsult.Text = "Consultar Datos";
            this.btnconsult.UseVisualStyleBackColor = false;
            this.btnconsult.Click += new System.EventHandler(this.btnconsult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú Principal";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsult);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnadd);
            this.Name = "App";
            this.Text = "Guía #8 - Complementaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btnconsult;
        private System.Windows.Forms.Label label1;
    }
}

