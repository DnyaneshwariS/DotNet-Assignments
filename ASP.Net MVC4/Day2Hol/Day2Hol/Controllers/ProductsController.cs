using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2Hol.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            Models.Product p = new Models.Product();
            //pass a list of products to the
           return View(p.GetProducts());   
        }
    }
}