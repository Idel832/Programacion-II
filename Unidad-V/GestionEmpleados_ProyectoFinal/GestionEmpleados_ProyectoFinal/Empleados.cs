using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeEmpleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            CargarCombos();

            //Longitud de datos
            TxtBox_Name_Add_Empleado.MaxLength = 150;
            TxtBox_Name_Edit_Empleado.MaxLength = 150;

            TxtBox_Salario_Add_Empleado.MaxLength = 13;
            TxtBox_Salario_Edit_Empleado.MaxLength = 13;

            TxtBox_ID_Del_Empleado.MaxLength = 9;
            TxtBox_ID_Edit_Empleado.MaxLength = 9;
        }



        //Integridad de datos
        private void TxtBox_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

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

        //Sincronizar CBoxes
        private void CargarCombos()
        {
            using (var db = new MiContexto())
            {
                //DEPARTAMENTOS
                var dptos = db.Departamento
                    .Select(d => new { d.DepartamentoID, d.Nombre })
                    .ToList();

                CB_Dpto_Add_Empleado.DataSource = dptos;
                CB_Dpto_Add_Empleado.DisplayMember = "Nombre";
                CB_Dpto_Add_Empleado.ValueMember = "DepartamentoID";
                CB_Dpto_Add_Empleado.SelectedIndex = -1;

                CB_Dpto_Edit_Empleado.DataSource = dptos.ToList();
                CB_Dpto_Edit_Empleado.DisplayMember = "Nombre";
                CB_Dpto_Edit_Empleado.ValueMember = "DepartamentoID";
                CB_Dpto_Edit_Empleado.SelectedIndex = -1;

                //CARGOS
                var cargos = db.Cargo
                    .Select(c => new { c.CargoID, c.Nombre })
                    .ToList();

                CB_Cargo_Add_Empleado.DataSource = cargos;
                CB_Cargo_Add_Empleado.DisplayMember = "Nombre";
                CB_Cargo_Add_Empleado.ValueMember = "CargoID";
                CB_Cargo_Add_Empleado.SelectedIndex = -1;

                CB_Cargo_Edit_Empleado.DataSource = cargos.ToList();
                CB_Cargo_Edit_Empleado.DisplayMember = "Nombre";
                CB_Cargo_Edit_Empleado.ValueMember = "CargoID";
                CB_Cargo_Edit_Empleado.SelectedIndex = -1;
            }
        }


        private void CargarEmpleados()
        {
            using (var db = new MiContexto())
            {
                var lista = db.Empleado
                    .Select(e => new
                    {
                        e.EmpleadoID,
                        e.Nombre,

                        Departamento = e.Departamento.Nombre,
                        Cargo = e.Cargo.Nombre,

                        e.FechaInicio,
                        e.Salario,

                        Estado = e.Estado ? "Vigente" : "No vigente",

                        //Tiempo en empresa
                        TiempoEmpresa = SqlFunctions.DateDiff("month", e.FechaInicio, DateTime.Now),

                        //AFP
                        AFP = e.Salario * 0.0287m,

                        //ARS
                        ARS = e.Salario * 0.0304m,

                        //ISR
                        ISR =
                            e.Salario * 12 <= 416220 ? 0 :
                            e.Salario * 12 <= 624329 ? ((e.Salario * 12 - 416220) * 0.15m) / 12 :
                            e.Salario * 12 <= 867123 ? (((e.Salario * 12 - 624329) * 0.20m) + 31216) / 12 :
                            (((e.Salario * 12 - 867123) * 0.25m) + 79776) / 12
                    })
                    .ToList()

                    .Select(x => new
                    {
                        x.EmpleadoID,
                        x.Nombre,
                        x.Departamento,
                        x.Cargo,
                        FechaInicio = x.FechaInicio.ToString("dd-MM-yyyy"),
                        x.Salario,
                        x.Estado,

                        //Convercion de meses a años y meses
                        TiempoEnEmpresa = (x.TiempoEmpresa / 12) + " años y " + (x.TiempoEmpresa % 12) + " meses",

                        AFP = x.AFP.ToString("N2"),
                        ARS = x.ARS.ToString("N2"),
                        ISR = x.ISR.ToString("N2"),

                        //Salario Neto
                        SalarioNeto = (x.Salario - x.AFP - x.ARS - x.ISR).ToString("N2")

                    })
                    .ToList();

                DGV_Empleado.DataSource = lista;
            }
        }


        private void Btn_Cargar_Client_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void LimpiarCamposAdd()
        {
            TxtBox_Name_Add_Empleado.Clear();
            TxtBox_Salario_Add_Empleado.Clear();
            CB_Cargo_Add_Empleado.SelectedIndex = -1;
            CB_Dpto_Add_Empleado.SelectedIndex = -1;
            CB_Estado_Add_Empleado.SelectedIndex = -1;
            DT_Fecha_Add_Empleado.Value = DateTime.Now;
        }

        private void Btn_Agregar_Add_Empleado_Click(object sender, EventArgs e)
        {
            //Validación
            if (string.IsNullOrWhiteSpace(TxtBox_Name_Add_Empleado.Text) ||
                CB_Dpto_Add_Empleado.SelectedIndex == -1 ||
                CB_Cargo_Add_Empleado.SelectedIndex == -1 ||
                CB_Estado_Add_Empleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos.");
                return;
            }

            if (!decimal.TryParse(TxtBox_Salario_Add_Empleado.Text, out decimal salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            if (salario <= 0)
            {
                MessageBox.Show("El salario debe ser mayor que 0.");
                return;
            }

            using (var db = new MiContexto())
            {
                var nuevoEmpleado = new Empleado
                {
                    Nombre = TxtBox_Name_Add_Empleado.Text,
                    DepartamentoID = Convert.ToInt32(CB_Dpto_Add_Empleado.SelectedValue),
                    CargoID = Convert.ToInt32(CB_Cargo_Add_Empleado.SelectedValue),
                    FechaInicio = DT_Fecha_Add_Empleado.Value.Date,
                    Salario = salario,
                    Estado = CB_Estado_Add_Empleado.SelectedIndex == 0,
                };

                db.Empleado.Add(nuevoEmpleado);
                db.SaveChanges();
            }

            MessageBox.Show("Empleado agregado correctamente.");
            LimpiarCamposAdd();
            CargarEmpleados();

        }

        private void LimpiarCamposDel()
        {
            TxtBox_ID_Del_Empleado.Clear();
        }

        private void Btn_Delete_Del_Empleado_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBox_ID_Del_Empleado.Text, out int id))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            //Confirmacion
            var confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar el empleado con ID {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (var db = new MiContexto())
            {
                var empleado = db.Empleado.Find(id);
                if (empleado == null)
                {
                    MessageBox.Show("Empleado no encontrado.");
                    return;
                }

                db.Empleado.Remove(empleado);
                db.SaveChanges();
            }

            MessageBox.Show("Empleado eliminado correctamente.");
            LimpiarCamposDel();
            CargarEmpleados();
        }

        private void LimpiarCamposEdit()
        {
            TxtBox_ID_Edit_Empleado.Clear();
            TxtBox_Name_Edit_Empleado.Clear();
            TxtBox_Salario_Edit_Empleado.Clear();
            CB_Dpto_Edit_Empleado.SelectedIndex = -1;
            CB_Cargo_Edit_Empleado.SelectedIndex = -1;
            CB_Estado_Edit_Empleado.SelectedIndex = -1;
            DT_Fecha_Edit_Empleado.Value = DateTime.Now;
        }

        private void Btn_Update_Edit_Empleado_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBox_ID_Edit_Empleado.Text, out int id))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            using (var db = new MiContexto())
            {
                var empleado = db.Empleado.Find(id);
                if (empleado == null)
                {
                    MessageBox.Show("Empleado no encontrado.");
                    return;
                }

                //Confirmacion
                var confirm = MessageBox.Show(
                    $"¿Está seguro que desea modificar los datos del empleado con ID {id}?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                //Validación
                if (string.IsNullOrWhiteSpace(TxtBox_Name_Edit_Empleado.Text) ||
                    CB_Dpto_Edit_Empleado.SelectedIndex == -1 ||
                    CB_Cargo_Edit_Empleado.SelectedIndex == -1 ||
                    CB_Estado_Edit_Empleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                    return;
                }

                if (!decimal.TryParse(TxtBox_Salario_Edit_Empleado.Text, out decimal salario))
                {
                    MessageBox.Show("El salario debe ser un número válido.");
                    return;
                }

                if (salario <= 0)
                {
                    MessageBox.Show("El salario debe ser mayor que 0.");
                    return;
                }

                //Asignar valores
                empleado.Nombre = TxtBox_Name_Edit_Empleado.Text;
                empleado.DepartamentoID = Convert.ToInt32(CB_Dpto_Edit_Empleado.SelectedValue);
                empleado.CargoID = Convert.ToInt32(CB_Cargo_Edit_Empleado.SelectedValue);
                empleado.FechaInicio = DT_Fecha_Edit_Empleado.Value.Date;
                empleado.Salario = salario;
                empleado.Estado = CB_Estado_Edit_Empleado.SelectedIndex == 0;

                db.SaveChanges();
            }

            MessageBox.Show("Empleado actualizado correctamente.");
            LimpiarCamposEdit();
            CargarEmpleados();
        }

        //Exportar CSV
        private void ExportEmpleados(DataGridView dgv, string rutaArchivo)
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

        private void Btn_Export_Table_Empleado_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            if (DGV_Empleado.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo CSV (*.csv)|*.csv";
                sfd.Title = "Guardar listado de empleados";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportEmpleados(DGV_Empleado, sfd.FileName);
                    MessageBox.Show("Tabla exportada correctamente.");
                }
            }
        }

    }
}
