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
            // DigitalLab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(casa4);
            Name = "DigitalLab";
            Text = "DigitalLab";
            FormClosing += DigitalLab_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button casa4;
    }
}