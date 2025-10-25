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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Btn_Cargar_Catg_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryCategorias = "SELECT * FROM Categorias;";

                using (SqlCommand cmd = new SqlCommand(queryCategorias, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DGV_Catg.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Agregar_Add_Catg_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_Name_Add_Catg.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }


            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryInsertarCategorias = @"INSERT INTO Categorias (NombreCategoria)
                                           VALUES ('" + TxtBox_Name_Add_Catg.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarCategorias, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado la categoria.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Delete_Del_Catg_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_ID_Del_Catg.Text))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarCategorias = @"DELETE FROM Productos WHERE CategoriaID = '" + TxtBox_ID_Del_Catg.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarCategorias, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado la categoría.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Update_Edit_Catg_Click(object sender, EventArgs e)
        {
            {
                // Validaciones

                if (string.IsNullOrEmpty(TxtBox_ID_Edit_Catg.Text))
                {
                    MessageBox.Show("Debe introducir un ID válido.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtBox_Name_Edit_Catg.Text))
                {
                    MessageBox.Show("El nombre está incorrecto o vacio.");
                    return;
                }


                // Conexión.
                string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryEditarCategorias = @"UPDATE Categorias 
                                                    SET 
                                                            NombreCompleto = '" + TxtBox_ID_Edit_Catg.Text + "', " +
                                                            "WHERE CategoriaID = '" + TxtBox_ID_Edit_Catg.Text + "'";

                    using (SqlCommand cmd = new SqlCommand(queryEditarCategorias, connection))
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
