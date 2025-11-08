using Practica_3;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3.SQL_Scripts
{
    internal class Categoria
    {
    }
}

[Table("Categorias")]
public class Categoria
{
    public int CategoriaID { get; set; }
    public string NombreCategoria { get; set; }

    // Relacion con productos
    public virtual ICollection<Producto> Productos { get; set; }
}
