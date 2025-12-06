using ManejoEmpleados.SQL_Scripts;
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

namespace ManejoDeEmpleados
{
    public partial class Cargos : Form
    {
        public Cargos()
        {
            InitializeComponent();

            //Longitud de datos
            TxtBox_Name_Add_Cargo.MaxLength = 100;
            TxtBox_Name_Edit_Cargo.MaxLength = 100;

            TxtBox_ID_Del_Cargo.MaxLength = 9;
            TxtBox_ID_Edit_Cargo.MaxLength = 9;

        }

        //Integridad de datos
        private void TxtBox_Letras_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void CargarCargos()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Cargo
                    .Select(c => new
                    {
                        c.CargoID,
                        c.Nombre
                    })
                    .ToList();

                DGV_Crgs.DataSource = lista;
            }
        }


        private void Btn_Cargar_Cargo_Click(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void LimpiarCamposAdd()
        {
            TxtBox_Name_Add_Cargo.Clear();
        }
        private void Btn_Agregar_Add_Cargo_Click(object sender, EventArgs e)
        {
            //Validacion
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Cargo.Text))
            {
                MessageBox.Show("El nombre del cargo no puede estar vacío.");
                return;
            }

            //Conexion
            using (var db = new MiContexto())
            {
                var nuevaCat = new Cargo
                {
                    Nombre = TxtBox_Name_Add_Cargo.Text
                };

                db.Cargo.Add(nuevaCat);
                db.SaveChanges();
            }

            MessageBox.Show("Cargo agregada correctamente.");
            LimpiarCamposAdd();
            CargarCargos();
        }
        private void LimpiarCamposDel()
        {
            TxtBox_ID_Del_Cargo.Clear();
        }
        private void Btn_Delete_Del_Cargo_Click(object sender, EventArgs e)
        {
            {
                // Validación
                if (string.IsNullOrWhiteSpace(TxtBox_ID_Del_Cargo.Text))
                {
                    MessageBox.Show("Debe introducir un ID válido.");
                    return;
                }

                int id = int.Parse(TxtBox_ID_Del_Cargo.Text);

                //Confirmacion
                DialogResult confirm = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el cargo con ID {id}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                    return;

                // Conexión
                using (var db = new MiContexto())
                {
                    var cargo = db.Cargo.Find(id);
                    if (cargo == null)
                    {
                        MessageBox.Show("Cargo no encontrada.");
                        return;
                    }

                    bool tieneEmpleados = db.Empleado.Any(emp => emp.CargoID == cargo.CargoID);
                    if (tieneEmpleados)
                    {
                        MessageBox.Show("Este cargo no puede eliminarse porque tiene empleados asociados.");
                        return;
                    }

                    db.Cargo.Remove(cargo);
                    db.SaveChanges();
                }

                MessageBox.Show("Cargo eliminado correctamente.");
                LimpiarCamposDel();
                CargarCargos();
            }
        }

        private void LimpiarCamposEdit()
        {
            TxtBox_ID_Edit_Cargo.Clear();
            TxtBox_Name_Edit_Cargo.Clear();
        }
        private void Btn_Update_Edit_Cargo_Click(object sender, EventArgs e)
        {
            // Validación
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Edit_Cargo.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Edit_Cargo.Text);

            using (var db = new MiContexto())
            {
                var cargo = db.Cargo.Find(id);
                if (cargo == null)
                {
                    MessageBox.Show("Cargo no encontrado.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtBox_Name_Edit_Cargo.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }

                // Confirmación
                var confirm = MessageBox.Show(
                    $"¿Está seguro que desea modificar el cargo con ID {id}?",
                    "Confirmar actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                cargo.Nombre = TxtBox_Name_Edit_Cargo.Text;
                db.SaveChanges();
            }

            MessageBox.Show("Cargo actualizado correctamente.");
            LimpiarCamposEdit();
            CargarCargos();
        }

        //Exportar CSV
        private void ExportCargos(DataGridView dgv, string rutaArchivo)
        {
            var sb = new StringBuilder();

            var encabezados = dgv.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", encabezados.Select(c => c.HeaderText)));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var celdas = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", celdas.Select(c => c.Value?.ToString().Replace(",", " "))));
                }
            }

            System.IO.File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
        }
        private void Btn_Export_Table_Cargos_Click(object sender, EventArgs e)
        {
            CargarCargos();
            if (DGV_Crgs.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.Title = "Guardar listado de cargos";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportCargos(DGV_Crgs, sfd.FileName);
                    MessageBox.Show("Tabla exportada correctamente.");
                }
            }
        }
    }
}