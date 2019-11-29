using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarTodo()
        {
            List<Proyecto.Models.Categoria> elListado = new List<Models.Categoria>();


            CarritoBDEntities1 misDatos = new CarritoBDEntities1();
            foreach (tblCategoria elemento in misDatos.tblCategoria)
            {
                Proyecto.Models.Categoria objeto01 = new Models.Categoria();
                objeto01.Id = elemento.Id;
                objeto01.Nombre = elemento.Nombre;
                elListado.Add(objeto01);
            }


            return Json(elListado, JsonRequestBehavior.AllowGet);
        }
    }
}