namespace Calculadora
{
    partial class CalculosResistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculosResistencias));
            ResistenciasSerie = new Button();
            ResistenciasParalelo = new Button();
            Resistividade = new Button();
            CoeficienteTemperatura = new Button();
            casa1 = new Button();
            textopaginaresistencias = new Label();
            ResistenciasMistas = new Button();
            SuspendLayout();
            // 
            // ResistenciasSerie
            // 
            ResistenciasSerie.Location = new Point(296, 125);
            ResistenciasSerie.Name = "ResistenciasSerie";
            ResistenciasSerie.Size = new Size(195, 50);
            ResistenciasSerie.TabIndex = 0;
            ResistenciasSerie.Text = "Resistências em Série";
            ResistenciasSerie.UseVisualStyleBackColor = true;
            ResistenciasSerie.Click += ResistenciasSerie_Click;
            // 
            // ResistenciasParalelo
            // 
            ResistenciasParalelo.Location = new Point(296, 181);
            ResistenciasParalelo.Name = "ResistenciasParalelo";
            ResistenciasParalelo.Size = new Size(195, 50);
            ResistenciasParalelo.TabIndex = 1;
            ResistenciasParalelo.Text = "Resistências em Paralelo";
            ResistenciasParalelo.UseVisualStyleBackColor = true;
            ResistenciasParalelo.Click += ResistenciasParalelo_Click;
            // 
            // Resistividade
            // 
            Resistividade.Location = new Point(296, 349);
            Resistividade.Name = "Resistividade";
            Resistividade.Size = new Size(195, 50);
            Resistividade.TabIndex = 2;
            Resistividade.Text = "Resistividade";
            Resistividade.UseVisualStyleBackColor = true;
            Resistividade.Click += Resistividade_Click;
            // 
            // CoeficienteTemperatura
            // 
            CoeficienteTemperatura.Location = new Point(296, 293);
            CoeficienteTemperatura.Name = "CoeficienteTemperatura";
            CoeficienteTemperatura.Size = new Size(195, 50);
            CoeficienteTemperatura.TabIndex = 3;
            CoeficienteTemperatura.Text = "Coeficiente de Temperatura";
            CoeficienteTemperatura.UseVisualStyleBackColor = true;
            CoeficienteTemperatura.Click += CoeficienteTemperatura_Click;
            // 
            // casa1
            // 
            casa1.Image = (Image)resources.GetObject("casa1.Image");
            casa1.Location = new Point(12, 12);
            casa1.Name = "casa1";
            casa1.Size = new Size(51, 51);
            casa1.TabIndex = 4;
            casa1.UseVisualStyleBackColor = true;
            casa1.Click += casa1_Click;
            // 
            // textopaginaresistencias
            // 
            textopaginaresistencias.AutoSize = true;
            textopaginaresistencias.Location = new Point(316, 43);
            textopaginaresistencias.Name = "textopaginaresistencias";
            textopaginaresistencias.Size = new Size(147, 20);
            textopaginaresistencias.TabIndex = 5;
            textopaginaresistencias.Text = "Cálculos Resistências";
            textopaginaresistencias.Click += textopaginaresistencias_Click;
            // 
            // ResistenciasMistas
            // 
            ResistenciasMistas.Location = new Point(296, 237);
            ResistenciasMistas.Name = "ResistenciasMistas";
            ResistenciasMistas.Size = new Size(195, 50);
            ResistenciasMistas.TabIndex = 6;
            ResistenciasMistas.Text = "Resistências Mistas";
            ResistenciasMistas.UseVisualStyleBackColor = true;
            ResistenciasMistas.Click += ResistenciasMistas_Click;
            // 
            // CalculosResistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResistenciasMistas);
            Controls.Add(textopaginaresistencias);
            Controls.Add(casa1);
            Controls.Add(CoeficienteTemperatura);
            Controls.Add(Resistividade);
            Controls.Add(ResistenciasParalelo);
            Controls.Add(ResistenciasSerie);
            Name = "CalculosResistencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculos Resistências";
            FormClosing += CalculosResistencias_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResistenciasSerie;
        private Button ResistenciasParalelo;
        private Button Resistividade;
        private Button CoeficienteTemperatura;
        private Button casa1;
        private Label textopaginaresistencias;
        private Button ResistenciasMistas;
    }
}