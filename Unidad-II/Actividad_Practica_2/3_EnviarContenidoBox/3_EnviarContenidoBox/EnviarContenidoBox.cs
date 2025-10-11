using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_EnviarContenidoBox
{
    public partial class EnviarContenidoBox : Form
    {
        public EnviarContenidoBox()
        {
            InitializeComponent();
        }

        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            Label_Objetivo.Text = TxtBox_Contenido.Text;
        }
    }
}
