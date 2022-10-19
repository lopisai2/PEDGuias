
namespace Guia_N__11___PED
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
            this.components = new System.ComponentModel.Container();
            this.pizarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CMSCrearVertice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndeletearco = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBArco = new System.Windows.Forms.ComboBox();
            this.btndeletever = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBVertice = new System.Windows.Forms.ComboBox();
            this.CBNodoPartida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnprofundidad = new System.Windows.Forms.Button();
            this.btnanchura = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtvertice = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btndistancia = new System.Windows.Forms.Button();
            this.lblrespuestacion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pizarra.SuspendLayout();
            this.CMSCrearVertice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pizarra
            // 
            this.pizarra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pizarra.Controls.Add(this.dataGridView1);
            this.pizarra.Location = new System.Drawing.Point(343, 94);
            this.pizarra.Name = "pizarra";
            this.pizarra.Size = new System.Drawing.Size(909, 556);
            this.pizarra.TabIndex = 0;
            this.pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.pizarra_Paint);
            this.pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseDown);
            this.pizarra.MouseLeave += new System.EventHandler(this.pizarra_MouseLeave);
            this.pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseMove);
            this.pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pizarra_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulador de Grafos";
            // 
            // CMSCrearVertice
            // 
            this.CMSCrearVertice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.CMSCrearVertice.Name = "CMSCrearVertice";
            this.CMSCrearVertice.Size = new System.Drawing.Size(156, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Nuevo Vertice";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem2.Text = "Eliminar Arco";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem3.Text = "Eliminar Vertice";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndeletearco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CBArco);
            this.groupBox1.Controls.Add(this.btndeletever);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBVertice);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btndeletearco
            // 
            this.btndeletearco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletearco.Location = new System.Drawing.Point(226, 76);
            this.btndeletearco.Name = "btndeletearco";
            this.btndeletearco.Size = new System.Drawing.Size(75, 23);
            this.btndeletearco.TabIndex = 7;
            this.btndeletearco.Text = "Eliminar";
            this.btndeletearco.UseVisualStyleBackColor = true;
            this.btndeletearco.Click += new System.EventHandler(this.btndeletearco_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arco";
            // 
            // CBArco
            // 
            this.CBArco.FormattingEnabled = true;
            this.CBArco.Location = new System.Drawing.Point(76, 79);
            this.CBArco.Name = "CBArco";
            this.CBArco.Size = new System.Drawing.Size(84, 21);
            this.CBArco.TabIndex = 5;
            // 
            // btndeletever
            // 
            this.btndeletever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletever.Location = new System.Drawing.Point(226, 30);
            this.btndeletever.Name = "btndeletever";
            this.btndeletever.Size = new System.Drawing.Size(75, 23);
            this.btndeletever.TabIndex = 4;
            this.btndeletever.Text = "Eliminar";
            this.btndeletever.UseVisualStyleBackColor = true;
            this.btndeletever.Click += new System.EventHandler(this.btndeletever_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vertice";
            // 
            // CBVertice
            // 
            this.CBVertice.FormattingEnabled = true;
            this.CBVertice.Location = new System.Drawing.Point(76, 30);
            this.CBVertice.Name = "CBVertice";
            this.CBVertice.Size = new System.Drawing.Size(84, 21);
            this.CBVertice.TabIndex = 0;
            // 
            // CBNodoPartida
            // 
            this.CBNodoPartida.FormattingEnabled = true;
            this.CBNodoPartida.Location = new System.Drawing.Point(115, 30);
            this.CBNodoPartida.Name = "CBNodoPartida";
            this.CBNodoPartida.Size = new System.Drawing.Size(84, 21);
            this.CBNodoPartida.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nodo de partida: ";
            // 
            // btnprofundidad
            // 
            this.btnprofundidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofundidad.Location = new System.Drawing.Point(23, 72);
            this.btnprofundidad.Name = "btnprofundidad";
            this.btnprofundidad.Size = new System.Drawing.Size(75, 23);
            this.btnprofundidad.TabIndex = 4;
            this.btnprofundidad.Text = "Profundidad";
            this.btnprofundidad.UseVisualStyleBackColor = true;
            this.btnprofundidad.Click += new System.EventHandler(this.btnprofundidad_Click);
            // 
            // btnanchura
            // 
            this.btnanchura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanchura.Location = new System.Drawing.Point(226, 72);
            this.btnanchura.Name = "btnanchura";
            this.btnanchura.Size = new System.Drawing.Size(75, 23);
            this.btnanchura.TabIndex = 7;
            this.btnanchura.Text = "Anchura";
            this.btnanchura.UseVisualStyleBackColor = true;
            this.btnanchura.Click += new System.EventHandler(this.btnanchura_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnanchura);
            this.groupBox2.Controls.Add(this.btnprofundidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CBNodoPartida);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtvertice);
            this.groupBox3.Controls.Add(this.btnsearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 73);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // txtvertice
            // 
            this.txtvertice.Location = new System.Drawing.Point(99, 27);
            this.txtvertice.Name = "txtvertice";
            this.txtvertice.Size = new System.Drawing.Size(100, 20);
            this.txtvertice.TabIndex = 11;
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Location = new System.Drawing.Point(228, 25);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Buscar";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vértice:";
            // 
            // btndistancia
            // 
            this.btndistancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndistancia.Location = new System.Drawing.Point(112, 522);
            this.btndistancia.Name = "btndistancia";
            this.btndistancia.Size = new System.Drawing.Size(113, 67);
            this.btndistancia.TabIndex = 4;
            this.btndistancia.Text = "Distancia";
            this.btndistancia.UseVisualStyleBackColor = true;
            this.btndistancia.Click += new System.EventHandler(this.btndistancia_Click);
            // 
            // lblrespuestacion
            // 
            this.lblrespuestacion.AutoSize = true;
            this.lblrespuestacion.Location = new System.Drawing.Point(103, 637);
            this.lblrespuestacion.Name = "lblrespuestacion";
            this.lblrespuestacion.Size = new System.Drawing.Size(0, 13);
            this.lblrespuestacion.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblrespuestacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btndistancia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizarra);
            this.Name = "App";
            this.Text = "Guía N°11 - PED";
            this.Load += new System.EventHandler(this.App_Load);
            this.pizarra.ResumeLayout(false);
            this.CMSCrearVertice.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pizarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CMSCrearVertice;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndeletearco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBArco;
        private System.Windows.Forms.Button btndeletever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBVertice;
        private System.Windows.Forms.ComboBox CBNodoPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnprofundidad;
        private System.Windows.Forms.Button btnanchura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndistancia;
        private System.Windows.Forms.TextBox txtvertice;
        private System.Windows.Forms.Label lblrespuestacion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

