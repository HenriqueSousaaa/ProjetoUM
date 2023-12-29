namespace Calculadora
{
    partial class CalculosBobines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculosBobines));
            casa5 = new Button();
            BobinesSerie = new Button();
            BobinesParalelo = new Button();
            BobinesMistas = new Button();
            CalculoBobine = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // casa5
            // 
            casa5.Image = (Image)resources.GetObject("casa5.Image");
            casa5.Location = new Point(12, 12);
            casa5.Name = "casa5";
            casa5.Size = new Size(51, 51);
            casa5.TabIndex = 0;
            casa5.UseVisualStyleBackColor = true;
            casa5.Click += casa5_Click;
            // 
            // BobinesSerie
            // 
            BobinesSerie.Location = new Point(302, 125);
            BobinesSerie.Name = "BobinesSerie";
            BobinesSerie.Size = new Size(195, 50);
            BobinesSerie.TabIndex = 1;
            BobinesSerie.Text = "Bobines em Série";
            BobinesSerie.UseVisualStyleBackColor = true;
            BobinesSerie.Click += BobinesSerie_Click;
            // 
            // BobinesParalelo
            // 
            BobinesParalelo.Location = new Point(302, 181);
            BobinesParalelo.Name = "BobinesParalelo";
            BobinesParalelo.Size = new Size(195, 50);
            BobinesParalelo.TabIndex = 2;
            BobinesParalelo.Text = "Bobines em Paralelo";
            BobinesParalelo.UseVisualStyleBackColor = true;
            BobinesParalelo.Click += BobinesParalelo_Click;
            // 
            // BobinesMistas
            // 
            BobinesMistas.Location = new Point(302, 237);
            BobinesMistas.Name = "BobinesMistas";
            BobinesMistas.Size = new Size(195, 50);
            BobinesMistas.TabIndex = 3;
            BobinesMistas.Text = "Bobines Mistas";
            BobinesMistas.UseVisualStyleBackColor = true;
            BobinesMistas.Click += BobinesMistas_Click;
            // 
            // CalculoBobine
            // 
            CalculoBobine.Location = new Point(302, 293);
            CalculoBobine.Name = "CalculoBobine";
            CalculoBobine.Size = new Size(195, 50);
            CalculoBobine.TabIndex = 4;
            CalculoBobine.Text = "Cálculo Bobine";
            CalculoBobine.UseVisualStyleBackColor = true;
            CalculoBobine.Click += CalculoBobine_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 43);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 5;
            label1.Text = "Cálculos Bobines";
            // 
            // CalculosBobines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CalculoBobine);
            Controls.Add(BobinesMistas);
            Controls.Add(BobinesParalelo);
            Controls.Add(BobinesSerie);
            Controls.Add(casa5);
            Name = "CalculosBobines";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculos Bobines";
            FormClosing += CalculosBobines_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button casa5;
        private Button BobinesSerie;
        private Button BobinesParalelo;
        private Button BobinesMistas;
        private Button CalculoBobine;
        private Label label1;
    }
}