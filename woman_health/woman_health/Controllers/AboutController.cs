using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using woman_health.Models;

namespace woman_health.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            StudentContext db=new StudentContext();
            var itm = db.StudentForm.ToList();
            return View(itm);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentForm s)
        {
            StudentContext db=new StudentContext();
            db.StudentForm.Add(s);
            return View();
        }
	}
}