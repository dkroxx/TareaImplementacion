using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ProductosController : ApiController
    {
        Producto ObjProducto;

        // GET api/productos
        public IEnumerable<Producto> Get()
        {
            List<Producto> ListaProductos = CargarProductos();
            return ListaProductos;
        }

        // GET api/productos/5
        public Producto Get(int id)
        {
            List<Producto> ListaProductos = CargarProductos();
            ObjProducto = new Producto();

            foreach (var item in ListaProductos)
            {
                if (item.Id == id)
                {
                    ObjProducto.Id = item.Id;
                    ObjProducto.SKU = item.SKU;
                    ObjProducto.Nombre = item.Nombre;
                    ObjProducto.Existencias = item.Existencias;
                    ObjProducto.Activo = item.Activo;
                }
            }

            return ObjProducto;
        }

        private List<Producto> CargarProductos()
        {
            List<Producto> Lista = new List<Producto>();

            ObjProducto = new Producto();
            ObjProducto.Id = 0;
            ObjProducto.SKU = "A-100";
            ObjProducto.Nombre = "Lapicero";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            ObjProducto = new Producto();
            ObjProducto.Id = 1;
            ObjProducto.SKU = "A-101";
            ObjProducto.Nombre = "Lapiz";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            ObjProducto = new Producto();
            ObjProducto.Id = 2;
            ObjProducto.SKU = "A-102";
            ObjProducto.Nombre = "Borrador";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            ObjProducto = new Producto();
            ObjProducto.Id = 3;
            ObjProducto.SKU = "A-103";
            ObjProducto.Nombre = "Maquinilla";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            ObjProducto = new Producto();
            ObjProducto.Id = 4;
            ObjProducto.SKU = "A-104";
            ObjProducto.Nombre = "Corrector";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            ObjProducto = new Producto();
            ObjProducto.Id = 5;
            ObjProducto.SKU = "A-105";
            ObjProducto.Nombre = "Regla";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            ObjProducto = new Producto();
            ObjProducto.Id = 6;
            ObjProducto.SKU = "A-106";
            ObjProducto.Nombre = "Compas";
            ObjProducto.Existencias = 13;
            ObjProducto.Activo = true;
            Lista.Add(ObjProducto);

            return Lista;
        }
    }
}
