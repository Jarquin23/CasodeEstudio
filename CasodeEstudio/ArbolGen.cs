using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasodeEstudio
{
    public class ArbolGen
    {
        public NodoArbol Raiz { get; private set; }
        public ArbolGen(string nombreRaiz)
        {
            Raiz = new NodoArbol(nombreRaiz);
        }
        private NodoArbol Buscar(NodoArbol actual, string nombre)
        {
            if (actual.Nombre == nombre)
                return actual;
            foreach (var hijo in actual.Hijos)
            {
                var resultado = Buscar(hijo, nombre);
                if (resultado != null)
                    return resultado;
            }
            return null;
        }
        public void Añadir(string padre, string hijo)
        {
            NodoArbol nodoPadre = Buscar(Raiz, padre);
            if (nodoPadre == null)
            {
                MessageBox.Show("El nodo padre no existe.: " + padre);
                return;
            }
            nodoPadre.Hijos.Add(new NodoArbol(hijo));
        }
    }
}
