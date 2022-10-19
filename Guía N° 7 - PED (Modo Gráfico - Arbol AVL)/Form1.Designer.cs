
namespace Guía_N__7___PED
{
    partial class Original
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.rbtnpost = new System.Windows.Forms.RadioButton();
            this.rbtnin = new System.Windows.Forms.RadioButton();
            this.rbtnpre = new System.Windows.Forms.RadioButton();
            this.lblaltura = new System.Windows.Forms.Label();
            this.errorcito = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblalturanodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Location = new System.Drawing.Point(588, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(42, 190);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 27);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Salir";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(42, 157);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 27);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Eliminar Dato";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(42, 124);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(119, 27);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Buscar Dato";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(42, 91);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(119, 27);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Agregar Dato\r\n";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(42, 46);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(119, 20);
            this.txt1.TabIndex = 4;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.rbtnpost);
            this.groupBox2.Controls.Add(this.rbtnin);
            this.groupBox2.Controls.Add(this.rbtnpre);
            this.groupBox2.Location = new System.Drawing.Point(89, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Orden";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(6, 43);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(467, 20);
            this.txt2.TabIndex = 3;
            // 
            // rbtnpost
            // 
            this.rbtnpost.AutoSize = true;
            this.rbtnpost.Location = new System.Drawing.Point(388, 20);
            this.rbtnpost.Name = "rbtnpost";
            this.rbtnpost.Size = new System.Drawing.Size(75, 17);
            this.rbtnpost.TabIndex = 2;
            this.rbtnpost.TabStop = true;
            this.rbtnpost.Text = "PostOrden";
            this.rbtnpost.UseVisualStyleBackColor = true;
            this.rbtnpost.CheckedChanged += new System.EventHandler(this.rbtnpost_CheckedChanged);
            // 
            // rbtnin
            // 
            this.rbtnin.AutoSize = true;
            this.rbtnin.Location = new System.Drawing.Point(196, 20);
            this.rbtnin.Name = "rbtnin";
            this.rbtnin.Size = new System.Drawing.Size(67, 17);
            this.rbtnin.TabIndex = 1;
            this.rbtnin.TabStop = true;
            this.rbtnin.Text = "EnOrden\r\n";
            this.rbtnin.UseVisualStyleBackColor = true;
            this.rbtnin.CheckedChanged += new System.EventHandler(this.rbtnin_CheckedChanged);
            // 
            // rbtnpre
            // 
            this.rbtnpre.AutoSize = true;
            this.rbtnpre.Location = new System.Drawing.Point(20, 20);
            this.rbtnpre.Name = "rbtnpre";
            this.rbtnpre.Size = new System.Drawing.Size(70, 17);
            this.rbtnpre.TabIndex = 0;
            this.rbtnpre.TabStop = true;
            this.rbtnpre.Text = "PreOrden";
            this.rbtnpre.UseVisualStyleBackColor = true;
            this.rbtnpre.CheckedChanged += new System.EventHandler(this.rbtnpre_CheckedChanged);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(681, 24);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(78, 13);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura del Arbol";
            // 
            // errorcito
            // 
            this.errorcito.ContainerControl = this;
            // 
            // lblalturanodo
            // 
            this.lblalturanodo.AutoSize = true;
            this.lblalturanodo.Location = new System.Drawing.Point(607, 366);
            this.lblalturanodo.Name = "lblalturanodo";
            this.lblalturanodo.Size = new System.Drawing.Size(13, 13);
            this.lblalturanodo.TabIndex = 3;
            this.lblalturanodo.Text = "0";
            this.lblalturanodo.Visible = false;
            this.lblalturanodo.Click += new System.EventHandler(this.lblalturanodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Último tipo de Rotación al Insertar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura del Arbol:";
            // 
            // Original
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblalturanodo);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Original";
            this.Text = "Arbol AVL";
            this.Load += new System.EventHandler(this.Original_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Original_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton rbtnpost;
        private System.Windows.Forms.RadioButton rbtnin;
        private System.Windows.Forms.RadioButton rbtnpre;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.ErrorProvider errorcito;
        private System.Windows.Forms.Label lblalturanodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

