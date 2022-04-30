using FirstWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebProject.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        WebAppTestEntities wbtest = new WebAppTestEntities() ;
       [HttpGet]
        public ActionResult Index()
        {
            var listim = wbtest.WebTest.ToList();
            return View(listim);
        }
        [HttpPost]
        public ActionResult Index(string name)
        {

            var wbtestim = new WebTest() { content = name };
            wbtest.WebTest.Add(wbtestim);          
            wbtest.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            var user = wbtest.WebTest.Find(id);
            wbtest.WebTest.Remove(user);
            wbtest.SaveChanges();
            return RedirectToAction("index");

        }
        public ActionResult Update(int id)
        {
            var contentim=wbtest.WebTest.Find(id);  
            return View(contentim);
        }

        
        [HttpPost]
        public ActionResult Update(int? id, string content)
        {
            var ktq = wbtest.WebTest.Find(id);
            ktq.content = content;
            wbtest.SaveChanges();
            return RedirectToAction("index");
                
        }



    }
}