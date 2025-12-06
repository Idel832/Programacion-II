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
    internal class Departamentos
    {
    }
}

[Table("Departamento")]
public class Departamento
{
    public int DepartamentoID { get; set; }
    public string Nombre { get; set; }
}
