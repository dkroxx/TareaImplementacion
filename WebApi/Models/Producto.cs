using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Producto
    {
        public int Id { get; set; } = 0;
        public string SKU { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Existencias { get; set; } = 0;
        public bool Activo { get; set; } = false;
    }
}