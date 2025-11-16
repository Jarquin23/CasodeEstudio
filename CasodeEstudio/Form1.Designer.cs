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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpArbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpArbol);
            this.tabControl1.Controls.Add(this.tpGrafo);
            this.tabControl1.Location = new System.Drawing.Point(43, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tpArbol
            // 
            this.tpArbol.Controls.Add(this.label1);
            this.tpArbol.Location = new System.Drawing.Point(4, 22);
            this.tpArbol.Name = "tpArbol";
            this.tpArbol.Padding = new System.Windows.Forms.Padding(3);
            this.tpArbol.Size = new System.Drawing.Size(387, 407);
            this.tpArbol.TabIndex = 0;
            this.tpArbol.Text = "Árbol";
            this.tpArbol.UseVisualStyleBackColor = true;
            // 
            // tpGrafo
            // 
            this.tpGrafo.Location = new System.Drawing.Point(4, 22);
            this.tpGrafo.Name = "tpGrafo";
            this.tpGrafo.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrafo.Size = new System.Drawing.Size(387, 407);
            this.tpGrafo.TabIndex = 1;
            this.tpGrafo.Text = "Grafo";
            this.tpGrafo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Innovatec";
            this.tabControl1.ResumeLayout(false);
            this.tpArbol.ResumeLayout(false);
            this.tpArbol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpArbol;
        private System.Windows.Forms.TabPage tpGrafo;
        private System.Windows.Forms.Label label1;
    }
}

