using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto = new ProductoModel();
            producto.Id = 1;
            producto.Descripcion = "Pizza 6 Quesos";

            var producto1 = new ProductoModel();
            producto1.Id = 2;
            producto1.Descripcion = "Pizza con Peperoni";

            var producto2 = new ProductoModel();
            producto2.Id = 3;
            producto2.Descripcion = "Pizza con Jamón";

            var producto3 = new ProductoModel();
            producto3.Id = 4;
            producto3.Descripcion = "Pizza Suprema";

            var listadeProducto = new List<ProductoModel>();
            listadeProducto.Add(producto);
            listadeProducto.Add(producto1);
            listadeProducto.Add(producto2);
            listadeProducto.Add(producto3);

            return View(listadeProducto);
        }

        
    }
}