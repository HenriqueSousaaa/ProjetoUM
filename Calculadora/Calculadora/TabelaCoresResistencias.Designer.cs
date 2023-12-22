namespace Calculadora
{
    partial class TabelaCoresResistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaCoresResistencias));
            casa3 = new Button();
            SuspendLayout();
            // 
            // casa3
            // 
            casa3.Image = (Image)resources.GetObject("casa3.Image");
            casa3.Location = new Point(12, 12);
            casa3.Name = "casa3";
            casa3.Size = new Size(51, 51);
            casa3.TabIndex = 0;
            casa3.UseVisualStyleBackColor = true;
            casa3.Click += casa3_Click;
            // 
            // TabelaCoresResistencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(casa3);
            Name = "TabelaCoresResistencias";
            Text = "Tabela de Cores das Resistências";
            FormClosing += TabelaCoresResistencias_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button casa3;
    }
}