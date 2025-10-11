using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_SumaBasica
{
    public partial class SumaBasica : Form
    {
        public SumaBasica()
        {
            InitializeComponent();
        }

        private void Btn_Sumar_Click(object sender, EventArgs e)
        {

            double A = double.Parse(TxtBox_Num1.Text);
            double B = double.Parse(TxtBox_Num2.Text);

            double Resultado = A + B;

            Label_Resultado.Text = Resultado.ToString();
        }
    }
}
