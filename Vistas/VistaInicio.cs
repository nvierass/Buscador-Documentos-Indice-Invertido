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
    public partial class VistaInicio : Form
    {
        public delegate void delegateBotonContinuar(String rutaDocs,String rutaSW);
        public event delegateBotonContinuar pressBoton;
        public VistaInicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fd.FilterIndex = 1;
            fd.Multiselect = false;
            fd.ShowDialog();
            setRutaSeleccionada2(fd.FileName);
        }

        private void botonExaminar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fd.FilterIndex = 1;
            fd.Multiselect = false;
            fd.ShowDialog();
            setRutaSeleccionada1(fd.FileName);

        }
        private void setRutaSeleccionada1(String text) {
            rutaSeleccionadaText.Text = text;
        }
        private void setRutaSeleccionada2(String text) {
            rutaSeleccionadaSW.Text = text;
        }

        private void botonContinuar_Click(object sender, EventArgs e)
        {
            if (rutaSeleccionadaSW.Text != "" && rutaSeleccionadaText.Text != "")
            {
                if (pressBoton != null)
                {
                    pressBoton(rutaSeleccionadaText.Text, rutaSeleccionadaSW.Text);
                }
            }
            else {
                labelAviso.Text ="No ha seleccionado ambos archivos, por favor seleccionelos e intente nuevamente";
            }
        }


    }
}
