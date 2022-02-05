using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buscador.Vistas;


namespace Buscador.Controladores
{
    class ControladorInicio{
        VistaInicio vi;
        ControladorPrincipal cp;
        String rutaDocs;
        String rutaSW;
        public ControladorInicio() {
            vi = new VistaInicio();
            vi.pressBoton += new VistaInicio.delegateBotonContinuar(handlerBotonContinuar);
            vi.ShowDialog();
        }

        void handlerBotonContinuar(String rutaDocs, String rutaSW) {
            this.rutaDocs = rutaDocs;
            this.rutaSW = rutaSW;
            cp = new ControladorPrincipal(rutaDocs, rutaSW);
            cp.hacerVisible();
        }
    }
}
