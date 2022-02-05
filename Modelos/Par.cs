using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador.Modelos
{
    public class Par
    {
        int id;
        int freq;

        public Par(int id, int freq) {
            this.id = id;
            this.freq = freq;
        }

        public int getIdDoc() {
            return id;
        }
        public int getFreqDoc() {
            return freq;
        }
    }
}
