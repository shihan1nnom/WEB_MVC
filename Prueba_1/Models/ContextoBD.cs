using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Prueba_1.Models
{
    public class ContextoBD:DbContext
    {
        public ContextoBD() : base("BD_CETAF") { } // Especifica nombre de conexion string

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tipo_User> Tipo_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Tipo_User>().ToTable("Tipo_Usuario");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}