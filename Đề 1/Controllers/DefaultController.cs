using Đề_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using static System.Web.Razor.Parser.SyntaxConstants;

namespace Đề_1.Controllers
{
    public class DefaultController : Controller
    {
		Context db = new Context();

		public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderNav()
        {
            List<NavItems> navItems = db.NavItems.ToList();
            return PartialView("DaoQuangCuong_Header", navItems);
        }

        public ActionResult RenderProduct() 
        {
            List<Products> products = db.Products.OrderBy(x => x.UnitPrice).Take(4).ToList();
            return PartialView("DaoQuangCuong_MainContent", products);
        }

        public ActionResult RenderProductByName(string catName)
        {
            List<Products> products = new List<Products>();
            catName = catName.ToLower();
            foreach (var item in db.Categories)
            {
                if(item.NameVN.ToLower() == catName)
                {
                    products = db.Products.Where(h => h.CategoryId == item.Id).ToList();
                    break;
                }
            }
			return PartialView("DaoQuangCuong_MainContent", products);
		}

        public ActionResult SignUp()
        {
            return View();
        }

		[HttpPost]
        public ActionResult SignUp(Customers item)
		{
			if (ModelState.IsValid)
			{
                bool text = item.Password == item.RePassword;
				db.Customers.Add(item);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View(item);
			}
		}
	}
}