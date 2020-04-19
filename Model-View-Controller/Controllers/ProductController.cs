using Model_View_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_View_Controller.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product product = new Product()
            {
                ProdctId = 1,
                Name = "Sai",
                Price = 10
            };
            return View(product);
        }

        public ActionResult List()
        {
            List<Product> products = new List<Product>()
            {
              new Product() {   ProdctId = 1, Name = "Sai", Price = 10 },
              new Product() {   ProdctId = 2, Name = "Ramesh", Price = 11.5M },
              new Product() {   ProdctId = 3, Name = "M", Price = 12 },
            };
            return View(products);
        }
    }
}