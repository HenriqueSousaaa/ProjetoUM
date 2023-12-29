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
    public partial class OndaQuadrada : Form
    {
        public OndaQuadrada()
        {
            InitializeComponent();
        }

        private void casa4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalLab OndaQuadrada = new DigitalLab();
            OndaQuadrada.Show();
        }
    }
}
