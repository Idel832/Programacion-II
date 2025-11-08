using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Practica_3.SQL_Scripts
{
    internal class MiContexto
    {
    }
}

public class MiContexto : DbContext
{
    public MiContexto() : base("Data Source=ENDERPC;Initial Catalog=Actividad_Practica_1;Integrated Security=True;") { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
}
