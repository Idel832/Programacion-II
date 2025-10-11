using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_ValidarNumero
{
    public partial class ValidarNumero : Form
    {
        public ValidarNumero()
        {
            InitializeComponent();
        }

        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtBox_Contenido.Text, out double numero))
            {
                MessageBox.Show($"El valor ingresado es un número", "Validación correcta",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
