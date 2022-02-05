using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Buscador.Modelos;
using Buscador.Vistas;

namespace Buscador.Controladores
{
    class ControladorPrincipal
    {
        Documents docs;
        String rutaDocs;
        Index indice;
        StopWords sw;
        String rutaSW;
        VistaPrincipal vp;

        public ControladorPrincipal(String rutaDocs, String rutaSW) {
            docs = new Documents(rutaDocs);
            this.rutaDocs = rutaDocs;
            sw = new StopWords(rutaSW);
            this.rutaSW = rutaSW;
            indice = new Index(docs, sw);
            vp = new VistaPrincipal();
            //suscribir metodos a los delegados.

        }

        public void hacerVisible() {
            vp.pressBotonExact += new VistaPrincipal.delegateBotonExactMatch(handlerBotonExactMatch);
            vp.pressBotonBest += new VistaPrincipal.delegateBotonBestMatch(handlerBotonBestMatch);
            vp.pressBotonCambiarDocs += new VistaPrincipal.delegateBotonCambiarDocs(handlerBotonCambiarDocs);
            vp.pressBotonCambiarSW += new VistaPrincipal.delegateBotonCambiarSW(handlerBotonCambiarSW);
            vp.ShowDialog();
        }


        void realizarConsultaExact(Object data) {
            String consult = data.ToString();
            List<String> relevantes = quitarStopWords(consult);
            int i = 0;
            List<Par> resultadosConsulta = new List<Par>();
            IndexIndividual r = indice.buscar(relevantes[i]);
            ControladorResultados cr;
            int palabrasPresentesIndice = 0;
            if (r != null){
                palabrasPresentesIndice++;
                resultadosConsulta = r.getListaResults();
                for (i = 1; i < relevantes.Count; i++){
                    r = indice.buscar(relevantes[i]);
                    if (r != null){
                        palabrasPresentesIndice++;
                        resultadosConsulta = intersectarListasPares(resultadosConsulta, r.getListaResults());
                    }
                }
                if (palabrasPresentesIndice == relevantes.Count)
                {
                    cr = new ControladorResultados(resultadosConsulta, docs, consult);
                }
                else {
                    cr = new ControladorResultados(new List<Par>(), docs, consult);
                }
            }
            else{
                 cr = new ControladorResultados(resultadosConsulta, docs, consult);
            }
        }

        void realizarConsultaBest(Object data) {
            String consult = data.ToString();
            List<String> relevantes = quitarStopWords(consult);
            List<Par> resultadosConsulta = new List<Par>();
            IndexIndividual r;
            foreach (String word in relevantes) {
                r = indice.buscar(word);
                if (r != null){
                    resultadosConsulta = reducirResultados(resultadosConsulta, r.getListaResults());
                }
            }
            ControladorResultados cr1 = new ControladorResultados(resultadosConsulta, docs, consult);
        }
        List<Par> reducirResultados(List<Par> res1, List<Par> res2) {
            List<Par> res = new List<Par>();
            int totalFreq=0;
            foreach (Par p in res1) {
                if (contieneDoc(res2, p)){
                    totalFreq = p.getFreqDoc() + buscarFrecuencias(res2, p);
                    res.Add(new Par(p.getIdDoc(), totalFreq));
                    totalFreq = 0;
                }
                else {
                    res.Add(p);
                }
            }
            foreach (Par p in res2){
                if (!contieneDoc(res, p)){
                    res.Add(p);
                }
            }
            return res;
        }

        List<Par> intersectarListasPares(List<Par> res1, List<Par> res2) {
            List<Par> res = new List<Par>();
            int aux;
            foreach (Par p in res1) {
                if (contieneDoc(res2, p)) {
                    aux = buscarFrecuencias(res2, p);
                    res.Add(new Par(p.getIdDoc(), aux + p.getFreqDoc()));
                }
            }
            return res;
        }

        int buscarFrecuencias(List<Par> res, Par p) {
            int contador = 0;
            foreach (Par q in res) {
                if (q.getIdDoc() == p.getIdDoc()) {
                    contador += q.getFreqDoc();
                }
            }
            return contador;
        }

        Boolean contieneDoc(List<Par> res, Par parBuscado) {
            foreach (Par p in res) {
                if (p.getIdDoc() == parBuscado.getIdDoc()) {
                    return true;
                }
            }
            return false;
        }

        private void actualizarDocs() {
            this.docs = new Documents(this.rutaDocs);
            this.indice = new Index(docs, sw);
            vp.mostrarMessageBox("Se ha actualizado la información del indice con los nuevos documentos");
        }
        private void actualizarSW() {
            this.sw = new StopWords(this.rutaSW);
            this.indice = new Index(docs, sw);
            vp.mostrarMessageBox("Se ha actualizado la información de stopwords segun el archivo especificado");
        }

        List<String> quitarStopWords(String consulta) {
            Char[] sep = { ' ' };
            String[] palabras = consulta.Split(sep);
            List<String> res = new List<String>();
            foreach (String palabra in palabras) {
                if (palabra != null && !sw.isStopWord(palabra)) {
                    res.Add(palabra);
                }
            }
            return res;
        }

        void handlerBotonExactMatch(String textoConsultas){
            Char[] sep = { ';' };
            String[] consultas = textoConsultas.Split(sep);
            int l = consultas.Length;
            Thread[] Threads = new Thread[l];
            for(int i = 0; i < l; i++) {
                Threads[i] = new Thread(new ParameterizedThreadStart(realizarConsultaExact));
                Threads[i].Start(consultas[i]);
            }
        }
        void handlerBotonBestMatch(String textoConsultas){
            Char[] sep = { ';' };
            String[] consultas = textoConsultas.Split(sep);
            int l = consultas.Length;
            Thread[] Threads = new Thread[l];
            for (int i = 0; i < l; i++)
            {
                Threads[i] = new Thread(new ParameterizedThreadStart(realizarConsultaBest));
                Threads[i].Start(consultas[i]);
            }
        }
        void handlerBotonCambiarDocs(String ruta)
        {
            this.rutaDocs = ruta;
            Thread T = new Thread(actualizarDocs);
            T.Start();
        }
        void handlerBotonCambiarSW(String ruta)
        {
            this.rutaSW = ruta;
            Thread T = new Thread(actualizarSW);
            T.Start();
        }



    }





}
