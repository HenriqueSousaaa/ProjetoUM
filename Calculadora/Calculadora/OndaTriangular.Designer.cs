namespace Calculadora
{
    partial class OndaTriangular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OndaTriangular));
            casa4 = new Button();
            voltar1 = new Button();
            SuspendLayout();
            // 
            // casa4
            // 
            casa4.Image = (Image)resources.GetObject("casa4.Image");
            casa4.Location = new Point(12, 12);
            casa4.Name = "casa4";
            casa4.Size = new Size(51, 51);
            casa4.TabIndex = 2;
            casa4.UseVisualStyleBackColor = true;
            casa4.Click += casa4_Click;
            // 
            // voltar1
            // 
            voltar1.Image = (Image)resources.GetObject("voltar1.Image");
            voltar1.Location = new Point(69, 12);
            voltar1.Name = "voltar1";
            voltar1.Size = new Size(51, 51);
            voltar1.TabIndex = 12;
            voltar1.UseVisualStyleBackColor = true;
            voltar1.Click += voltar1_Click;
            // 
            // OndaTriangular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(voltar1);
            Controls.Add(casa4);
            Name = "OndaTriangular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OndaTriangular";
            ResumeLayout(false);
        }

        #endregion

        private Button casa4;
        private Button voltar1;
    }
}