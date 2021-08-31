using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;
using Electronica.Models;

namespace Electronica.Controllers
{
    public class AppliancesController : Controller
    {
        //
        // GET: /Appliances/

        private IDataService DataContext;

        public AppliancesController()
            : this(MainContainer.DataService())
        {

        }

        public AppliancesController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }
        public ActionResult Compact()
        {
            return View(DataContext.GetAllProducts());
        }

        public ActionResult BottomFreezer()
        {
            return View(DataContext.GetAllProducts());
        }

        public ActionResult TopFreezer()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult SideBySide()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult FrontLoader()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult TopLoader()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult TwinWash()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult Dryer()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult DishWasher()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult ArtCool()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult ConvertibleAc()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult FloorStandingAc()
        {
            return View();
        }
        public ActionResult SplitAc()
        {
            return View();
        }

        public ActionResult StandFreezer()
        {
            return View();
        }
        public ActionResult ChestFreezer()
        {
            return View();
        }

        public void AddProduct(Product product)
        {
            DataContext.AddProduct(product);
        }
    }
}