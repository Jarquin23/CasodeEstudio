using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeEstudio
{
    public class NodoArbol
    {
        public string Nombre { get; set; }
        public List<NodoArbol> Hijos { get; set; }
        public NodoArbol(string nombre)
        {
            Nombre = nombre;
            Hijos = new List<NodoArbol>();
        }
    }
}
