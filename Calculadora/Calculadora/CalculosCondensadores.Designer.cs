namespace Calculadora
{
    partial class CalculosCondensadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculosCondensadores));
            casa6 = new Button();
            CondensadoresSerie = new Button();
            textoCalculosCondensadores = new Label();
            CondensadoresParalelo = new Button();
            CondensadoresMistos = new Button();
            Capacitancia = new Button();
            SuspendLayout();
            // 
            // casa6
            // 
            casa6.Image = (Image)resources.GetObject("casa6.Image");
            casa6.Location = new Point(12, 12);
            casa6.Name = "casa6";
            casa6.Size = new Size(51, 51);
            casa6.TabIndex = 0;
            casa6.UseVisualStyleBackColor = true;
            casa6.Click += casa6_Click;
            // 
            // CondensadoresSerie
            // 
            CondensadoresSerie.Location = new Point(312, 114);
            CondensadoresSerie.Name = "CondensadoresSerie";
            CondensadoresSerie.Size = new Size(195, 50);
            CondensadoresSerie.TabIndex = 1;
            CondensadoresSerie.Text = "Condensadores em Série";
            CondensadoresSerie.UseVisualStyleBackColor = true;
            CondensadoresSerie.Click += CondensadoresSerie_Click;
            // 
            // textoCalculosCondensadores
            // 
            textoCalculosCondensadores.AutoSize = true;
            textoCalculosCondensadores.Location = new Point(328, 43);
            textoCalculosCondensadores.Name = "textoCalculosCondensadores";
            textoCalculosCondensadores.Size = new Size(170, 20);
            textoCalculosCondensadores.TabIndex = 2;
            textoCalculosCondensadores.Text = "Cálculos Condensadores";
            // 
            // CondensadoresParalelo
            // 
            CondensadoresParalelo.Location = new Point(312, 170);
            CondensadoresParalelo.Name = "CondensadoresParalelo";
            CondensadoresParalelo.Size = new Size(195, 50);
            CondensadoresParalelo.TabIndex = 3;
            CondensadoresParalelo.Text = "Condensadores em Paralelo";
            CondensadoresParalelo.UseVisualStyleBackColor = true;
            CondensadoresParalelo.Click += CondensadoresParalelo_Click;
            // 
            // CondensadoresMistos
            // 
            CondensadoresMistos.Location = new Point(312, 226);
            CondensadoresMistos.Name = "CondensadoresMistos";
            CondensadoresMistos.Size = new Size(195, 50);
            CondensadoresMistos.TabIndex = 4;
            CondensadoresMistos.Text = "Condensadores Mistos";
            CondensadoresMistos.UseVisualStyleBackColor = true;
            CondensadoresMistos.Click += CondensadoresMistos_Click;
            // 
            // Capacitancia
            // 
            Capacitancia.Location = new Point(312, 282);
            Capacitancia.Name = "Capacitancia";
            Capacitancia.Size = new Size(195, 50);
            Capacitancia.TabIndex = 5;
            Capacitancia.Text = "Capacitância";
            Capacitancia.UseVisualStyleBackColor = true;
            Capacitancia.Click += Capacitancia_Click;
            // 
            // CalculosCondensadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Capacitancia);
            Controls.Add(CondensadoresMistos);
            Controls.Add(CondensadoresParalelo);
            Controls.Add(textoCalculosCondensadores);
            Controls.Add(CondensadoresSerie);
            Controls.Add(casa6);
            Name = "CalculosCondensadores";
            Text = "Cálculos Condensadores";
            FormClosing += CalculosCondensadores_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button casa6;
        private Button CondensadoresSerie;
        private Label textoCalculosCondensadores;
        private Button CondensadoresParalelo;
        private Button CondensadoresMistos;
        private Button Capacitancia;
    }
}