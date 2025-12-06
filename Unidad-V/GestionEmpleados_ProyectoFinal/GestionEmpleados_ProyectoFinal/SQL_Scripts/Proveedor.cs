using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEmpleados.SQL_Scripts
{
    internal class Proveedor
    {
    }
}

[Table("Proveedores")] 
public class Proveedor
{
    public int ProveedorID { get; set; }
    public string NombreProveedor { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }
}