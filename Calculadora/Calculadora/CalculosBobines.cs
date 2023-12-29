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
    public partial class CalculosBobines : Form
    {
        public CalculosBobines()
        {
            InitializeComponent();
        }

        private void casa5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void BobinesSerie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BobinesParalelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BobinesMistas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculoBobine_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculosBobines_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
