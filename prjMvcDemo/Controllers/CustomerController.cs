using prjMvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMvcDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            List<CCustomer> datas = (new CCustomerFactory()).queryAll();
            return View(datas);
        }

        public ActionResult create()
        {
            return View();
        }
    }
}