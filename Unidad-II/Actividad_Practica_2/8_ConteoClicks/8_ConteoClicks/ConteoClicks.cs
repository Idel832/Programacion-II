using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_ConteoClicks
{
    public partial class ConteoClicks : Form
    {
        public ConteoClicks()
        {
            InitializeComponent();
        }

        int Conteo = 0;
        private void Btn_Objetivo_Click(object sender, EventArgs e)
        {
            Conteo++;

           Label_Resultado.Text = Conteo.ToString();
        }
    }
}
