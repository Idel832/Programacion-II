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
    public partial class Productos : Form
    {
        private void CargarCategorias()
        {
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";
            string query = "SELECT CategoriaID, NombreCategoria FROM Categorias";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    CBox_Catg_Add_Prods.DataSource = dt;
                    CBox_Catg_Add_Prods.DisplayMember = "NombreCategoria";
                    CBox_Catg_Add_Prods.ValueMember = "CategoriaID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public Productos()
        {
            InitializeComponent();
            CargarCategorias();
        }


        private void Btn_Cargar_Prods_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryProductos = "SELECT * FROM Productos;";

                using (SqlCommand cmd = new SqlCommand(queryProductos, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DGV_Prods.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Agregar_Add_Prods_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_Name_Add_Prods.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Desc_Add_Prods.Text))
            {
                MessageBox.Show("El Descripción está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Price_Add_Prods.Text))
            {
                MessageBox.Show("El Precio está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Stock_Add_Prods.Text))
            {
                MessageBox.Show("El Stock está incorrecto o vacio.");
                return;
            }


            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryInsertarProductos = @"INSERT INTO Productos (NombreProducto, Descripcion, Precio, Stock)
                                           VALUES ('" + TxtBox_Name_Add_Prods.Text + "','" + TxtBox_Desc_Add_Prods.Text + "'," +
                                                   "'" + TxtBox_Price_Add_Prods.Text + "','" + TxtBox_Stock_Add_Prods.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarProductos, connection))
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

        private void Btn_Delete_Del_Prods_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(TxtBox_ID_Del_Prods.Text))
            {
                MessageBox.Show("Introduzca un ID válido.");
                return;
            }

            // Conexión
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarProducto = @"DELETE FROM Productos WHERE ProductoID = '" + TxtBox_ID_Del_Prods.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarProducto, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado al producto.");
                    }
                }

                connection.Close();
            }
        }

        private void Btn_Update_Edit_Prods_Click(object sender, EventArgs e)
        {
            // Validaciones

            if (string.IsNullOrEmpty(TxtBox_ID_Edit_Prods.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Name_Add_Prods.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Desc_Add_Prods.Text))
            {
                MessageBox.Show("El Descripción está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Price_Add_Prods.Text))
            {
                MessageBox.Show("El Precio está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(TxtBox_Stock_Add_Prods.Text))
            {
                MessageBox.Show("El Stock está incorrecto o vacio.");
                return;
            }

            // Conexión.
            string connectionString = @"Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEditarProductos = @"UPDATE Productos
                                                    SET 
                                                        ProductoID = '" + TxtBox_ID_Edit_Prods.Text + "', " +
                                                        "NombreProducto = '" + TxtBox_Name_Edit_Prods.Text + "',  " +
                                                        "Descripcion = '" + TxtBox_Desc_Edit_Prods.Text + "', " +
                                                        "Precio = '" + TxtBox_Price_Edit_Prods.Text + "'" +
                                                        "Stock = '" + TxtBox_Stock_Edit_Prods.Text + "'" +
                                                        "WHERE ProductoID = '" + TxtBox_ID_Edit_Prods.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEditarProductos, connection))
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
