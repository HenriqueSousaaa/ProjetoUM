using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class ResistenciasSerie : Form
    {
        public ResistenciasSerie()
        {
            InitializeComponent();
        }

        private void casa7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainicial = new Inicio();
            paginainicial.Show();
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculosResistencias PaginaCalculoResistencias = new CalculosResistencias();
            PaginaCalculoResistencias.Show();
        }

        private void ResistenciasSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ValorR1_ValueChanged(object sender, EventArgs e)
        {
            decimal valor = ValorR1.Value;
        }

        private void ValorR2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ValorR3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcular1_Click(object sender, EventArgs e)
        {
            decimal conversao1 = 0;
            decimal conversao2 = 0;
            decimal conversao3 = 0;

            if (comboBox1.SelectedItem != null)
            {
                string letraSelecionada = comboBox1.SelectedItem.ToString();
                decimal valor1 = ValorR1.Value;


                switch (letraSelecionada)
                {
                    case "TΩ":
                        conversao1 = valor1 * 1000000000000m;
                        break;
                    case "GΩ":
                        conversao1 = valor1 * 1000000000m;
                        break;
                    case "MΩ":
                        conversao1 = valor1 * 1000000m;
                        break;
                    case "KΩ":
                        conversao1 = valor1 * 1000m;
                        break;
                    case "Ω":
                        conversao1 = valor1 * 1m;
                        break;
                    case "mΩ":
                        conversao1 = valor1 * 0.001m;
                        break;
                    case "uΩ":
                        conversao1 = valor1 * 0.000001m;
                        break;
                    case "nΩ":
                        conversao1 = valor1 * 0.000000001m;
                        break;
                    case "pΩ":
                        conversao1 = valor1 * 0.000000000001m;
                        break;
                    default:
                        MessageBox.Show("Unidade não reconhecida.");
                        return;
                }
            }
            if (comboBox2.SelectedItem != null)
            {
                string letraSelecionada = comboBox2.SelectedItem.ToString();
                decimal valor2 = ValorR2.Value;


                switch (letraSelecionada)
                {
                    case "TΩ":
                        conversao2 = valor2 * 1000000000000m;
                        break;
                    case "GΩ":
                        conversao2 = valor2 * 1000000000m;
                        break;
                    case "MΩ":
                        conversao2 = valor2 * 1000000m;
                        break;
                    case "KΩ":
                        conversao2 = valor2 * 1000m;
                        break;
                    case "Ω":
                        conversao2 = valor2 * 1m;
                        break;
                    case "mΩ":
                        conversao2 = valor2 * 0.001m;
                        break;
                    case "uΩ":
                        conversao2 = valor2 * 0.000001m;
                        break;
                    case "nΩ":
                        conversao2 = valor2 * 0.000000001m;
                        break;
                    case "pΩ":
                        conversao2 = valor2 * 0.000000000001m;
                        break;
                    default:
                        MessageBox.Show("Unidade não reconhecida.");
                        return;
                }
            }
            if (comboBox3.SelectedItem != null)
            {
                string letraSelecionada = comboBox3.SelectedItem.ToString();

                decimal valor3 = ValorR3.Value;


                switch (letraSelecionada)
                {
                    case "TΩ":
                        conversao3 = valor3 * 1000000000000m;
                        break;
                    case "GΩ":
                        conversao3 = valor3 * 1000000000m;
                        break;
                    case "MΩ":
                        conversao3 = valor3 * 1000000m;
                        break;
                    case "KΩ":
                        conversao3 = valor3 * 1000m;
                        break;
                    case "Ω":
                        conversao3 = valor3 * 1m;
                        break;
                    case "mΩ":
                        conversao3 = valor3 * 0.001m;
                        break;
                    case "uΩ":
                        conversao3 = valor3 * 0.000001m;
                        break;
                    case "nΩ":
                        conversao3 = valor3 * 0.000000001m;
                        break;
                    case "pΩ":
                        conversao3 = valor3 * 0.000000000001m;
                        break;
                    default:
                        MessageBox.Show("Unidade não reconhecida.");
                        return;
                }
            }

            if ((comboBox3.SelectedItem == null) || (comboBox2.SelectedItem == null) || (comboBox1.SelectedItem == null))
            {
                ResultadoSerie.Text = "Unidade não reconhecida.";
            }

            decimal valortotal = conversao1 + conversao2 + conversao3;
            
            ResultadoSerie.Text = "O valor total é: " + valortotal.ToString();
        }

        private void ResultadoSerie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
