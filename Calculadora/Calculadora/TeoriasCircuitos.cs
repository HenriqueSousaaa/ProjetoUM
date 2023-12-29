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
    }
}
