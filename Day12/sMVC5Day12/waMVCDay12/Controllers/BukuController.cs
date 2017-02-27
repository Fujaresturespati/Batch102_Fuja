using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waMVCDay12.Models;

namespace waMVCDay12.Controllers
{
    public class BukuController : Controller
    {
        private DBKoperasiBukuEntities context = new DBKoperasiBukuEntities();
        // GET: Buku
        public ActionResult Index()
        {
            return View(context.BUKU.ToList());
        }
        public ActionResult AddBuku()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBuku(BUKU model)
        {
            if (ModelState.IsValid)
            {
                BUKU item = new BUKU()
                {
                   // BUKU_ID = int.Parse(Guid.NewGuid()),
                    KODE_BUKU = model.KODE_BUKU,
                    NAMA_BUKU = model.NAMA_BUKU,
                    TAHUN_PENERBIT =model.TAHUN_PENERBIT,
                    JML_HAL_BUKU = model.JML_HAL_BUKU,
                    KODE_JENIS = model.KODE_JENIS
                };
                context.BUKU.Add(item);
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    
                }
            }
            return View(model);
        }
    }
}