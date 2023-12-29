namespace Calculadora
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }



        private void CalculoResistencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculosResistencias PaginaCalculoResistencias = new CalculosResistencias();
            PaginaCalculoResistencias.Show();
        }

        private void TabeladeCores_Click(object sender, EventArgs e)
        {
            this.Hide();
            TabelaCoresResistencias PaginaTabelaCores = new TabelaCoresResistencias();
            PaginaTabelaCores.Show();
        }

        private void CalculoCondensadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculosCondensadores PaginaCalculoCondensadores = new CalculosCondensadores();
            PaginaCalculoCondensadores.Show();
        }

        private void DigitalLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalLab PaginaDigitallab = new DigitalLab();
            PaginaDigitallab.Show();
        }

        private void TeoriaCircuitosEletricos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeoriasCircuitos PaginaTeorias = new TeoriasCircuitos();
            PaginaTeorias.Show();
        }

        private void CalculoBobines_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculosBobines PaginaCalculoBobines = new CalculosBobines();
            PaginaCalculoBobines.Show();
        }

        private void PT_Click(object sender, EventArgs e)
        {

        }

        private void EN_Click(object sender, EventArgs e)
        {

        }

        private void fechaprograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
