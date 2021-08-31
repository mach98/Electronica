using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;

namespace Electronica.Controllers
{
    public class VacuumAirCleanerController : Controller
    {
        //
        // GET: /VacuumAirCleaner/
        private IDataService DataContext;

        public VacuumAirCleanerController() : this(MainContainer.DataService())
        {
            
        }
        public VacuumAirCleanerController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }

        public ActionResult Index()
        {
            return View(DataContext.GetAllProducts());
        }
	}
}