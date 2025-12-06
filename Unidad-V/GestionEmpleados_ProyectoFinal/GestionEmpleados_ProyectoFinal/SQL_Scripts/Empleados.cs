using ManejoEmpleados.SQL_Scripts;
using ManejoDeEmpleados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoEmpleados.SQL_Scripts
{
    internal class Empleados
    {
    }
}

[Table("Empleado")]
public class Empleado
{
    public int EmpleadoID { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaInicio { get; set; }
    public decimal Salario { get; set; }
    public Boolean Estado { get; set; }

    // Clave foranea
    public int? DepartamentoID { get; set; }
    public virtual Departamento Departamento { get; set; }

    public int? CargoID { get; set; }
    public virtual Cargo Cargo { get; set; }
}

