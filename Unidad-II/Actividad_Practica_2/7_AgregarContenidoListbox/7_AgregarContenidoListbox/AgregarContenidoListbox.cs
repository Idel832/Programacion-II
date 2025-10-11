using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_AgregarContenidoListbox
{
    public partial class AgregarContenidoListbox : Form
    {
        public AgregarContenidoListbox()
        {
            InitializeComponent();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            ListBox_Objetivo.Items.Add(TxtBox_Contenido.Text);
        }
    }
}
