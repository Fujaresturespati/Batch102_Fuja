using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waMVCDay12.Models;

namespace waMVCDay12.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(Student.AmbilData());
        }
        public ActionResult ListSiswa()
        {
            List<Student> listStudent = Student.AmbilData();
            ViewBag.ListSiswa = listStudent;
            ViewData["Judul"] = "Data list siswa";
            ViewData["AppTitle"] = "Application Student";
            ViewData["ListStudent"] = listStudent;

            return View();
        }
    }
}