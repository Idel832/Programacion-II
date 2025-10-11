using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_MostrarSelección
{
    public partial class MostrarSelección : Form
    {
        public MostrarSelección()
        {
            InitializeComponent();
        }

        private void Btn_Verificar_Click(object sender, EventArgs e)
        {
            if (RBtn_A.Checked)
                Label_Resultado.Text = "Esta seleccionado la A";

            else if (RBtn_B.Checked)
                Label_Resultado.Text = "Esta seleccionado la B";

            else if (RBtn_C.Checked)
                Label_Resultado.Text = "Esta seleccionado la C";
        }
    }
}
