using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_App1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProdIndex()
        { 
            return View();
        }

        public ActionResult ProdDisplay()
        {
            return View();
        }
    }
}