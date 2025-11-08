using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.SQL_Scripts
{
    internal class Producto
    {
    }
}

[Table("Productos")]
public class Producto
{
    public int ProductoID { get; set; }
    public string NombreProducto { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    // Clave foranea
    public int? CategoriaID { get; set; }
    public virtual Categoria Categoria { get; set; }
}
