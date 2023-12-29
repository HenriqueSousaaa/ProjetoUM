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
    public partial class TabelaCoresResistencias : Form
    {
        public TabelaCoresResistencias()
        {
            InitializeComponent();
        }

        private void casa3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void TabelaCoresResistencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
