using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_CambiarColorFondo
{
    public partial class CambiarColorFondo : Form
    {
        public CambiarColorFondo()
        {
            InitializeComponent();
        }

        private void CBox_Seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_Seleccion.SelectedIndex == 0)
                this.BackColor = Color.Red;

            else if (CBox_Seleccion.SelectedIndex == 1)
                this.BackColor = Color.Green;

            else if (CBox_Seleccion.SelectedIndex == 2)
                this.BackColor = Color.Blue;
        }
    }
}
