using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TILAHA.Controllers.Models;

namespace TILAHA.Controllers
{
    public class PoistaController : Controller
    {
        // GET: Poista
        public ActionResult Index()
        {
            LaitekantaEntities entities = new LaitekantaEntities();
            List<Laite> model = entities.Laite.ToList();
            entities.Dispose();
            return View(model);
        }
    }
}