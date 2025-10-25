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

        private void Btn_Cargar_Prov_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryClientes = "SELECT * FROM Proveedores;";

                using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DGV_Prov.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Agregar_Add_Prov_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_Name_Add_Prov.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Telf_Add_Prov.Text))
            {
                MessageBox.Show("El telefono está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Mail_Add_Prov.Text))
            {
                MessageBox.Show("El correo electronico está incorrecta o vacia.");
                return;
            }


            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryInsertarProductos = @"INSERT INTO Proveedores (NombreProveedor, Telefono, CorreoElectronico)
                                           VALUES ('" + TxtBox_Name_Add_Prov.Text + "','" + TxtBox_Telf_Add_Prov.Text + "'," +
                                                   "'" + TxtBox_Mail_Add_Prov.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarProductos, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado al proveedor en la base de datos.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Delete_Del_Prov_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_ID_Del_Prov.Text))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarProveedor = @"DELETE FROM Proveedores WHERE ProveedorID = '" + TxtBox_ID_Del_Prov.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarProveedor, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado al proveedor.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Update_Edit_Prov_Click(object sender, EventArgs e)
        {
            // Validaciones

            if (string.IsNullOrEmpty(TxtBox_ID_Edit_Prov.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Name_Add_Prov.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Telf_Add_Prov.Text))
            {
                MessageBox.Show("El telefono está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Mail_Add_Prov.Text))
            {
                MessageBox.Show("El correo electronico está incorrecta o vacia.");
                return;
            }

            // Conexión.
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEditarProveedores = @"UPDATE Proveedores
                                                    SET 
                                                        ProveedorID = '" + TxtBox_ID_Edit_Prov.Text + "', " +
                                                        "NombreProveedor = '" + TxtBox_Name_Edit_Prov.Text + "',  " +
                                                        "Telefono = '" + TxtBox_Telf_Edit_Prov.Text + "', " +
                                                        "CorreoElectronico = '" + TxtBox_Mail_Edit_Prov.Text + "'" +
                                                        "WHERE ProveedorID = '" + TxtBox_ID_Edit_Prov.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEditarProveedores, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha editado el proveedor.");
                    }
                }

                connection.Close();
            }
        }
    }
}
