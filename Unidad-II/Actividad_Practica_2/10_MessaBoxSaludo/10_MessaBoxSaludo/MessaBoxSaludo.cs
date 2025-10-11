using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_MessaBoxSaludo
{
    public partial class MessaBoxSaludo : Form
    {
        public MessaBoxSaludo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, soy Idelfonso Peña Castillo | MT-2024-00222.",
                                "Presentación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
