using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;
using Electronica.ViewModels;
using Electronica.Helpers;
using Electronica.Models;
using System.Net;

namespace Electronica.Controllers
{
    public class MobileController : Controller
    {
        //
        // GET: /Mobile/

        private IDataService DataContext;

        public MobileController() : this(MainContainer.DataService())
        {
            
        }

        public MobileController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }



        public ActionResult Phones()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult Tablets()
        {
            return View(DataContext.GetAllProducts());
        }      
	}
}