using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMvcDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            dbDemoEntities2 db = new dbDemoEntities2();
            var datas = from c in db.tProduct
                        select c;
            return View(datas);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( tProduct p)
        {
            dbDemoEntities2 db = new dbDemoEntities2();
            db.tProduct.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            dbDemoEntities2 db = new dbDemoEntities2();
            tProduct prod = db.tProduct.FirstOrDefault(t => t.fId == id);
            if (prod != null)
            {
                db.tProduct.Remove(prod);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}