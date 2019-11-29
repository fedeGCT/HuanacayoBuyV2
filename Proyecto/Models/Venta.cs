using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime DiaVenta { get; set; }
        public float Subtotal { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
    }
}