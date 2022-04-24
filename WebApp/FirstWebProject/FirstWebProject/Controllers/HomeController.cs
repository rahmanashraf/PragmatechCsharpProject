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
       
        public ActionResult Index()
        {
            var b=Request.QueryString["name"];
            
            var wbtestim=new WebTest() { content = b };
            wbtest.WebTest.Add(wbtestim);
            ViewBag.list = wbtest.WebTest.ToList();
            wbtest.SaveChanges();
            return View();
        }
      
        


    }
}