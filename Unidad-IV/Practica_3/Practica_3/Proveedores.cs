using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Proveedores
                    .Select(p => new
                    {
                        p.ProveedorID,
                        p.NombreProveedor,
                        p.Telefono,
                        p.CorreoElectronico
                    })
                    .ToList();

                DGV_Prov.DataSource = lista;
            }
        }

        private void Btn_Cargar_Prov_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void Btn_Agregar_Add_Prov_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Prov.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Telf_Add_Prov.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Mail_Add_Prov.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            //Conexion
            using (var db = new MiContexto())
            {
                var nuevoProveedor = new Proveedor
                {
                    NombreProveedor = TxtBox_Name_Add_Prov.Text,
                    Telefono = TxtBox_Telf_Add_Prov.Text,
                    CorreoElectronico = TxtBox_Mail_Add_Prov.Text
                };

                db.Proveedores.Add(nuevoProveedor);
                db.SaveChanges();
            }

            MessageBox.Show("Proveedor agregado correctamente.");
            TxtBox_Name_Add_Prov.Clear();
            TxtBox_Telf_Add_Prov.Clear();
            TxtBox_Mail_Add_Prov.Clear();
            CargarProveedores();
        }

        private void Btn_Delete_Del_Prov_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Del_Prov.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Del_Prov.Text);

            //Conexion
            using (var db = new MiContexto())
            {
                var proveedor = db.Proveedores.Find(id);
                if (proveedor == null)
                {
                    MessageBox.Show("Proveedor no encontrado.");
                    return;
                }

                db.Proveedores.Remove(proveedor);
                db.SaveChanges();
            }

            MessageBox.Show("Proveedor eliminado correctamente.");
            TxtBox_ID_Del_Prov.Clear();
            CargarProveedores();
        }

        private void Btn_Update_Edit_Prov_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Edit_Prov.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Edit_Prov.Text);
            
            //Conexion
            using (var db = new MiContexto())
            {
                var proveedor = db.Proveedores.Find(id);
                if (proveedor == null)
                {
                    MessageBox.Show("Proveedor no encontrado.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtBox_Name_Edit_Prov.Text) ||
                    string.IsNullOrWhiteSpace(TxtBox_Telf_Edit_Prov.Text) ||
                    string.IsNullOrWhiteSpace(TxtBox_Mail_Edit_Prov.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                    return;
                }

                proveedor.NombreProveedor = TxtBox_Name_Edit_Prov.Text;
                proveedor.Telefono = TxtBox_Telf_Edit_Prov.Text;
                proveedor.CorreoElectronico = TxtBox_Mail_Edit_Prov.Text;

                db.SaveChanges();
            }

            MessageBox.Show("Proveedor actualizado correctamente.");
            TxtBox_ID_Edit_Prov.Clear();
            TxtBox_Name_Edit_Prov.Clear();
            TxtBox_Telf_Edit_Prov.Clear();
            TxtBox_Mail_Edit_Prov.Clear();
            CargarProveedores();
        }

    }
}
