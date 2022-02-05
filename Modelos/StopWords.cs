using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class StopWords{
        //Atributos
        private List<String> sw;
        //Constructor
        public StopWords(String nombreArchivoSW) {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(nombreArchivoSW);
                String word;
                sw = new List<String>();
                while (sr.Peek() != -1)
                {
                    word = sr.ReadLine();
                    sw.Add(word);
                }
            }
            catch (Exception e){
                Console.WriteLine("Error en la lectura del archivo de stopwords");
                Console.WriteLine(e.Message);
            }
        }

        //Metodos
        public Boolean isStopWord(String word) {
            foreach (String a in this.sw) {
                if (a == word) {
                    return true;
                }
            }
            return false;
        }
        public List<String> getSWList() {
            return this.sw;
        }
    }
}
