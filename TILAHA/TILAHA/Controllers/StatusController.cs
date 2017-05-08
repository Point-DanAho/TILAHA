using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TILAHA.Controllers.Models;

namespace TILAHA.Controllers
{
    public class StatusController : Controller
    {
        // GET: Status
        public ActionResult Index()
        {
            LaitekantaEntities entities = new LaitekantaEntities();
            List<Status> model = entities.Status.ToList();
            entities.Dispose();
            return View(model);
          
        }
    }
}