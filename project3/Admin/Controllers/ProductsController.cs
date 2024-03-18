using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using project3.Models;

namespace project3.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private dbauctionsystemEntities db = new dbauctionsystemEntities();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Customer).Include(p => p.Status).Where(p=>p.Status.sta_ID == 1);
            ViewBag.Listpro = db.Products.Include(p => p.Customer).Include(p => p.Status).Where(p => p.Status.sta_ID != 1);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ListAu = db.Auctions.Where(a=>a.StartTime>= DateTime.UtcNow).ToList();
            return View(product);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inspect(int? id)
        {
            Product product = db.Products.Find(id);
            product.sta_ID = 2;
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
