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
    public partial class OndaTriangular : Form
    {
        public OndaTriangular()
        {
            InitializeComponent();
        }

        private void casa4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio paginainial = new Inicio();
            paginainial.Show();
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DigitalLab OndaTriangular = new DigitalLab();
            OndaTriangular.Show();
        }
    }
}
