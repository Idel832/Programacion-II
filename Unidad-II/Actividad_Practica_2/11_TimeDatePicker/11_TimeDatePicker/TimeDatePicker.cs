using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_TimeDatePicker
{
    public partial class TimeDatePicker : Form
    {
        public TimeDatePicker()
        {
            InitializeComponent();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Label_Resultado.Text = DateTP_Origen.Text;
        }
    }
}
