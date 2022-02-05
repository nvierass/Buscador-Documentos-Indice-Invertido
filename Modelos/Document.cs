using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class Document{
        public int idDoc;
        public String titulo;
        public String autor;
        public String biblio;
        public String text;

        public Document(int id, String T, String A, String B, String W) {
            idDoc = id;
            titulo = T;
            autor = A;
            biblio = B;
            text = W;
        }

        public int getId() {
            return idDoc;
        }
        public String getTitulo() {
            return titulo;
        }
        public String getAutor() {
            return autor;
        }
        public String getBiblio() {
            return biblio;
        }
        public String getText() {
            return text;
        }


        public override String ToString() {
            return "ID: "+idDoc+"\nTitulo: " + titulo + "\nAutor: " + autor + "\nBibliografia: " + biblio + "\nTexto: " + text;
        }
    }
}
