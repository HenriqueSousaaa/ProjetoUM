using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class TeoriasCircuitos : Form
    {
        //bool bOhm = false;
        public TeoriasCircuitos()
        {
            InitializeComponent();  
        }

        private void casa2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void TeoriasCircuitos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TeoriasCircuitos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LeiDeOHM_btn_Click(object sender, EventArgs e)
        {
            LeiDeOHM_fr leiform = new LeiDeOHM_fr();
            leiform.Show();

            /* this.bOhm = !bOhm;
            R_lbl.Visible = bOhm;
            R_text.Visible = bOhm;
            
            A_lbl.Visible = bOhm;
            I_text.Visible = bOhm;

            V_lbl.Visible = bOhm;
            V_text.Visible = bOhm;
           */
        }
    }
}
