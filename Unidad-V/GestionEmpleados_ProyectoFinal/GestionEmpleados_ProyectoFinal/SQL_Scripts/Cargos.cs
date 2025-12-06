using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoEmpleados.SQL_Scripts
{
    internal class Cargos
    {
    }
}

[Table("Cargo")]
public class Cargo
{
    public int CargoID { get; set; }
    public string Nombre { get; set; }
}
