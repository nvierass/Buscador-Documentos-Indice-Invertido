using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class Documents{
        //Atributos
        public List<Document> docs;
        //Constructor
        public Documents(String nombreArchivoDocumentos) {
            try{
                Char[] sep = { ' ', '.', ',', ';', ':', '-', '_', '/', '(', ')', '=', '+', '-', '*', '%' };
                System.IO.StreamReader sr = new System.IO.StreamReader(nombreArchivoDocumentos);
                docs = new List<Document>();
                int id = 0;
                String titulo = "", autor = "", biblio = "", texto = "";
                String linea = sr.ReadLine();
                while (!sr.EndOfStream) {
                    if (isIdLine(linea)) {
                        Document nuevo = new Document(id, titulo, autor, biblio, texto);
                        docs.Add(nuevo);
                        id = idLine(linea);
                        linea= sr.ReadLine();
                        titulo = ""; autor = ""; biblio = ""; texto = "";
                    }
                    if (linea == ".T") {
                        linea = sr.ReadLine();
                        while (linea != ".A" && !isIdLine(linea) && !sr.EndOfStream) {
                            titulo = titulo + " " + linea;
                            linea = sr.ReadLine();
                        }
                    }
                    if (linea == ".A"){
                        linea = sr.ReadLine();
                        while (linea != ".B" && !isIdLine(linea) && !sr.EndOfStream)
                        {
                            autor = autor + " " + linea;
                            linea = sr.ReadLine();
                        }
                    }
                    if (linea == ".B"){
                        linea = sr.ReadLine();
                        while (linea != ".W" && !isIdLine(linea) && !sr.EndOfStream){
                            biblio = biblio + " " + linea;
                            linea = sr.ReadLine();
                        }
                    }
                    if (linea == ".W"){
                        linea = sr.ReadLine();
                        while (!isIdLine(linea) && sr.Peek()!=-1){
                            texto = texto + " " + linea;
                            linea = sr.ReadLine();
                        }
                    }
                }
                texto = texto+ " "+ sr.ReadLine();
                Document ultimo = new Document(id, titulo, autor, biblio, texto);
                docs.Add(ultimo);
                docs.RemoveAt(0);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la lectura del archivo de documentos");
                Console.WriteLine(e.Message);
            }
        }





        //Metodos

        Boolean isIdLine(String line) {
            Char[] separator = {' '};
            String[] words = line.Split(separator);
            if(words[0].Equals(".I")){
                return true;
            }
            return false;
        }
        int idLine(String line){
            Char[] separator = { ' ' };
            String[] words = line.Split(separator);
            return Int32.Parse(words[1]);
        }

        public Document getDoc(int id) {
            foreach (Document d in docs) {
                if (d.getId() == id) {
                    return d;
                }
            }
            return null;
        }

        public List<Document> getListDocs() {
            return docs;
        }
    }
}
