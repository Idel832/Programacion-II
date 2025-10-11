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

namespace _13_Barra_de_progreso
{
    public partial class BarraProgreso : Form
    {
        public BarraProgreso()
        {
            InitializeComponent();
        }

        private void Btn_Progreso_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                Btn_Progreso.Text = "Iniciar";
            }
            else
            {
                timer1.Start();
                Btn_Progreso.Text = "Detener";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProBar_Objetivo.Value < ProBar_Objetivo.Maximum)
            {
                ProBar_Objetivo.Value += 1;
            }
            else
            {
                timer1.Stop();
                Btn_Progreso.Text = "Iniciar";
            }

            if (ProBar_Objetivo.Value == ProBar_Objetivo.Maximum)
            {
                ProBar_Objetivo.Value = 0;
            }
        }
    }
}
