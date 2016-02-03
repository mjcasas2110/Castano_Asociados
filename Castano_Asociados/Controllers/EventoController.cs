using Castano_Asociados.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Castano_Asociados.Controllers
{
    public class EventoController : Controller
    {
        CastanoAsociadosDb data;
        public EventoController(CastanoAsociadosDb data)
        {
            this.data = data;
        }
        // GET: Evento
        public ActionResult Index(DateTime? FechaInicio, DateTime? FechaFin)
        {
            var inicio = FechaInicio ?? DateTime.Today.AddMonths(-1);
            var fin = FechaFin ?? DateTime.Today;
            var eventos = data.Eventos.Where(e => e.FechaInicio <= inicio && e.FechaFin >= fin );
            return View(eventos);
        }
    }
}