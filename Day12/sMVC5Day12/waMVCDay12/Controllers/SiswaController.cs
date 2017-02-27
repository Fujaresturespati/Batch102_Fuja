using clMVCDay13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace waMVCDay12.Controllers
{
    public class SiswaController : Controller
    {
       // private KampusContext context = new KampusContext();
        // GET: Siswa
        public ActionResult Index()
        {
            KampusContext DB = new KampusContext();
            List<Siswa> listView = DB.Siswas.ToList();

            return View(listView);
        }
        public ActionResult AddSiswa()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSiswa(Siswa model)
        {
            if (ModelState.IsValid)
            {
                KampusContext context = new KampusContext();
                Siswa item = new Siswa()
                {
                    //FAKULTAS_ID = Guid.NewGuid(),
                    SiswaId = model.SiswaId,
                    Siswa_Name = model.Siswa_Name,
                    Age = model.Age,
                    Gender = model.Gender,
                    ProgramId = model.ProgramId,
                    Program = model.Program
                };
                context.Siswas.Add(item);
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    string s = e.Message;
                }
            }
            return View(model);
        }
        //public ActionResult Edit(string id)
        //{
        //    int Siswa_ID = int.Parse(id);
        //    Siswa model = context.Siswa.Find(Siswa_ID);
        //    return View(model);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(FAKULTAS model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        FAKULTAS Item = context.FAKULTAS.Find(model.FAKULTAS_ID);
        //        if (Item != null)
        //        {
        //            Item.KODE_FAKULTAS = model.KODE_FAKULTAS;
        //            Item.NAMA_FAKULTAS = model.NAMA_FAKULTAS;
        //        }
        //        try
        //        {
        //            context.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        catch (Exception)
        //        {

        //            ;
        //        }
        //    }
        //    return View(model);
        //}
        //public ActionResult Delete(string id)
        //{
        //    int Siswa_ID = int.Parse(id);
        //    Siswa model = context.Siswa.Find(Siswa_ID);
        //    return View(model);
        //}
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteFAKULTAS(string id)
        //{
        //    int FaAKULTAS_ID = int.Parse(id);
        //    FAKULTAS model = context.FAKULTAS.Find(FaAKULTAS_ID);
        //    context.FAKULTAS.Remove(model);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public ActionResult Details(string id)
        //{
        //    int FAKULTAS_ID = int.Parse(id);
        //    FAKULTAS model = context.FAKULTAS.Find(FAKULTAS_ID);
        //    return View(model);
        //}
    }
} 