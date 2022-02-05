namespace Buscador.Vistas
{
    partial class VistaInicio
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
            this.botonExaminar1 = new System.Windows.Forms.Button();
            this.botonExaminar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rutaSeleccionadaText = new System.Windows.Forms.Label();
            this.rutaSeleccionadaSW = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonContinuar = new System.Windows.Forms.Button();
            this.labelAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonExaminar1
            // 
            this.botonExaminar1.Location = new System.Drawing.Point(359, 92);
            this.botonExaminar1.Name = "botonExaminar1";
            this.botonExaminar1.Size = new System.Drawing.Size(75, 23);
            this.botonExaminar1.TabIndex = 0;
            this.botonExaminar1.Text = "Examinar";
            this.botonExaminar1.UseVisualStyleBackColor = true;
            this.botonExaminar1.Click += new System.EventHandler(this.botonExaminar1_Click);
            // 
            // botonExaminar2
            // 
            this.botonExaminar2.Location = new System.Drawing.Point(359, 155);
            this.botonExaminar2.Name = "botonExaminar2";
            this.botonExaminar2.Size = new System.Drawing.Size(75, 23);
            this.botonExaminar2.TabIndex = 1;
            this.botonExaminar2.Text = "Examinar";
            this.botonExaminar2.UseVisualStyleBackColor = true;
            this.botonExaminar2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo documentos seleccionado";
            // 
            // rutaSeleccionadaText
            // 
            this.rutaSeleccionadaText.AutoSize = true;
            this.rutaSeleccionadaText.Location = new System.Drawing.Point(31, 97);
            this.rutaSeleccionadaText.Name = "rutaSeleccionadaText";
            this.rutaSeleccionadaText.Size = new System.Drawing.Size(0, 13);
            this.rutaSeleccionadaText.TabIndex = 3;
            // 
            // rutaSeleccionadaSW
            // 
            this.rutaSeleccionadaSW.AutoSize = true;
            this.rutaSeleccionadaSW.Location = new System.Drawing.Point(31, 160);
            this.rutaSeleccionadaSW.Name = "rutaSeleccionadaSW";
            this.rutaSeleccionadaSW.Size = new System.Drawing.Size(0, 13);
            this.rutaSeleccionadaSW.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Archivo stopwords seleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Por favor ingrese los archivos de inicio";
            // 
            // botonContinuar
            // 
            this.botonContinuar.Location = new System.Drawing.Point(195, 203);
            this.botonContinuar.Name = "botonContinuar";
            this.botonContinuar.Size = new System.Drawing.Size(75, 23);
            this.botonContinuar.TabIndex = 7;
            this.botonContinuar.Text = "Continuar";
            this.botonContinuar.UseVisualStyleBackColor = true;
            this.botonContinuar.Click += new System.EventHandler(this.botonContinuar_Click);
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(31, 186);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(0, 13);
            this.labelAviso.TabIndex = 8;
            // 
            // VistaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.botonContinuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rutaSeleccionadaSW);
            this.Controls.Add(this.rutaSeleccionadaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonExaminar2);
            this.Controls.Add(this.botonExaminar1);
            this.Name = "VistaInicio";
            this.Text = "VistaInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonExaminar1;
        private System.Windows.Forms.Button botonExaminar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rutaSeleccionadaText;
        private System.Windows.Forms.Label rutaSeleccionadaSW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonContinuar;
        private System.Windows.Forms.Label labelAviso;
    }
}