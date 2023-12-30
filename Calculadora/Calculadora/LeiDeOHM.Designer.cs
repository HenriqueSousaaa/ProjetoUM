namespace Calculadora
{
    partial class LeiDeOHM_fr
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
            V_lbl = new Label();
            A_lbl = new Label();
            R_lbl = new Label();
            V_text = new TextBox();
            I_text = new TextBox();
            R_text = new TextBox();
            calc_btn = new Button();
            P_text = new TextBox();
            W_lbl = new Label();
            SuspendLayout();
            // 
            // V_lbl
            // 
            V_lbl.AutoSize = true;
            V_lbl.Location = new Point(623, 258);
            V_lbl.Name = "V_lbl";
            V_lbl.Size = new Size(23, 25);
            V_lbl.TabIndex = 14;
            V_lbl.Text = "V";
            // 
            // A_lbl
            // 
            A_lbl.AutoSize = true;
            A_lbl.Location = new Point(623, 184);
            A_lbl.Name = "A_lbl";
            A_lbl.Size = new Size(24, 25);
            A_lbl.TabIndex = 13;
            A_lbl.Text = "A";
            // 
            // R_lbl
            // 
            R_lbl.AutoSize = true;
            R_lbl.Location = new Point(623, 119);
            R_lbl.Name = "R_lbl";
            R_lbl.Size = new Size(26, 25);
            R_lbl.TabIndex = 12;
            R_lbl.Text = "Ω";
            // 
            // V_text
            // 
            V_text.Location = new Point(467, 255);
            V_text.Name = "V_text";
            V_text.Size = new Size(150, 31);
            V_text.TabIndex = 11;
            // 
            // I_text
            // 
            I_text.Location = new Point(467, 184);
            I_text.Name = "I_text";
            I_text.Size = new Size(150, 31);
            I_text.TabIndex = 10;
            // 
            // R_text
            // 
            R_text.Location = new Point(467, 113);
            R_text.Name = "R_text";
            R_text.Size = new Size(150, 31);
            R_text.TabIndex = 9;
            // 
            // calc_btn
            // 
            calc_btn.BackColor = SystemColors.Control;
            calc_btn.Location = new Point(467, 317);
            calc_btn.Name = "calc_btn";
            calc_btn.Size = new Size(150, 34);
            calc_btn.TabIndex = 15;
            calc_btn.Text = "Calcular";
            calc_btn.UseVisualStyleBackColor = false;
            calc_btn.Click += calc_btn_Click;
            // 
            // P_text
            // 
            P_text.Location = new Point(467, 53);
            P_text.Name = "P_text";
            P_text.Size = new Size(150, 31);
            P_text.TabIndex = 16;
            // 
            // W_lbl
            // 
            W_lbl.AutoSize = true;
            W_lbl.Location = new Point(623, 59);
            W_lbl.Name = "W_lbl";
            W_lbl.Size = new Size(29, 25);
            W_lbl.TabIndex = 17;
            W_lbl.Text = "W";
            // 
            // LeiDeOHM_fr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(W_lbl);
            Controls.Add(P_text);
            Controls.Add(calc_btn);
            Controls.Add(V_lbl);
            Controls.Add(A_lbl);
            Controls.Add(R_lbl);
            Controls.Add(V_text);
            Controls.Add(I_text);
            Controls.Add(R_text);
            Name = "LeiDeOHM_fr";
            Text = "Lei De Ohm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label V_lbl;
        private Label A_lbl;
        private Label R_lbl;
        private TextBox V_text;
        private TextBox I_text;
        private TextBox R_text;
        private Button calc_btn;
        private TextBox P_text;
        private Label W_lbl;
    }
}