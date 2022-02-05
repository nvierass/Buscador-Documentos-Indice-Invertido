using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buscador.Modelos;
using Buscador.Vistas;

namespace Buscador.Controladores
{
    class ControladorResultados
    {
        List<Result> resultados;
        VistaResultados vr;

        public ControladorResultados(List<Par> res,Documents docs,String consulta) {
            res = ordenarListaResultado(res);
            List<Document> documentosResultados = buscarDocumentos(res,docs);
            resultados = new List<Result>();
            for (int i = 0; i < res.Count; i++) {
                resultados.Add(new Result(res[i].getFreqDoc(), documentosResultados[i]));
            }
            vr = new VistaResultados(resultados,consulta);
            hacerVisible();
        }

        private List<Par> ordenarListaResultado(List<Par> res) {
            for (int i = 0; i < res.Count; i++) {
                for (int j = res.Count-1; j > i; j--) {
                    if (res[j].getFreqDoc() >  res[j - 1].getFreqDoc()) {
                        Par aux = res[j - 1];
                        res[j - 1] = res[j];
                        res[j] = aux;
                    }
                }
            }
            return res;
        }
        private List<Document> buscarDocumentos(List<Par> res,Documents docs) {
            List<Document> resultado = new List<Document>();
            foreach (Par p in res) {
                Document doc = docs.getDoc(p.getIdDoc());
                resultado.Add(doc);
            }
            return resultado;
        }

        public void hacerVisible() {
            vr.ShowDialog();
        }
    }
}
