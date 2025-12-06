using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoEmpleados.SQL_Scripts
{
    internal class MiContexto
    {
    }
}

public class MiContexto : DbContext
{
    public MiContexto() : base("Data Source=ENDERPC;Initial Catalog=ManejoEmpleados;Integrated Security=True;") { }

    public DbSet<Empleado> Empleado { get; set; }
    public DbSet<Cargo> Cargo { get; set; }
    public DbSet<Departamento> Departamento { get; set; }
}
