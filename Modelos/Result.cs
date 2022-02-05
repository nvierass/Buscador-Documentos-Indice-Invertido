using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class Result{
        int coincidencias;
        Document doc;

        public Result(int coincidencias, Document doc) {
            this.coincidencias = coincidencias;
            this.doc = doc;
        }

        public int getCoincidencias() {
            return coincidencias;
        }
        public Document getDocument() {
            return doc;
        }
    }
}
