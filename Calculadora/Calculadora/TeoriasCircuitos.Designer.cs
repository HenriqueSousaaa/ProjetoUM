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
            LeiDeOHM_btn = new Button();
            SuspendLayout();
            // 
            // casa2
            // 
            casa2.Image = (Image)resources.GetObject("casa2.Image");
            casa2.Location = new Point(15, 15);
            casa2.Margin = new Padding(4);
            casa2.Name = "casa2";
            casa2.Size = new Size(64, 64);
            casa2.TabIndex = 0;
            casa2.UseVisualStyleBackColor = true;
            casa2.Click += casa2_Click;
            // 
            // LeiDeOHM_btn
            // 
            LeiDeOHM_btn.Location = new Point(429, 74);
            LeiDeOHM_btn.Name = "LeiDeOHM_btn";
            LeiDeOHM_btn.Size = new Size(151, 44);
            LeiDeOHM_btn.TabIndex = 1;
            LeiDeOHM_btn.Text = "Lei De OHM";
            LeiDeOHM_btn.UseVisualStyleBackColor = true;
            LeiDeOHM_btn.Click += LeiDeOHM_btn_Click;
            // 
            // TeoriasCircuitos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(LeiDeOHM_btn);
            Controls.Add(casa2);
            Margin = new Padding(4);
            Name = "TeoriasCircuitos";
            Text = "Teorias dos Circuitos Elétricos";
            FormClosing += TeoriasCircuitos_FormClosing;
            Load += TeoriasCircuitos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button casa2;
        private Button LeiDeOHM_btn;
    }
}