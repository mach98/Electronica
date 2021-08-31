using Electronica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Electronica.Controllers
{
    public class AddToCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Add(Product product)
        {
            if (Session["cart"] == null)
            {
                List<Product> li = new List<Product>();

                li.Add(product);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = 1;
            }
            else
            {
                List<Product> li = (List<Product>)Session["cart"];
                li.Add(product);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;
            }
            return RedirectToAction("Index", "Home");


        }
        public ActionResult Myorder()
        {

            return View((List<Product>)Session["cart"]);

        }
        public ActionResult Remove(Product product)
        {
            List<Product> li = (List<Product>)Session["cart"];
            li.RemoveAll(x => x.ProductId == product.ProductId);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return RedirectToAction("Myorder", "AddToCart");

        }
    }
}