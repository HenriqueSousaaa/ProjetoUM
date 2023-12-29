namespace Calculadora
{
    partial class TeoriasCircuitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeoriasCircuitos));
            casa2 = new Button();
            SuspendLayout();
            // 
            // casa2
            // 
            casa2.Image = (Image)resources.GetObject("casa2.Image");
            casa2.Location = new Point(12, 12);
            casa2.Name = "casa2";
            casa2.Size = new Size(51, 51);
            casa2.TabIndex = 0;
            casa2.UseVisualStyleBackColor = true;
            casa2.Click += casa2_Click;
            // 
            // TeoriasCircuitos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(casa2);
            Name = "TeoriasCircuitos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teorias dos Circuitos Elétricos";
            FormClosing += TeoriasCircuitos_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button casa2;
    }
}