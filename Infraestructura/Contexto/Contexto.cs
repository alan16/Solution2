using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Contexto
{
    public class Contexto:DbContext
    {
        public Contexto()
            : base(@"Server=ALAN-PC\SQLEXPRESS;Database=CommerceProd;Integrated Security=SSPI;Trusted_Connection=false;Integrated Security=True") 
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleCategoria> DetalleCategorias{ get; set; }
        public DbSet<Factura> Facturas { get; set; }

    }
}
