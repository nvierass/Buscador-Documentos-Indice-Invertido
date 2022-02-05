using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buscador.Modelos;

namespace Buscador.Vistas
{
    public partial class VistaResultados : Form
    {
        List<Result> res;
        String consulta;
        int indexPagina;
        int indexMaxPagina;
        public VistaResultados(List<Result> resultados,String cons) {
            InitializeComponent();
            res = resultados;
            consulta = cons;
            indexPagina = 0;
            indexMaxPagina = (res.Count - 1) / 10;
            labelConsulta.Text = cons;
            labelCantidad.Text = resultados.Count.ToString();
            botonAnterior.Enabled = false;
            if (resultados.Count < 10) {
                botonSiguiente.Enabled = false;
            }
            rellenarVista(0);
        }

        private void rellenarVista(int pagina) {
            rellenarFrecuencias(pagina);
            rellenarTitulos(pagina);
            rellenarIndex(pagina);
        }
        private void rellenarIndex(int pagina) {
            label2.Text = (pagina * 10 + 1).ToString() + ".- Coincidencias: ";
            label3.Text = (pagina * 10 + 2).ToString() + ".- Coincidencias: ";
            label4.Text = (pagina * 10 + 3).ToString() + ".- Coincidencias: ";
            label5.Text = (pagina * 10 + 4).ToString() + ".- Coincidencias: ";
            label6.Text = (pagina * 10 + 5).ToString() + ".- Coincidencias: ";
            label7.Text = (pagina * 10 + 6).ToString() + ".- Coincidencias: ";
            label8.Text = (pagina * 10 + 7).ToString() + ".- Coincidencias: ";
            label9.Text = (pagina * 10 + 8).ToString() + ".- Coincidencias: ";
            label10.Text = (pagina * 10 + 9).ToString() + ".- Coincidencias: ";
            label11.Text = (pagina * 10 + 10).ToString() + ".- Coincidencias: ";

        }
        private void rellenarFrecuencias(int pagina) {
            if (pagina * 10 + 0 < res.Count) { freq1.Text = res[pagina * 10 + 0].getCoincidencias().ToString();}
            if (pagina * 10 + 1 < res.Count) { freq2.Text = res[pagina * 10 + 1].getCoincidencias().ToString();}
            if (pagina * 10 + 2 < res.Count) { freq3.Text = res[pagina * 10 + 2].getCoincidencias().ToString();}
            if (pagina * 10 + 3 < res.Count) { freq4.Text = res[pagina * 10 + 3].getCoincidencias().ToString();}
            if (pagina * 10 + 4 < res.Count) { freq5.Text = res[pagina * 10 + 4].getCoincidencias().ToString();}
            if (pagina * 10 + 5 < res.Count) { freq6.Text = res[pagina * 10 + 5].getCoincidencias().ToString();}
            if (pagina * 10 + 6 < res.Count) { freq7.Text = res[pagina * 10 + 6].getCoincidencias().ToString();}
            if (pagina * 10 + 7 < res.Count) { freq8.Text = res[pagina * 10 + 7].getCoincidencias().ToString();}
            if (pagina * 10 + 8 < res.Count) { freq9.Text = res[pagina * 10 + 8].getCoincidencias().ToString();}
            if (pagina * 10 + 9 < res.Count) { freq10.Text = res[pagina * 10 + 9].getCoincidencias().ToString();}
        }
        private void rellenarTitulos(int pagina) {
            if (pagina * 10 + 0 < res.Count) { labelTitulo1.Text = "ID: " + res[pagina + 0].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 0].getDocument().getTitulo(); }
            if (pagina * 10 + 1 < res.Count) { labelTitulo2.Text = "ID: " + res[pagina + 1].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 1].getDocument().getTitulo(); }
            if (pagina * 10 + 2 < res.Count) { labelTitulo3.Text = "ID: " + res[pagina + 2].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 2].getDocument().getTitulo(); }
            if (pagina * 10 + 3 < res.Count) { labelTitulo4.Text = "ID: " + res[pagina + 3].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 3].getDocument().getTitulo(); }
            if (pagina * 10 + 4 < res.Count) { labelTitulo5.Text = "ID: " + res[pagina + 4].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 4].getDocument().getTitulo(); }
            if (pagina * 10 + 5 < res.Count) { labelTitulo6.Text = "ID: " + res[pagina + 5].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 5].getDocument().getTitulo(); }
            if (pagina * 10 + 6 < res.Count) { labelTitulo7.Text = "ID: " + res[pagina + 6].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 6].getDocument().getTitulo(); }
            if (pagina * 10 + 7 < res.Count) { labelTitulo8.Text = "ID: " + res[pagina + 7].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 7].getDocument().getTitulo(); }
            if (pagina * 10 + 8 < res.Count) { labelTitulo9.Text = "ID: " + res[pagina + 8].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 8].getDocument().getTitulo(); }
            if (pagina * 10 + 9 < res.Count) { labelTitulo10.Text = "ID: " + res[pagina + 9].getDocument().getId().ToString() + " Titulo: " + res[pagina * 10 + 9].getDocument().getTitulo(); }
        }

        private void limpiarVista() {
            labelTitulo1.Text = "";
            labelTitulo2.Text = "";
            labelTitulo3.Text = "";
            labelTitulo4.Text = "";
            labelTitulo5.Text = "";
            labelTitulo6.Text = "";
            labelTitulo7.Text = "";
            labelTitulo8.Text = "";
            labelTitulo9.Text = "";
            labelTitulo10.Text = "";
            freq1.Text = "";
            freq2.Text = "";
            freq3.Text = "";
            freq4.Text = "";
            freq5.Text = "";
            freq6.Text = "";
            freq7.Text = "";
            freq8.Text = "";
            freq9.Text = "";
            freq10.Text = "";

        }
        
        private void botonSiguiente_Click(object sender, EventArgs e){
            if (indexPagina == indexMaxPagina - 1) {
                botonSiguiente.Enabled = false;
            }
            indexPagina++;
            botonAnterior.Enabled = true;
            limpiarVista();
            rellenarVista(indexPagina);
        }

        private void botonAnterior_Click(object sender, EventArgs e){
            if (indexPagina == 1) {
                botonAnterior.Enabled = false;
            }
            indexPagina--;
            botonSiguiente.Enabled = true;
            limpiarVista();
            rellenarVista(indexPagina);
        }

        private void botonRes1_Click(object sender, EventArgs e)
        {
            if(indexPagina * 10 < res.Count) { MessageBox.Show(res[indexPagina * 10 ].getDocument().ToString()); }
        }

        private void botonRes2_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 1 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 1].getDocument().ToString()); }
        }

        private void botonRes3_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 2< res.Count ) { MessageBox.Show(res[indexPagina * 10 + 2].getDocument().ToString()); }
        }

        private void botonRes4_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 3 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 3].getDocument().ToString()); }
        }

        private void botonRes5_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 4 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 4].getDocument().ToString()); }
        }

        private void botonRes6_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 5 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 5].getDocument().ToString()); }
        }

        private void botonRes7_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 6 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 6].getDocument().ToString()); }
        }

        private void botonRes8_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 7 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 7].getDocument().ToString()); }
        }

        private void botonRes9_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 8 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 8].getDocument().ToString()); }
        }

        private void botonRes10_Click(object sender, EventArgs e)
        {
            if (indexPagina * 10 + 9 < res.Count) { MessageBox.Show(res[indexPagina * 10 + 9].getDocument().ToString()); }
        }
    }
}

    
