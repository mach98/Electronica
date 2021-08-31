using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Areas.Admin.Services;

namespace Electronica.Controllers
{
    public class TvAudioVideoController : Controller
    {
        //
        // GET: /TVAudioVideo/

        private IDataService DataContext;

        public TvAudioVideoController() : this(MainContainer.DataService())
        {
            
        }
        public TvAudioVideoController(IDataService DataContext)
        {
            this.DataContext = DataContext;
        }

        public ActionResult LedTv()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult PlasmaTv()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult ThreeDimensionTv()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult OledTv()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult SmartTv()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult SoundBars()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult HomeTheatres()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult HiFiSystem()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult BluRayPlayer()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult DvdPlayer()
        {
            return View(DataContext.GetAllProducts());
        }
        public ActionResult Projectors()
        {
            return View(DataContext.GetAllProducts());
        }
	}
}