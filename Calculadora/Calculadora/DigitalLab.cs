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
    public partial class DigitalLab : Form
    {
        public DigitalLab()
        {
            InitializeComponent();
        }

        private void casa4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void DigitalLab_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OndaSinusoidal_Click(object sender, EventArgs e)
        {
            this.Hide();
            OndaSinusoidal PaginaOndaSinusoidal = new OndaSinusoidal();
            PaginaOndaSinusoidal.Show();
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculosResistencias PaginaCalculoResistencias = new CalculosResistencias();
            PaginaCalculoResistencias.Show();
        }

        private void OndaQuadrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            OndaQuadrada PaginaOndaQuadrada = new OndaQuadrada();
            PaginaOndaQuadrada.Show();

        }

        private void OndaTriangular_Click(object sender, EventArgs e)
        {
            this.Hide();
            OndaTriangular PaginaOndaTriangular = new OndaTriangular();
            PaginaOndaTriangular.Show();
        }
    }
}
