using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CargarMarcas()
        {
            var marcas = new List<dynamic>();
            marcas.Add(new { Id = "ford", nombre = "ford" });
            marcas.Add(new { Id = "renault", nombre = "renault" });
            marcas.Add(new { Id = "citroen", nombre = "citroen" });
            marcas.Add(new { Id = "peugeot", nombre = "peugeot" });

            return Json(marcas, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CargarModelos(string marca)
        {
            var modelos = new List<dynamic>();
            modelos.Add(new { marca = "ford", nombre = "ka" });
            modelos.Add(new { marca = "ford", nombre = "focus" });
            modelos.Add(new { marca = "ford", nombre = "fiesta" });
            modelos.Add(new { marca = "citroen", nombre = "c3" });
            modelos.Add(new { marca = "citroen", nombre = "c4" });
            modelos.Add(new { marca = "citroen", nombre = "c5" });
            modelos.Add(new { marca = "renault", nombre = "clio" });
            modelos.Add(new { marca = "renault", nombre = "megane" });
            modelos.Add(new { marca = "renault", nombre = "sandero" });

            return Json(modelos.Where(m=>m.marca == marca), JsonRequestBehavior.AllowGet);
        }

    }
}
