namespace Calculadora
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            CalculoResistencias = new Button();
            CalculoCondensadores = new Button();
            TeoriaCircuitosEletricos = new Button();
            TabeladeCores = new Button();
            DigitalLab = new Button();
            PT = new Button();
            EN = new Button();
            label1 = new Label();
            CalculoBobines = new Button();
            fechaprograma = new Button();
            SuspendLayout();
            // 
            // CalculoResistencias
            // 
            CalculoResistencias.Location = new Point(320, 124);
            CalculoResistencias.Name = "CalculoResistencias";
            CalculoResistencias.Size = new Size(181, 64);
            CalculoResistencias.TabIndex = 0;
            CalculoResistencias.Text = "Cálculos Resistências";
            CalculoResistencias.UseVisualStyleBackColor = true;
            CalculoResistencias.Click += CalculoResistencias_Click;
            // 
            // CalculoCondensadores
            // 
            CalculoCondensadores.Location = new Point(507, 124);
            CalculoCondensadores.Name = "CalculoCondensadores";
            CalculoCondensadores.Size = new Size(181, 64);
            CalculoCondensadores.TabIndex = 2;
            CalculoCondensadores.Text = "Cálculos Condensadores";
            CalculoCondensadores.UseVisualStyleBackColor = true;
            CalculoCondensadores.Click += CalculoCondensadores_Click;
            // 
            // TeoriaCircuitosEletricos
            // 
            TeoriaCircuitosEletricos.Location = new Point(507, 209);
            TeoriaCircuitosEletricos.Name = "TeoriaCircuitosEletricos";
            TeoriaCircuitosEletricos.RightToLeft = RightToLeft.No;
            TeoriaCircuitosEletricos.Size = new Size(181, 64);
            TeoriaCircuitosEletricos.TabIndex = 3;
            TeoriaCircuitosEletricos.Text = "Teorias dos Circuitos Elétricos";
            TeoriaCircuitosEletricos.UseVisualStyleBackColor = true;
            TeoriaCircuitosEletricos.Click += TeoriaCircuitosEletricos_Click;
            // 
            // TabeladeCores
            // 
            TabeladeCores.Location = new Point(133, 209);
            TabeladeCores.Name = "TabeladeCores";
            TabeladeCores.Size = new Size(181, 64);
            TabeladeCores.TabIndex = 4;
            TabeladeCores.Text = "Tabela de Cores Resistências";
            TabeladeCores.UseVisualStyleBackColor = true;
            TabeladeCores.Click += TabeladeCores_Click;
            // 
            // DigitalLab
            // 
            DigitalLab.Location = new Point(320, 209);
            DigitalLab.Name = "DigitalLab";
            DigitalLab.Size = new Size(181, 64);
            DigitalLab.TabIndex = 5;
            DigitalLab.Text = "DigitalLab";
            DigitalLab.UseVisualStyleBackColor = true;
            DigitalLab.Click += DigitalLab_Click;
            // 
            // PT
            // 
            PT.Image = (Image)resources.GetObject("PT.Image");
            PT.Location = new Point(683, 12);
            PT.Name = "PT";
            PT.Size = new Size(48, 36);
            PT.TabIndex = 6;
            PT.UseVisualStyleBackColor = true;
            PT.Click += PT_Click;
            // 
            // EN
            // 
            EN.Image = (Image)resources.GetObject("EN.Image");
            EN.Location = new Point(737, 12);
            EN.Name = "EN";
            EN.Size = new Size(48, 36);
            EN.TabIndex = 7;
            EN.UseVisualStyleBackColor = true;
            EN.Click += EN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 8;
            label1.Text = "Menu Principal";
            // 
            // CalculoBobines
            // 
            CalculoBobines.Location = new Point(133, 124);
            CalculoBobines.Name = "CalculoBobines";
            CalculoBobines.Size = new Size(181, 64);
            CalculoBobines.TabIndex = 9;
            CalculoBobines.Text = "Cálculos Bobines";
            CalculoBobines.UseVisualStyleBackColor = true;
            CalculoBobines.Click += CalculoBobines_Click;
            // 
            // fechaprograma
            // 
            fechaprograma.Image = (Image)resources.GetObject("fechaprograma.Image");
            fechaprograma.Location = new Point(12, 12);
            fechaprograma.Name = "fechaprograma";
            fechaprograma.Size = new Size(51, 51);
            fechaprograma.TabIndex = 10;
            fechaprograma.UseVisualStyleBackColor = true;
            fechaprograma.Click += fechaprograma_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaprograma);
            Controls.Add(CalculoBobines);
            Controls.Add(label1);
            Controls.Add(EN);
            Controls.Add(PT);
            Controls.Add(DigitalLab);
            Controls.Add(TabeladeCores);
            Controls.Add(TeoriaCircuitosEletricos);
            Controls.Add(CalculoCondensadores);
            Controls.Add(CalculoResistencias);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página Inicial";
            FormClosing += Inicio_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculoResistencias;
        private Button CalculoCondensadores;
        private Button TeoriaCircuitosEletricos;
        private Button TabeladeCores;
        private Button DigitalLab;
        private Button PT;
        private Button EN;
        private Label label1;
        private Button CalculoBobines;
        private Button fechaprograma;
    }
}
