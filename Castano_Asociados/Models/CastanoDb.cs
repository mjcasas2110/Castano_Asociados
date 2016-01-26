using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Castano_Asociados.Models
{
    public class CastanoDb : DbContext
    {
        public CastanoDb()
            : base("name=CastanoAsociadosDb")
        {

        }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}