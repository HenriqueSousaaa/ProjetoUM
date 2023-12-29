namespace Calculadora
{
    partial class ResistenciasSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResistenciasSerie));
            calcular1 = new Button();
            pictureBox1 = new PictureBox();
            ValorR1 = new NumericUpDown();
            ValorR2 = new NumericUpDown();
            ValorR3 = new NumericUpDown();
            casa7 = new Button();
            voltar1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ResultadoSerie = new TextBox();
            label1 = new Label();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValorR1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValorR2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValorR3).BeginInit();
            SuspendLayout();
            // 
            // calcular1
            // 
            calcular1.Location = new Point(12, 239);
            calcular1.Name = "calcular1";
            calcular1.Size = new Size(307, 50);
            calcular1.TabIndex = 0;
            calcular1.Text = "Calcular";
            calcular1.UseVisualStyleBackColor = true;
            calcular1.Click += calcular1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(410, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 250);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ValorR1
            // 
            ValorR1.Location = new Point(12, 126);
            ValorR1.Name = "ValorR1";
            ValorR1.Size = new Size(150, 27);
            ValorR1.TabIndex = 2;
            ValorR1.ValueChanged += ValorR1_ValueChanged;
            // 
            // ValorR2
            // 
            ValorR2.Location = new Point(12, 159);
            ValorR2.Name = "ValorR2";
            ValorR2.Size = new Size(150, 27);
            ValorR2.TabIndex = 3;
            ValorR2.ValueChanged += ValorR2_ValueChanged;
            // 
            // ValorR3
            // 
            ValorR3.Location = new Point(12, 192);
            ValorR3.Name = "ValorR3";
            ValorR3.Size = new Size(150, 27);
            ValorR3.TabIndex = 7;
            ValorR3.ValueChanged += ValorR3_ValueChanged;
            // 
            // casa7
            // 
            casa7.Image = (Image)resources.GetObject("casa7.Image");
            casa7.Location = new Point(12, 12);
            casa7.Name = "casa7";
            casa7.Size = new Size(51, 51);
            casa7.TabIndex = 8;
            casa7.UseVisualStyleBackColor = true;
            casa7.Click += casa7_Click;
            // 
            // voltar1
            // 
            voltar1.Image = (Image)resources.GetObject("voltar1.Image");
            voltar1.Location = new Point(69, 12);
            voltar1.Name = "voltar1";
            voltar1.Size = new Size(51, 51);
            voltar1.TabIndex = 9;
            voltar1.UseVisualStyleBackColor = true;
            voltar1.Click += voltar1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Ω";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TΩ", "GΩ", "MΩ", "KΩ", "Ω", "mΩ", "uΩ", "nΩ", "pΩ" });
            comboBox1.Location = new Point(168, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            comboBox1.ValueMember = "Ω";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "TΩ", "GΩ", "MΩ", "KΩ", "Ω", "mΩ", "uΩ", "nΩ", "pΩ" });
            comboBox2.Location = new Point(168, 159);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "TΩ", "GΩ", "MΩ", "KΩ", "Ω", "mΩ", "uΩ", "nΩ", "pΩ" });
            comboBox3.Location = new Point(168, 192);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 12;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // ResultadoSerie
            // 
            ResultadoSerie.Location = new Point(12, 349);
            ResultadoSerie.Name = "ResultadoSerie";
            ResultadoSerie.Size = new Size(307, 27);
            ResultadoSerie.TabIndex = 13;
            ResultadoSerie.TextChanged += ResultadoSerie_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 306);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 14;
            label1.Text = "Resultado:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "TΩ", "GΩ", "MΩ", "KΩ", "Ω", "mΩ", "uΩ", "nΩ", "pΩ" });
            comboBox4.Location = new Point(325, 349);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(53, 28);
            comboBox4.TabIndex = 15;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // ResistenciasSerie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox4);
            Controls.Add(label1);
            Controls.Add(ResultadoSerie);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(voltar1);
            Controls.Add(casa7);
            Controls.Add(ValorR3);
            Controls.Add(ValorR2);
            Controls.Add(ValorR1);
            Controls.Add(pictureBox1);
            Controls.Add(calcular1);
            Name = "ResistenciasSerie";
            Text = "Resistências em Série";
            FormClosing += ResistenciasSerie_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValorR1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValorR2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValorR3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcular1;
        private PictureBox pictureBox1;
        private NumericUpDown ValorR1;
        private NumericUpDown ValorR2;
        private NumericUpDown ValorR3;
        private Button casa7;
        private Button voltar1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox ResultadoSerie;
        private Label label1;
        private ComboBox comboBox4;
    }
}