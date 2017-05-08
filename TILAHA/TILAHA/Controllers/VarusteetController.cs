using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TILAHA.Controllers.Models;

namespace TILAHA.Controllers
{
    public class VarusteetController : Controller
    {
        // GET: Varusteet
        public ActionResult Index()
        {
            LaitekantaEntities entities = new LaitekantaEntities();
            List<Varuste> model = entities.Varuste.ToList();
            entities.Dispose();
            return View(model);
           
        }
    }
}