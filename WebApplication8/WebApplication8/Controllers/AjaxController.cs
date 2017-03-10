using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{

    public class AjaxController : Controller
    {
        static List<Producto> prodList = new List<Producto>();

        public ActionResult Index()
        {
            Producto p1 = new Producto { ProdCode = "P001", ProdName = "Mobile", ProdQty = 75 };
            Producto p2 = new Producto { ProdCode = "P002", ProdName = "Laptop", ProdQty = 125 };
            Producto p3 = new Producto { ProdCode = "P003", ProdName = "Netbook", ProdQty = 100 };
            prodList.Add(p1);
            prodList.Add(p2);
            prodList.Add(p3);
            return View();
        }

        public PartialViewResult ShowDetails()
        {
        
            System.Threading.Thread.Sleep(3000);
            string code = Request.Form["txtCode"];
            Producto prod = new Producto();
            foreach (Producto p in prodList)
            {
                if (p.ProdCode == code)
                {
                    prod = p;
                    break;
                }
            }
            return PartialView("ShowDetails", prod);
        }

    }
}