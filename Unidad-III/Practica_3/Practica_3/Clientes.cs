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

        private void Btn_Cargar_Client_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryClientes = "SELECT * FROM Clientes;";

                using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DGV_Client.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Agregar_Add_Client_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_Name_Add_Client.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Mail_Add_Client.Text))
            {
                MessageBox.Show("El correo está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Telf_Add_Client.Text))
            {
                MessageBox.Show("El telefóno está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Dir_Add_Client.Text))
            {
                MessageBox.Show("La dirección está incorrecto o vacio.");
                return;
            }


            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryInsertarClientes = @"INSERT INTO Clientes (NombreCompleto, CorreoElectronico, Telefono, Direccion)
                                           VALUES ('" + TxtBox_Name_Add_Client.Text + "','" + TxtBox_Mail_Add_Client.Text + "'," +
                                                   "'" + TxtBox_Telf_Add_Client.Text + "','" + TxtBox_Dir_Add_Client.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarClientes, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado el producto.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Delete_Del_Client_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_ID_Del_Client.Text))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarClientes = @"DELETE FROM Clientes WHERE ClienteID = '" + TxtBox_ID_Del_Client.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarClientes, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado al cliente.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Update_Edit_Client_Click(object sender, EventArgs e)
        {
            {
                // Validaciones

                if (string.IsNullOrEmpty(TxtBox_ID_Edit_Client.Text))
                {
                    MessageBox.Show("Debe introducir un ID válido.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtBox_Name_Add_Client.Text))
                {
                    MessageBox.Show("El nombre está incorrecto o vacio.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtBox_Mail_Add_Client.Text))
                {
                    MessageBox.Show("El Correo está incorrecto o vacio.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtBox_Telf_Add_Client.Text))
                {
                    MessageBox.Show("El telefóno está incorrecto o vacio.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtBox_Dir_Add_Client.Text))
                {
                    MessageBox.Show("La dirección está incorrecto o vacio.");
                    return;
                }

                // Conexión.
                string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryEditarClientes = @"UPDATE Clientes 
                                                    SET 
                                                            NombreCompleto = '" + TxtBox_ID_Edit_Client.Text + "', " +
                                                            "CorreoElectronico = '" + TxtBox_Mail_Add_Client.Text + "',  " +
                                                            "Telefono = '" + TxtBox_Telf_Add_Client.Text + "', " +
                                                            "Direccion = '" + TxtBox_Dir_Add_Client.Text + "'" +
                                                            "WHERE ClienteID = '" + TxtBox_ID_Edit_Client.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(queryEditarClientes, connection))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Se ha editado el cliente.");
                        }
                    }

                    connection.Close();
                }
            }
        }
    }
}
