using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsCatalog.Controllers
{
    public class ProductsController : Controller
    {
        readonly Products products = new Products();

        // GET: Products
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: Products/Details/[id]
        public ActionResult Details(int id)
        {
            Product product = products.ProductsList.Find(p => p.Id == id);

            return View(product);
        }
    }
}
