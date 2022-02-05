using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class Index{
        public List<IndexIndividual> indice;

        public Index(Documents docs,StopWords sw) {
            indice = new List<IndexIndividual>();
            int freq;
            List<Document> listaDocs = docs.getListDocs();
            foreach (Document d in listaDocs) {
                List<String> palabrasDoc = generarPalabrasDoc(d);
                foreach (String palabra in palabrasDoc) {
                    if (!sw.isStopWord(palabra)){
                        if (!contabilizado(palabra, d.getId()))
                        {
                            freq = contar(palabra, palabrasDoc);
                            agregarResult(palabra, d.getId(), freq);
                        }
                    }
                }
            }
        }

        public void agregarResult(String palabra, int id, int freq) {
            IndexIndividual res = buscar(palabra);
            if (res != null){
                res.agregarResultado(id, freq);
            }
            else {
                res = new IndexIndividual(palabra);
                res.agregarResultado(id, freq);
                indice.Add(res);
            }
        }

        public IndexIndividual buscar(String palabra) {
            foreach (IndexIndividual r in indice) {
                if (palabra.Equals(r.getPalabra())) {
                    return r;
                }
            }
            return null;
        }

        private List<String> generarPalabrasDoc(Document t) {
            Char[] sep = { ' ', '.', ',', ';', ':', '-', '_', '/', '(', ')', '=', '+', '-', '*', '%' };
            String total = t.getAutor() + " " + t.getText() + " " + t.getTitulo() + " " + t.getBiblio();
            List<String> res = new List<String>();
            String[] palabras = total.Split(sep);
            foreach (String palabra in palabras) {
                if (palabra != null) {
                    res.Add(palabra);
                }
            }
            return res;
        }

        private Boolean contabilizado(String palabra, int id) {
            IndexIndividual a = buscar(palabra);
            if (a != null){
                List<Par> res = a.getListaResults();
                foreach (Par b in res) {
                    if (b.getIdDoc() == id) {
                        return true;
                    }
                }
            }
            return false;
        }

        private int contar(String palabra, List<String> lista) {
            int counter = 0;
            foreach (String a in lista) {
                if (a.Equals(palabra)) {
                    counter++;
                }
            }
            return counter;
        }
    }
}
