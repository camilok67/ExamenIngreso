using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenIngreso.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string SKU { get; set; }
        public string Descripción { get; set; }
        public string Valor { get; set; }
        public string Tienda { get; set; }
        public string Imagen { get; set; }

    }
}