namespace CasodeEstudio
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpArbol = new System.Windows.Forms.TabPage();
            this.tpGrafo = new System.Windows.Forms.TabPage();
            this.tbElementos = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.lblElementos = new System.Windows.Forms.Label();
            this.tbConexion = new System.Windows.Forms.TextBox();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnMostrarGrafo = new System.Windows.Forms.Button();
            this.lbGrafo = new System.Windows.Forms.ListBox();
            this.tbInicio = new System.Windows.Forms.TextBox();
            this.tbFin = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.lbRuta = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpArbol.SuspendLayout();
            this.tpGrafo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpArbol);
            this.tabControl1.Controls.Add(this.tpGrafo);
            this.tabControl1.Location = new System.Drawing.Point(43, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tpArbol
            // 
            this.tpArbol.Controls.Add(this.lblElementos);
            this.tpArbol.Controls.Add(this.tvArbol);
            this.tpArbol.Controls.Add(this.btnAñadir);
            this.tpArbol.Controls.Add(this.tbElementos);
            this.tpArbol.Location = new System.Drawing.Point(4, 22);
            this.tpArbol.Name = "tpArbol";
            this.tpArbol.Padding = new System.Windows.Forms.Padding(3);
            this.tpArbol.Size = new System.Drawing.Size(486, 402);
            this.tpArbol.TabIndex = 0;
            this.tpArbol.Text = "Árbol";
            this.tpArbol.UseVisualStyleBackColor = true;
            // 
            // tpGrafo
            // 
            this.tpGrafo.Controls.Add(this.lbRuta);
            this.tpGrafo.Controls.Add(this.btnRuta);
            this.tpGrafo.Controls.Add(this.tbFin);
            this.tpGrafo.Controls.Add(this.tbInicio);
            this.tpGrafo.Controls.Add(this.lbGrafo);
            this.tpGrafo.Controls.Add(this.btnMostrarGrafo);
            this.tpGrafo.Controls.Add(this.btnAgregarC);
            this.tpGrafo.Controls.Add(this.tbConexion);
            this.tpGrafo.Location = new System.Drawing.Point(4, 22);
            this.tpGrafo.Name = "tpGrafo";
            this.tpGrafo.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrafo.Size = new System.Drawing.Size(538, 445);
            this.tpGrafo.TabIndex = 1;
            this.tpGrafo.Text = "Grafo";
            this.tpGrafo.UseVisualStyleBackColor = true;
            // 
            // tbElementos
            // 
            this.tbElementos.Location = new System.Drawing.Point(91, 45);
            this.tbElementos.Name = "tbElementos";
            this.tbElementos.Size = new System.Drawing.Size(180, 20);
            this.tbElementos.TabIndex = 1;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(327, 45);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(94, 48);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(39, 84);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(263, 284);
            this.tvArbol.TabIndex = 3;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(26, 48);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(59, 13);
            this.lblElementos.TabIndex = 4;
            this.lblElementos.Text = "Elementos:";
            // 
            // tbConexion
            // 
            this.tbConexion.Location = new System.Drawing.Point(33, 32);
            this.tbConexion.Name = "tbConexion";
            this.tbConexion.Size = new System.Drawing.Size(222, 20);
            this.tbConexion.TabIndex = 0;
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(289, 32);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(91, 44);
            this.btnAgregarC.TabIndex = 1;
            this.btnAgregarC.Text = "Agregar Conexión";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btnMostrarGrafo
            // 
            this.btnMostrarGrafo.Location = new System.Drawing.Point(401, 32);
            this.btnMostrarGrafo.Name = "btnMostrarGrafo";
            this.btnMostrarGrafo.Size = new System.Drawing.Size(103, 44);
            this.btnMostrarGrafo.TabIndex = 2;
            this.btnMostrarGrafo.Text = "Mostrar Conexiones";
            this.btnMostrarGrafo.UseVisualStyleBackColor = true;
            this.btnMostrarGrafo.Click += new System.EventHandler(this.btnMostrarGrafo_Click);
            // 
            // lbGrafo
            // 
            this.lbGrafo.FormattingEnabled = true;
            this.lbGrafo.Location = new System.Drawing.Point(33, 92);
            this.lbGrafo.Name = "lbGrafo";
            this.lbGrafo.Size = new System.Drawing.Size(240, 303);
            this.lbGrafo.TabIndex = 3;
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(302, 117);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(100, 20);
            this.tbInicio.TabIndex = 4;
            // 
            // tbFin
            // 
            this.tbFin.Location = new System.Drawing.Point(302, 153);
            this.tbFin.Name = "tbFin";
            this.tbFin.Size = new System.Drawing.Size(100, 20);
            this.tbFin.TabIndex = 5;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(422, 130);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(64, 33);
            this.btnRuta.TabIndex = 6;
            this.btnRuta.Text = "Mejor ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // lbRuta
            // 
            this.lbRuta.FormattingEnabled = true;
            this.lbRuta.Location = new System.Drawing.Point(302, 205);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(154, 186);
            this.lbRuta.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Innovatec";
            this.tabControl1.ResumeLayout(false);
            this.tpArbol.ResumeLayout(false);
            this.tpArbol.PerformLayout();
            this.tpGrafo.ResumeLayout(false);
            this.tpGrafo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpArbol;
        private System.Windows.Forms.TabPage tpGrafo;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox tbElementos;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.ListBox lbRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox tbFin;
        private System.Windows.Forms.TextBox tbInicio;
        private System.Windows.Forms.ListBox lbGrafo;
        private System.Windows.Forms.Button btnMostrarGrafo;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.TextBox tbConexion;
    }
}

