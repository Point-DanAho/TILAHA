using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TILAHA.Controllers.Models;

namespace TILAHA.Controllers
{
    public class SijaintiController : Controller
    {
        // GET: Sijainti
        public ActionResult Index()
        {
            LaitekantaEntities entities = new LaitekantaEntities();
            List<Sijainti> model = entities.Sijainti.ToList();
            entities.Dispose();
            return View(model);
           
        }
    }
}