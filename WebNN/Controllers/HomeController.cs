using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNN.Models;

namespace WebNN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ItemOrder> list;
            var model = new List<Item>();
            using (var db = new TestContext())
            {
                list = db.ItemOrders.Where(m => m.OrderId == 2).ToList();
                //var item = list.FirstOrDefault(m => m.Id == 1);
                //model.AddRange(list.Select(i => db.Items.Find(i.ItemId)));
                var list1 = db.Items.ToList();

                //model.AddRange(list.Select(i => list1.FirstOrDefault(m => m.ItemId == i.ItemId)));

                model.AddRange(list.Select(itemOrder => list1.FirstOrDefault(m => m.ItemId == itemOrder.ItemId)).Where(item => item != null));
                
                //foreach (var itemOrder in list)
                //{
                //    var item = list1.FirstOrDefault(m => m.ItemId == itemOrder.ItemId);
                //    if (item != null)
                //    {
                //        model.Add(item);
                //    }
                //}
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}