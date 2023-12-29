namespace Calculadora
{
    partial class DigitalLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalLab));
            casa4 = new Button();
            OndaSinusoidal = new Button();
            button2 = new Button();
            OndaQuadrada = new Button();
            OndaTriangular = new Button();
            SuspendLayout();
            // 
            // casa4
            // 
            casa4.Image = (Image)resources.GetObject("casa4.Image");
            casa4.Location = new Point(12, 12);
            casa4.Name = "casa4";
            casa4.Size = new Size(51, 51);
            casa4.TabIndex = 0;
            casa4.UseVisualStyleBackColor = true;
            casa4.Click += casa4_Click;
            // 
            // OndaSinusoidal
            // 
            OndaSinusoidal.BackgroundImage = Properties.Resources.Sinusoidal;
            OndaSinusoidal.Location = new Point(296, 115);
            OndaSinusoidal.Name = "OndaSinusoidal";
            OndaSinusoidal.Size = new Size(296, 77);
            OndaSinusoidal.TabIndex = 0;
            OndaSinusoidal.Text = "Onda Sinusoidal";
            OndaSinusoidal.UseVisualStyleBackColor = true;
            OndaSinusoidal.Click += OndaSinusoidal_Click;
            // 
            // button2
            // 
            button2.Location = new Point(453, 246);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // OndaQuadrada
            // 
            OndaQuadrada.BackgroundImage = Properties.Resources.Quadrada;
            OndaQuadrada.Location = new Point(296, 207);
            OndaQuadrada.Name = "OndaQuadrada";
            OndaQuadrada.Size = new Size(296, 77);
            OndaQuadrada.TabIndex = 3;
            OndaQuadrada.Text = "Onda Quadrada";
            OndaQuadrada.UseVisualStyleBackColor = true;
            OndaQuadrada.Click += OndaQuadrada_Click;
            // 
            // OndaTriangular
            // 
            OndaTriangular.BackgroundImage = Properties.Resources.Triangular;
            OndaTriangular.Location = new Point(296, 303);
            OndaTriangular.Name = "OndaTriangular";
            OndaTriangular.Size = new Size(296, 77);
            OndaTriangular.TabIndex = 4;
            OndaTriangular.Text = "Onda Triangular";
            OndaTriangular.UseVisualStyleBackColor = true;
            OndaTriangular.Click += OndaTriangular_Click;
            // 
            // DigitalLab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OndaTriangular);
            Controls.Add(OndaQuadrada);
            Controls.Add(button2);
            Controls.Add(OndaSinusoidal);
            Controls.Add(casa4);
            Name = "DigitalLab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DigitalLab";
            FormClosing += DigitalLab_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button casa4;
        private Button OndaSinusoidal;
        private Button button2;
        private Button OndaQuadrada;
        private Button OndaTriangular;
    }
}