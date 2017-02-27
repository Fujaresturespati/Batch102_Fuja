using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waMVCDay12.Models;

namespace waMVCDay12.Controllers
{
    public class FakultasController : Controller
    {
        private DBSiakadEntities context = new DBSiakadEntities();
        // GET: Fakultas
        public ActionResult Index()
        {
            return View(context.FAKULTAS.ToList());
        }
        public ActionResult AddFakultas()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFakultas(FAKULTAS model)
        {
            if (ModelState.IsValid)
            {
                FAKULTAS item = new FAKULTAS()
                {
                    //FAKULTAS_ID = Guid.NewGuid(),
                    FAKULTAS_ID = model.FAKULTAS_ID,
                    KODE_FAKULTAS = model.KODE_FAKULTAS,
                    NAMA_FAKULTAS = model.NAMA_FAKULTAS
                };
                context.FAKULTAS.Add(item);
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
        public ActionResult Edit(string id)
        {
            int FAKULTAS_ID = int.Parse(id);
            FAKULTAS model = context.FAKULTAS.Find(FAKULTAS_ID);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (FAKULTAS model)
        {
            if (ModelState.IsValid)
            {
                FAKULTAS Item = context.FAKULTAS.Find(model.FAKULTAS_ID);
                    if (Item != null)
                    {
                        Item.KODE_FAKULTAS =model.KODE_FAKULTAS;
                        Item.NAMA_FAKULTAS =model.NAMA_FAKULTAS;
                    }
                try 
	{	        
		context.SaveChanges();
        return RedirectToAction("Index");
	}
	catch (Exception)
	{
		
		;
	}
            }
            return View(model);
        }
        public ActionResult Delete(string id)
        {
            int FAKULTAS_ID = int.Parse(id);
            FAKULTAS model = context.FAKULTAS.Find(FAKULTAS_ID);
            return View(model);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteFAKULTAS(string id)
        {
            int FaAKULTAS_ID = int.Parse(id);
            FAKULTAS model =context.FAKULTAS.Find(FaAKULTAS_ID);
            context.FAKULTAS.Remove(model);
            context.SaveChanges();
            return RedirectToAction("Index");             
        }
        public ActionResult Details(string id)
        {
            int FAKULTAS_ID = int.Parse(id);
            FAKULTAS model = context.FAKULTAS.Find(FAKULTAS_ID);
            return View(model);
        }
        //[HttpPost, ActionName("Details")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DetailsFAKULTAS(string id)
        //{
        //    int FaAKULTAS_ID = int.Parse(id);
        //    FAKULTAS model = context.FAKULTAS.Find(FaAKULTAS_ID);
        //    //context.FAKULTAS.Details(model);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}