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
    public partial class CalculosResistencias : Form
    {
        public CalculosResistencias()
        {
            InitializeComponent();
        }

        private void textopaginaresistencias_Click(object sender, EventArgs e)
        {

        }

        private void casa1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void ResistenciasSerie_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResistenciasSerie PaginaResistenciasSerie = new ResistenciasSerie();
            PaginaResistenciasSerie.Show();
        }

        private void ResistenciasParalelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResistenciasMistas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoeficienteTemperatura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resistividade_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculosResistencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
