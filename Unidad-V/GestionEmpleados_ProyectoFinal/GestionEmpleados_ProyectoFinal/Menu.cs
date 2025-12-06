using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace ManejoDeEmpleados
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Solo un form abierto
        private Form FormularioAbierto(Type tipoFormulario)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == tipoFormulario)
                    return frm;
            }
            return null;
        }

        private void DptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = FormularioAbierto(typeof(Departamentos));

            if (frm == null)
            {
                frm = new Departamentos();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = FormularioAbierto(typeof(Cargos));

            if (frm == null)
            {
                frm = new Cargos();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = FormularioAbierto(typeof(Empleados));

            if (frm == null)
            {
                frm = new Empleados();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
