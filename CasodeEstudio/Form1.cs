using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasodeEstudio
{
    public partial class Form1 : Form
    {
        ArbolGen arbol;
        private Grafo grafo = new Grafo();

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolGen("Innovatec");
            ActualizarTreeView();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (!tbElementos.Text.Contains(","))
            {
                MessageBox.Show("Debe hacer uso del formato Padre,Hijo");
                return;
            }
            string[] partes = tbElementos.Text.Split(',');
            if (partes.Length != 2)
            {
                MessageBox.Show("Debe hacer uso del formato Padre,Hijo");
                return;
            }
            string padre = partes[0].Trim();
            string hijo = partes[1].Trim();
            arbol.Añadir(padre, hijo);
            tbElementos.Clear();
            ActualizarTreeView();
        }

        private void ActualizarTreeView()
        {
            tvArbol.Nodes.Clear();
            TreeNode raiz = CrearNodo(arbol.Raiz);
            tvArbol.Nodes.Add(raiz);
        }

        private TreeNode CrearNodo(NodoArbol nodo)
        {
            TreeNode nodoVisual = new TreeNode(nodo.Nombre);
            foreach (var hijo in nodo.Hijos)
            {
                nodoVisual.Nodes.Add(CrearNodo(hijo));
            }
            return nodoVisual;
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            
        }
    }
}
