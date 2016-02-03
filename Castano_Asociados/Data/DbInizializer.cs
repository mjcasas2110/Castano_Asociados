using Castano_Asociados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Castano_Asociados.Data
{
    public class DbInizializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CastanoAsociadosDb>
    {
        protected override void Seed(CastanoAsociadosDb context)
        {
            var clientes = new List<Cliente>
            {
            new Cliente{Nombre="Holiday Inn",Email="holiday@info.com",Pagina_Web="www.holiday.com"},
            new Cliente{Nombre="Holiday Inn Express",Email="holidayexpress@info.com",Pagina_Web="www.holiday-express.com"},
            new Cliente{Nombre="Hotel Presidente",Email="presidente@info.com",Pagina_Web="www.presidente.com"},
            };
            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();

            var eventos = new List<Evento>
            {
            new Evento{IdCliente=1,Fecha_Inicio=DateTime.Parse("01/01/2016"),Fecha_Fin=DateTime.Parse("01/01/2016")},
            new Evento{IdCliente=1,Fecha_Inicio=DateTime.Parse("02/01/2016"),Fecha_Fin=DateTime.Parse("04/01/2016")},
            new Evento{IdCliente=2,Fecha_Inicio=DateTime.Parse("04/01/2016"),Fecha_Fin=DateTime.Parse("05/01/2016")},
            new Evento{IdCliente=3,Fecha_Inicio=DateTime.Parse("04/01/2016"),Fecha_Fin=DateTime.Parse("07/01/2016")},
            new Evento{IdCliente=3,Fecha_Inicio=DateTime.Parse("15/01/2016"),Fecha_Fin=DateTime.Parse("17/01/2016")},
            };

            eventos.ForEach(s => context.Eventos.Add(s));
            context.SaveChanges();

            var equipos = new List<Equipo>
            {
            new Equipo{Nombre="Proyector Epson",Descripcion="Proyector x17"},
            new Equipo{Nombre="Pantalla 1620",Descripcion="Pantalla de 2 mts."},
            new Equipo{Nombre="Mic Volante",Descripcion="Mic volante XX"},
            };
            equipos.ForEach(s => context.Equipos.Add(s));
            context.SaveChanges();
        }
    }
}