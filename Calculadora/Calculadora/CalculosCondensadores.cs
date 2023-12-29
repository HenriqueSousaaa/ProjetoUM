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
    public partial class CalculosCondensadores : Form
    {
        public CalculosCondensadores()
        {
            InitializeComponent();
        }

        private void casa6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void CondensadoresSerie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CondensadoresParalelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CondensadoresMistos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Capacitancia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculosCondensadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
