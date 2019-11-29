using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarTodo()
        {
            List<Proyecto.Models.Producto> elListado = new List<Models.Producto>();


            CarritoBDEntities1 misDatos = new CarritoBDEntities1();
            foreach (tblProducto elemento in misDatos.tblProducto)
            {
                Proyecto.Models.Categoria aux01 = new Proyecto.Models.Categoria();
                aux01.Id = elemento.tblCategoria.Id;

                Proyecto.Models.Producto objeto01 = new Models.Producto();
                objeto01.Id = elemento.Id;
                objeto01.Nombre = elemento.Nombre;
                objeto01.Precio = Convert.ToByte(elemento.Precio);
                objeto01.FechaCreacion = Convert.ToDateTime(elemento.FechaCreacion);
                objeto01.CategoriaId = aux01;
                elListado.Add(objeto01);
            }


            return Json(elListado, JsonRequestBehavior.AllowGet);
        }
    }
}