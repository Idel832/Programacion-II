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

        public Productos()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            using (var db = new MiContexto())
            {
                var categorias = db.Categorias.ToList();
                CBox_Catg_Add_Prods.DataSource = categorias;
                CBox_Catg_Add_Prods.DisplayMember = "NombreCategoria";
                CBox_Catg_Add_Prods.ValueMember = "CategoriaID";
            }
        }

        private void CargarProductos()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Productos
                    .Select(p => new
                    {
                        p.ProductoID,
                        p.NombreProducto,
                        p.Descripcion,
                        p.Precio,
                        p.Stock,
                        Categoria = p.Categoria != null ? p.Categoria.NombreCategoria : "(Sin categoría)"
                    })
                    .ToList();

                DGV_Prods.DataSource = lista;
            }
        }

        private void Btn_Cargar_Prods_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }


        private void Btn_Agregar_Add_Prods_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Prods.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            using (var db = new MiContexto())
            {
                var nuevo = new Producto
                {
                    NombreProducto = TxtBox_Name_Add_Prods.Text,
                    Descripcion = TxtBox_Desc_Add_Prods.Text,
                    Precio = decimal.Parse(TxtBox_Price_Add_Prods.Text),
                    Stock = int.Parse(TxtBox_Stock_Add_Prods.Text),
                    CategoriaID = (int?)CBox_Catg_Add_Prods.SelectedValue
                };

                db.Productos.Add(nuevo);
                db.SaveChanges();
            }

            MessageBox.Show("Producto agregado correctamente.");
            CargarProductos();
        }


        private void Btn_Delete_Del_Prods_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Del_Prods.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Del_Prods.Text);

            //Conexion
            using (var db = new MiContexto())
            {
                var producto = db.Productos.Find(id);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                db.Productos.Remove(producto);
                db.SaveChanges();
            }

            MessageBox.Show("Producto eliminado correctamente.");
            CargarProductos();
        }

        private void Btn_Update_Edit_Prods_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Edit_Prods.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Edit_Prods.Text);

            using (var db = new MiContexto())
            {
                var producto = db.Productos.Find(id);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                producto.NombreProducto = TxtBox_Name_Edit_Prods.Text;
                producto.Descripcion = TxtBox_Desc_Edit_Prods.Text;
                producto.Precio = decimal.Parse(TxtBox_Price_Edit_Prods.Text);
                producto.Stock = int.Parse(TxtBox_Stock_Edit_Prods.Text);
                producto.CategoriaID = (int?)CBox_Catg_Add_Prods.SelectedValue;

                db.SaveChanges();
            }

            MessageBox.Show("Producto actualizado correctamente.");
            CargarProductos();
        }
    }
}