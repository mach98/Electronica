using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;

namespace Electronica.Controllers
{
    public class ComputerProductsController : Controller
    {
        //
        // GET: /ComputerProducts/

        private IDataService DataContext;

       public ComputerProductsController() : this(MainContainer.DataService())
        {
            
        }
        public ComputerProductsController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }

        public ActionResult Laptops()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult Monitors()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult ExternalHardDisk()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult FlashDrive()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult Multimedia()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult OpticalStorage()
        {
            return View(DataContext.GetAllProducts());
        }
	}
}