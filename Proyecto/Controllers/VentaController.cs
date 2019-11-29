using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarTodo()
        {
            List<Proyecto.Models.Venta> elListado = new List<Models.Venta>();


            CarritoBDEntities1 misDatos = new CarritoBDEntities1();
            foreach (tblVenta elemento in misDatos.tblVenta)
            {
                Proyecto.Models.Venta objeto01 = new Models.Venta();
                objeto01.Id = elemento.Id;
                objeto01.DiaVenta = Convert.ToDateTime(elemento.DiaVenta);
                objeto01.Subtotal = Convert.ToByte(elemento.Subtotal);
                objeto01.Iva = Convert.ToByte(elemento.Iva);
                objeto01.Total = Convert.ToByte(elemento.Total);
                elListado.Add(objeto01);
            }


            return Json(elListado, JsonRequestBehavior.AllowGet);
        }
    }
}