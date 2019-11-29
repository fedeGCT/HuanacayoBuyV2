using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class ListaVenta
    {
        public int Id { get; set; }
        public Venta VentaId { get; set; }
        public Producto ProductoId { get; set; }
        public int Cantidad { get; set; }
        public float Total { get; set; }
    }
}