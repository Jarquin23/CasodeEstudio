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
            string texto = tbConexion.Text;
            if (!texto.Contains(","))
            {
                MessageBox.Show("Formato inválido. Use: Origen,Destino,Distancia");
                return;
            }
            var partes = texto.Split(',');
            if (partes.Length != 3)
            {
                MessageBox.Show("Debe utilizar el formato: A,B,120");
                return;
            }
            string origen = partes[0].Trim();
            string destino = partes[1].Trim();
            int distancia;

            if (!int.TryParse(partes[2].Trim(), out distancia))
            {
                MessageBox.Show("La distancia debe ser un número entero.");
                return;
            }
            grafo.AgregarConexion(origen, destino, distancia);
            MessageBox.Show("Conexión Agregada");
            tbConexion.Clear();
        }

        private void btnMostrarGrafo_Click(object sender, EventArgs e)
        {
            lbGrafo.Items.Clear();
            foreach (var nodo in grafo.ObtenerMapa())
            {
                foreach (var (dest, dist) in nodo.Value)
                {
                    lbGrafo.Items.Add($"{nodo.Key} -> {dest} ({dist} m)");
                }
            }
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string inicio = tbInicio.Text.Trim();
            string fin = tbFin.Text.Trim();
            if (inicio == "" || fin == "")
            {
                MessageBox.Show("Debe ingresar un nodo inicial y final.");
                return;
            }
            var ruta = grafo.MejorRuta(inicio, fin);
            lbRuta.Items.Clear();
            foreach (var p in ruta)
                lbRuta.Items.Add(p);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
