using Castano_Asociados.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Castano_Asociados.Data
{
    public class CastanoAsociadosDb : DbContext
    {
        public CastanoAsociadosDb() : base("CastanoAsociadosDb")
        {

        }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}