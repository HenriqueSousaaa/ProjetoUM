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
    public partial class LeiDeOHM_fr : Form
    {
        public LeiDeOHM_fr()
        {
            InitializeComponent();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            double potencia;
            bool ha_p;
            ha_p = Double.TryParse(P_text.Text, out potencia);

            bool ha_r;
            double resistencia;
            ha_r = Double.TryParse(R_text.Text, out resistencia);

            bool ha_i;
            double intensidade;
            ha_i = Double.TryParse(I_text.Text, out intensidade);

            bool ha_t;
            double tensao;
            ha_t = Double.TryParse(V_text.Text, out tensao);

            if (ha_t == true && ha_i== true)
            { //R=u/i
                resistencia = tensao / intensidade;
                R_text.Text = "=" + resistencia.ToString();
                R_text.BackColor = Color.Red;
                potencia = intensidade * tensao;
                P_text.Text = "=" + potencia.ToString(); P_text.BackColor = Color.Green;
                
            }
            if (ha_i == true && ha_r == true)
            { //U=R*I
                tensao = resistencia * intensidade;
                V_text.Text = "=" + tensao.ToString();
                V_text.BackColor = Color.Red;
                potencia = resistencia * (intensidade*intensidade);// elevar um valor ao quadrado-> pow(intensidade,2)
                P_text.Text = "=" + potencia.ToString(); P_text.BackColor = Color.Green;
            }
        }

    }
}
