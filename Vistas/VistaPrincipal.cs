using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador.Vistas
{
    public partial class VistaPrincipal : Form
    {
        public delegate void delegateBotonExactMatch(String consulta);
        public delegate void delegateBotonBestMatch(String consulta);
        public delegate void delegateBotonCambiarDocs(String ruta);
        public delegate void delegateBotonCambiarSW(String ruta);
        public event delegateBotonExactMatch pressBotonExact;
        public event delegateBotonBestMatch pressBotonBest;
        public event delegateBotonCambiarDocs pressBotonCambiarDocs;
        public event delegateBotonCambiarSW pressBotonCambiarSW;
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void botonCambiarIndice_Click(object sender, EventArgs e){
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fd.FilterIndex = 1;
            fd.Multiselect = false;
            fd.ShowDialog();
            labelRutaDocumentos.Text = "Archivo seleccionado: " + fd.FileName;
            if (pressBotonCambiarDocs != null) {
                pressBotonCambiarDocs(fd.FileName);
            }
        }

        private void botonExactMatch_Click(object sender, EventArgs e){
            if (textBoxConsulta.Text == ""){
                MessageBox.Show("No se ha ingresado ninguna consulta, intente nuevamente");
            }
            else{
                if (pressBotonExact != null){
                    pressBotonExact(textBoxConsulta.Text);
                }
            }
        }

        private void botonBestMatch_Click(object sender, EventArgs e){
            if (textBoxConsulta.Text == ""){
                MessageBox.Show("No se ha ingresado ninguna consulta, intente nuevamente");
            }
            else{
                if (pressBotonBest != null){
                    pressBotonBest(textBoxConsulta.Text);
                }
            }
        }

        private void botonCambiarStopWords_Click(object sender, EventArgs e){
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fd.FilterIndex = 1;
            fd.Multiselect = false;
            fd.ShowDialog();
            labelRutaSW.Text = "Archivo seleccionado: " + fd.FileName;
            if (pressBotonCambiarSW != null)
            {
                pressBotonCambiarSW(fd.FileName);
            }

        }


        public void mostrarMessageBox(String mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
