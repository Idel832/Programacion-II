using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_AbrirArchivosTexto
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svdlg = new SaveFileDialog();
            svdlg.Filter = "*.txt|";

            if (svdlg.ShowDialog() == DialogResult.OK)
            {
                string ruta = svdlg.FileName;
                File.WriteAllText(ruta, TxtBox_Show.Text);
            }
        
        }


        private void Btn_Open_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "*.txt|";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string ruta = dlg.FileName;
                TxtBox_Show.Text = File.ReadAllText(ruta);
            }

            
        }
            
    }
}
