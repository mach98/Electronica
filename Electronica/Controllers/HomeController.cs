using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;
using Electronica.Models;

namespace Electronica.Controllers
{
    public class HomeController : Controller
    {
        private IDataService DataContext;

        private ApplicationDbContext db = new ApplicationDbContext();

        public HomeController():this(MainContainer.DataService())
        {

        }

        public HomeController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }

        public ActionResult Index()
        {
           
            return View(DataContext.GetAllProducts());
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var contactUs = new ContactUs();
            return View(contactUs);
        }

        [HttpPost]
        public ActionResult Contact(ContactUs contactUs)
        {
            db.ContactsUs.Add(contactUs);
            db.SaveChanges();
            return View();
        }

        public ActionResult Details(int id)
        {
            var model = DataContext.FindProductById(id);
            return View(model);
        }


        public ActionResult Cart()
        {
            return View();
        }
    }
}