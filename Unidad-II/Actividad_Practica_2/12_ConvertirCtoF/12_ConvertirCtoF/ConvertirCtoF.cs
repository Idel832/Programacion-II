using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_ConvertirCtoF
{
    public partial class ConvertirCtoF : Form
    {
        public ConvertirCtoF()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtBox_C.Text, out double numero))
            {
                double C = double.Parse(TxtBox_C.Text);

                double Resultado = (C * 1.8)+32;

                Label_Resultado.Text = Resultado.ToString("F2") + " °F";

            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número. Por favor ingrese un número válido.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


