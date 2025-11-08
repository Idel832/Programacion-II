using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.SQL_Scripts
{
    internal class Cliente
    {
    }
}

[Table("Clientes")]
public class Cliente
{
    public int ClienteID { get; set; }
    public string NombreCompleto { get; set; }
    public string CorreoElectronico { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
}
