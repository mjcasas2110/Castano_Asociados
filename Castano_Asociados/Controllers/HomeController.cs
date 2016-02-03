using Castano_Asociados.Data;
using Castano_Asociados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Castano_Asociados.Controllers
{
    public class HomeController : Controller
    {
        CastanoAsociadosDb data;
        public HomeController(CastanoAsociadosDb data)
        {
            this.data = data;
        }

        public ActionResult Index()
        {
            Evento evento = new Evento();
            var a = data.Eventos.Where(e => e.Id == 1).SingleOrDefault();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}