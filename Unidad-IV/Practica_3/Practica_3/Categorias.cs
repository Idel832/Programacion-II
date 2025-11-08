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
        private void CargarCategorias()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Categorias
                    .Select(c => new
                    {
                        c.CategoriaID,
                        c.NombreCategoria
                    })
                    .ToList();

                DGV_Catg.DataSource = lista;
            }
        }

        private void Btn_Cargar_Catg_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void Btn_Agregar_Add_Catg_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Catg.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.");
                return;
            }

            //Conexion
            using (var db = new MiContexto())
            {
                var nuevaCat = new Categoria
                {
                    NombreCategoria = TxtBox_Name_Add_Catg.Text
                };

                db.Categorias.Add(nuevaCat);
                db.SaveChanges();
            }

            MessageBox.Show("Categoría agregada correctamente.");
            TxtBox_Name_Add_Catg.Clear();
            CargarCategorias();
        }

        private void Btn_Delete_Del_Catg_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Del_Catg.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Del_Catg.Text);

            //Conexion
            using (var db = new MiContexto())
            {
                var categoria = db.Categorias.Find(id);
                if (categoria == null)
                {
                    MessageBox.Show("Categoría no encontrada.");
                    return;
                }

                //Borrar prodcutos asociados a la categoria
                db.Productos.RemoveRange(categoria.Productos);

                db.Categorias.Remove(categoria);
                db.SaveChanges();
            }

            MessageBox.Show("Categoría eliminada correctamente.");
            TxtBox_ID_Del_Catg.Clear();
            CargarCategorias();
        }

        private void Btn_Update_Edit_Catg_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Edit_Catg.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Edit_Catg.Text);

            //Conexion
            using (var db = new MiContexto())
            {
                var categoria = db.Categorias.Find(id);
                if (categoria == null)
                {
                    MessageBox.Show("Categoría no encontrada.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtBox_Name_Edit_Catg.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }

                categoria.NombreCategoria = TxtBox_Name_Edit_Catg.Text;
                db.SaveChanges();
            }

            MessageBox.Show("Categoría actualizada correctamente.");
            TxtBox_ID_Edit_Catg.Clear();
            TxtBox_Name_Edit_Catg.Clear();
            CargarCategorias();
        }
    }
}