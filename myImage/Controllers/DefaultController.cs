using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myImage.Models;

namespace myImage.Controllers
{
    public class DefaultController : Controller
    {
        my_imageEntities db = new my_imageEntities();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult register()
        {
            return View();
        }
        [HttpPost]

        public ActionResult register(tbl_register r1)
        {
            db.tbl_register.Add(r1);
            db.SaveChanges();
            return RedirectToAction("login");
            
        }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(tbl_register r1)
        {
            var res = db.tbl_register.Where(x => x.username == r1.username && x.pass == r1.pass).SingleOrDefault();
            if (res != null)
            {
                Session["user"] = res.username;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.error = "Invalid user name or password ";
            }
            return View();
        }

        public ActionResult logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("login");
        }

        public ActionResult print()
        {
            return View();
        }
    }
}