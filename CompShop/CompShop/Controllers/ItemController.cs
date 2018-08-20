using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompShop.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            List<string> itemListObj = new List<string>();
            itemListObj.Add("Refrigerator");
            itemListObj.Add("Television");
            itemListObj.Add("Microwave");
            itemListObj.Add("Washing machine");
            itemListObj.Add("Dish Washer");
            itemListObj.Add("DVD player");
            ViewBag.ItemList = "CompShop Item List";
            ViewBag.Items = itemListObj;
            return View();
        }
        
        //returns empty result
        public EmptyResult EmptyEx()
        {
            ViewBag.ItemList = "CompShop Item List";
            return new EmptyResult();
        }

        //redirects to another action method or action method in another controller
        public RedirectResult RedirectEx()
        {
            return Redirect("/Home/Contact");
        }

        //redirects to another action method or action method in another controller
        public RedirectResult RedirectEx1()
        {
            return Redirect("/Item/Index");
        }

    }
}