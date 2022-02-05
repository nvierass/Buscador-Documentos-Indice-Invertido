using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class IndexIndividual {

        String palabra;
        List<Par> listaPares;

        public IndexIndividual(String word) {
            palabra = word;
            listaPares = new List<Par>();
        }

        public String getPalabra() {
            return palabra;
        }
        public List<Par> getListaResults() {
            return listaPares;
        }

        public void agregarResultado(int id, int freq) {
            Par nuevo = new Par(id, freq);
            listaPares.Add(nuevo);
        }
       

    }
}
