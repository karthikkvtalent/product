using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using product.Business_Access_Layer;
using product.Repository;
using product.IRepositotry;
using product.Models;

namespace product.Controllers
{
    public class HomeController : Controller
    {
         BAL Iobj = new BAL(new Reposite());
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product pro,HttpPostedFileBase Image)
        {
            pro.Image = new byte[Image.ContentLength];
            Image.InputStream.Read(pro.Image, 0, Image.ContentLength);
            Iobj.insertproduct(pro);
            return RedirectToAction("Show");
            
        }
        public ActionResult Show()
        {
            return View(Iobj.GetProducts());
        }
            
    }
}