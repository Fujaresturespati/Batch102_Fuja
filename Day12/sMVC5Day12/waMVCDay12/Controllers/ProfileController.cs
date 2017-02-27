using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace waMVCDay12.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public static List<Models.Profile> ListProfile = new List<Models.Profile>();
        public ActionResult Index()
        {
            return View(ListProfile);
        }
        public ActionResult Detail ()
        {
            Models.Profile item = new Models.Profile()
            {
                ID=1,
                NamaLengkap="Fuja bin L",
                Alamat="Indramayu",
                Hobby= "Belajar C#"
            };
            return View(item);
        }
        public ActionResult AddProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProfile(Models.Profile model)
        {
            ListProfile.Add(model);
            return View("Detail",model);
        }
    }
}