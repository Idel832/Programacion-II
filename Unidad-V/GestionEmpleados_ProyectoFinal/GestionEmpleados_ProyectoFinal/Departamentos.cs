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
    public partial class Departamentos : Form
    {

        public Departamentos()
        {
            InitializeComponent();

            //Longitud de datos
            TxtBox_Name_Add_Dpto.MaxLength = 100;
            TxtBox_Name_Edit_Dpto.MaxLength = 100;

            TxtBox_ID_Del_Dpto.MaxLength = 9;
            TxtBox_ID_Edit_Dpto.MaxLength = 9;
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

        private void CargarDepartamentos()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Departamento
                    .Select(p => new
                    {
                        p.DepartamentoID,
                        p.Nombre
                    })
                    .ToList();

                DGV_Dpts.DataSource = lista;
            }
        }

        private void Btn_Cargar_Dpto_Click(object sender, EventArgs e)
        {
            CargarDepartamentos();
        }
        private void LimpiarCamposAdd()
        {
            TxtBox_Name_Add_Dpto.Clear();
        }

        private void Btn_Agregar_Add_Dpto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Dpto.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            using (var db = new MiContexto())
            {
                var nuevo = new Departamento
                {
                    Nombre = TxtBox_Name_Add_Dpto.Text,
                };

                db.Departamento.Add(nuevo);
                db.SaveChanges();
            }

            MessageBox.Show("Departamento agregado correctamente.");
            LimpiarCamposAdd();
            CargarDepartamentos();
        }

        private void LimpiarCamposDelete()
        {
            TxtBox_ID_Del_Dpto.Clear();
        }

        private void Btn_Delete_Del_Dpto_Click(object sender, EventArgs e)
        {
            //Validación
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Del_Dpto.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Del_Dpto.Text);

            //Confirmacion
            var confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar el departamento con ID {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (var db = new MiContexto())
            {
                var departamento = db.Departamento.Find(id);
                if (departamento == null)
                {
                    MessageBox.Show("Departamento no encontrado.");
                    return;
                }

                db.Departamento.Remove(departamento);
                db.SaveChanges();
            }

            MessageBox.Show("Departamento eliminado correctamente.");
            LimpiarCamposDelete();
            CargarDepartamentos();
        }

        private void LimpiarCamposEdit()
        {
            TxtBox_ID_Edit_Dpto.Clear();
            TxtBox_Name_Edit_Dpto.Clear();
        }

        private void Btn_Update_Edit_Dpto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBox_ID_Edit_Dpto.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtBox_Name_Edit_Dpto.Text))
            {
                MessageBox.Show("Debe introducir un nombre válido.");
                return;
            }

            int id = int.Parse(TxtBox_ID_Edit_Dpto.Text);

            using (var db = new MiContexto())
            {
                var departamento = db.Departamento.Find(id);
                if (departamento == null)
                {
                    MessageBox.Show("Departamento no encontrado.");
                    return;
                }

                //Confirmacion
                var confirm = MessageBox.Show(
                    $"¿Está seguro que desea modificar el departamento con ID {id}?",
                    "Confirmar actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                departamento.Nombre = TxtBox_Name_Edit_Dpto.Text;

                db.SaveChanges();
            }

            MessageBox.Show("Departamento actualizado correctamente.");
            LimpiarCamposEdit();
            CargarDepartamentos();
        }



        //Exportar CSV
        private void ExportDpts(DataGridView dgv, string rutaArchivo)
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

        private void Btn_Export_Table_Departamentos_Click(object sender, EventArgs e)
        {
            CargarDepartamentos();
            if (DGV_Dpts.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.Title = "Guardar listado de departamentos";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDpts(DGV_Dpts, sfd.FileName);
                    MessageBox.Show("Tabla exportada correctamente.");
                }
            }
        }
    }
}