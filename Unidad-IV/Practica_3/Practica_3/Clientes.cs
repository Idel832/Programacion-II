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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Clientes
                    .Select(c => new
                    {
                        c.ClienteID,
                        c.NombreCompleto,
                        c.CorreoElectronico,
                        c.Telefono,
                        c.Direccion
                    })
                    .ToList();

                DGV_Client.DataSource = lista;
            }
        }


        private void Btn_Cargar_Client_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void Btn_Agregar_Add_Client_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Client.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Mail_Add_Client.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Telf_Add_Client.Text) ||
                string.IsNullOrWhiteSpace(TxtBox_Dir_Add_Client.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            //Conexion
            using (var db = new MiContexto())
            {
                var nuevoCliente = new Cliente
                {
                    NombreCompleto = TxtBox_Name_Add_Client.Text,
                    CorreoElectronico = TxtBox_Mail_Add_Client.Text,
                    Telefono = TxtBox_Telf_Add_Client.Text,
                    Direccion = TxtBox_Dir_Add_Client.Text
                };

                db.Clientes.Add(nuevoCliente);
                db.SaveChanges();
            }

            MessageBox.Show("Cliente agregado correctamente.");
            TxtBox_Name_Add_Client.Clear();
            TxtBox_Mail_Add_Client.Clear();
            TxtBox_Telf_Add_Client.Clear();
            TxtBox_Dir_Add_Client.Clear();
            CargarClientes();
        }


        private void Btn_Delete_Del_Client_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Del_Client.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Del_Client.Text);

            //Conexion
            using (var db = new MiContexto())
            {
                var cliente = db.Clientes.Find(id);
                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }

            MessageBox.Show("Cliente eliminado correctamente.");
            TxtBox_ID_Del_Client.Clear();
            CargarClientes();
        }

        private void Btn_Update_Edit_Client_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Edit_Client.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Edit_Client.Text);

            //Conexion
            using (var db = new MiContexto())
            {
                var cliente = db.Clientes.Find(id);
                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtBox_Name_Edit_Client.Text) ||
                    string.IsNullOrWhiteSpace(TxtBox_Mail_Edit_Client.Text) ||
                    string.IsNullOrWhiteSpace(TxtBox_Telf_Edit_Client.Text) ||
                    string.IsNullOrWhiteSpace(TxtBox_Dir_Edit_Client.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                    return;
                }

                cliente.NombreCompleto = TxtBox_Name_Edit_Client.Text;
                cliente.CorreoElectronico = TxtBox_Mail_Edit_Client.Text;
                cliente.Telefono = TxtBox_Telf_Edit_Client.Text;
                cliente.Direccion = TxtBox_Dir_Edit_Client.Text;

                db.SaveChanges();
            }

            MessageBox.Show("Cliente actualizado correctamente.");
            TxtBox_ID_Edit_Client.Clear();
            TxtBox_Name_Edit_Client.Clear();
            TxtBox_Mail_Edit_Client.Clear();
            TxtBox_Telf_Edit_Client.Clear();
            TxtBox_Dir_Edit_Client.Clear();
            CargarClientes();
        }
    }
} 

