using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class ListaVentaController : Controller
    {
        // GET: ListaVenta
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarVentas(int argCodigoProducto, int argCodigoVenta)
        {
            List<Proyecto.Models.ListaVenta> elListado = new List<Models.ListaVenta>();


            CarritoBDEntities1 misDatos = new CarritoBDEntities1();
            foreach (tblListaVenta elemento in misDatos.tblListaVenta.Where(x => x.ProductoId == argCodigoProducto & x.VentaId == argCodigoVenta))
            {
                Proyecto.Models.Venta aux01 = new Proyecto.Models.Venta();
                aux01.Id = elemento.tblVenta.Id;

                Proyecto.Models.Producto aux02 = new Proyecto.Models.Producto();
                aux02.Id = elemento.tblProducto.Id;

                Proyecto.Models.ListaVenta objeto01 = new Models.ListaVenta();
                objeto01.Id = elemento.Id;
                objeto01.VentaId = aux01;
                objeto01.ProductoId = aux02;
                objeto01.Cantidad = Convert.ToInt16(elemento.Cantidad);
                objeto01.Total = Convert.ToByte(elemento.Total);

                elListado.Add(objeto01);
            }


            return Json(elListado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult BuscarxCod(int argCodigo)
        {
            List<Proyecto.Models.ListaVenta> elListado = new List<Models.ListaVenta>();

            CarritoBDEntities1 misDatos = new CarritoBDEntities1();
            foreach (tblListaVenta elemento in misDatos.tblListaVenta.Where(x => x.Id == argCodigo))
            {
                Proyecto.Models.Venta aux01 = new Proyecto.Models.Venta();
                aux01.Id = elemento.tblVenta.Id;

                Proyecto.Models.Producto aux02 = new Proyecto.Models.Producto();
                aux02.Id = elemento.tblProducto.Id;

                Proyecto.Models.ListaVenta objeto01 = new Models.ListaVenta();
                objeto01.Id = elemento.Id;
                objeto01.VentaId = aux01;
                objeto01.ProductoId = aux02;
                objeto01.Cantidad = Convert.ToInt16(elemento.Cantidad);
                objeto01.Total = Convert.ToByte(elemento.Total);

                elListado.Add(objeto01);
            }

            return Json(elListado, JsonRequestBehavior.AllowGet);
        }


    }
}