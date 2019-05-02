using DungeonsDragons.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DungeonsDragons.Controllers
{
    public class CharacterCreatorController : Controller
    {
        // GET: CharacterCreator
        public ActionResult Index()
        {
            return View("Characters");
        }

        public ActionResult NewCharacter()
        {
            ViewBag.Races = new SelectList(ApiService.GetRaces(), "Url", "Name");
            return View();
        }

        public JsonResult GetRaceTraits(string url)
        {
            return Json(ApiService.GetRaceTraits(url), JsonRequestBehavior.AllowGet);
        }
    }
}