namespace Buscador.Vistas
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonExactMatch = new System.Windows.Forms.Button();
            this.botonBestMatch = new System.Windows.Forms.Button();
            this.botonCambiarIndice = new System.Windows.Forms.Button();
            this.botonCambiarStopWords = new System.Windows.Forms.Button();
            this.labelRutaDocumentos = new System.Windows.Forms.Label();
            this.labelRutaSW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(25, 61);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(490, 20);
            this.textBoxConsulta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese la consulta a realizar en el siguiente cuadro de texto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "( si desea realizar mas de una consulta, separelas con el caracter \";\" )";
            // 
            // botonExactMatch
            // 
            this.botonExactMatch.Location = new System.Drawing.Point(25, 98);
            this.botonExactMatch.Name = "botonExactMatch";
            this.botonExactMatch.Size = new System.Drawing.Size(183, 23);
            this.botonExactMatch.TabIndex = 6;
            this.botonExactMatch.Text = "Buscar Exact Match";
            this.botonExactMatch.UseVisualStyleBackColor = true;
            this.botonExactMatch.Click += new System.EventHandler(this.botonExactMatch_Click);
            // 
            // botonBestMatch
            // 
            this.botonBestMatch.Location = new System.Drawing.Point(239, 98);
            this.botonBestMatch.Name = "botonBestMatch";
            this.botonBestMatch.Size = new System.Drawing.Size(183, 23);
            this.botonBestMatch.TabIndex = 7;
            this.botonBestMatch.Text = "Buscar Best Match";
            this.botonBestMatch.UseVisualStyleBackColor = true;
            this.botonBestMatch.Click += new System.EventHandler(this.botonBestMatch_Click);
            // 
            // botonCambiarIndice
            // 
            this.botonCambiarIndice.Location = new System.Drawing.Point(25, 144);
            this.botonCambiarIndice.Name = "botonCambiarIndice";
            this.botonCambiarIndice.Size = new System.Drawing.Size(183, 23);
            this.botonCambiarIndice.TabIndex = 8;
            this.botonCambiarIndice.Text = "Cambiar colección de documentos";
            this.botonCambiarIndice.UseVisualStyleBackColor = true;
            this.botonCambiarIndice.Click += new System.EventHandler(this.botonCambiarIndice_Click);
            // 
            // botonCambiarStopWords
            // 
            this.botonCambiarStopWords.Location = new System.Drawing.Point(25, 205);
            this.botonCambiarStopWords.Name = "botonCambiarStopWords";
            this.botonCambiarStopWords.Size = new System.Drawing.Size(183, 23);
            this.botonCambiarStopWords.TabIndex = 9;
            this.botonCambiarStopWords.Text = "Cambiar lista de stopwords";
            this.botonCambiarStopWords.UseVisualStyleBackColor = true;
            this.botonCambiarStopWords.Click += new System.EventHandler(this.botonCambiarStopWords_Click);
            // 
            // labelRutaDocumentos
            // 
            this.labelRutaDocumentos.AutoSize = true;
            this.labelRutaDocumentos.Location = new System.Drawing.Point(22, 180);
            this.labelRutaDocumentos.Name = "labelRutaDocumentos";
            this.labelRutaDocumentos.Size = new System.Drawing.Size(0, 13);
            this.labelRutaDocumentos.TabIndex = 10;
            // 
            // labelRutaSW
            // 
            this.labelRutaSW.AutoSize = true;
            this.labelRutaSW.Location = new System.Drawing.Point(22, 240);
            this.labelRutaSW.Name = "labelRutaSW";
            this.labelRutaSW.Size = new System.Drawing.Size(0, 13);
            this.labelRutaSW.TabIndex = 11;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 294);
            this.Controls.Add(this.labelRutaSW);
            this.Controls.Add(this.labelRutaDocumentos);
            this.Controls.Add(this.botonCambiarStopWords);
            this.Controls.Add(this.botonCambiarIndice);
            this.Controls.Add(this.botonBestMatch);
            this.Controls.Add(this.botonExactMatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConsulta);
            this.Name = "VistaPrincipal";
            this.Text = "VistaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonExactMatch;
        private System.Windows.Forms.Button botonBestMatch;
        private System.Windows.Forms.Button botonCambiarIndice;
        private System.Windows.Forms.Button botonCambiarStopWords;
        private System.Windows.Forms.Label labelRutaDocumentos;
        private System.Windows.Forms.Label labelRutaSW;
    }
}