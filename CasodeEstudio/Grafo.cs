using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasodeEstudio
{
    public class Grafo
    {
        private Dictionary<string, List<(string destino, int distancia)>> mapa;
        public Grafo()
        {
            mapa = new Dictionary<string, List<(string destino, int distancia)>>();
        }
        public void AgregarNodo(string nombre)
        {
            if (!mapa.ContainsKey(nombre))
                mapa[nombre] = new List<(string, int)>();
        }
        public void AgregarConexion(string origen, string destino, int distancia)
        {
            AgregarNodo(origen);
            AgregarNodo(destino);

            mapa[origen].Add((destino, distancia));
            mapa[destino].Add((origen, distancia));
        }
        public Dictionary<string, List<(string destino, int distancia)>> ObtenerMapa()
        {
            return mapa;
        }
        public List<string> MejorRuta(string inicio, string fin)
        {
            var dist = new Dictionary<string, int>();
            var prev = new Dictionary<string, string>();
            var nodos = new List<string>(mapa.Keys);
            foreach (var nodo in nodos)
            {
                dist[nodo] = int.MaxValue;
                prev[nodo] = null;
            }
            dist[inicio] = 0;
            while (nodos.Count > 0)
            {
                string u = nodos.OrderBy(n => dist[n]).First();
                nodos.Remove(u);
                if (u == fin)
                    break;
                foreach (var (v, distancia) in mapa[u])
                {
                    int alt = dist[u] + distancia;
                    if (alt < dist[v])
                    {
                        dist[v] = alt;
                        prev[v] = u;
                    }
                }
            }
            var ruta = new List<string>();
            string actual = fin;
            while (actual != null)
            {
                ruta.Add(actual);
                actual = prev[actual];
            }
            ruta.Reverse();
            return ruta;
        }
    }
}
