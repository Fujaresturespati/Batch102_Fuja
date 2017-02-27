using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using clMVCDay13;

namespace WebApplication1.Controllers
{
    public class SiswaController : Controller
    {
        // GET: Siswa
        public ActionResult Index()
        {
            KampusContext DB = new KampusContext();
            List<Siswa> listView = DB.Siswas.ToList();

            return View(listView);
        }
    }
}