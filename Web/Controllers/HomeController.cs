

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Schema;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //ViewBag.Select = new[] { "30", "20" };
            return View();
        }
        [HttpPost]
        public ActionResult About(ClassString model)
        {
            //ViewBag.Message = model.Value;

            //var list = HttpContext.Request.Params.AllKeys.ToList();

            //ViewBag.List = list;
            //var select = new[] { "30", "20" };

            ViewBag.Select = model.Value;
            model = null;
            return View();
        }
        public ActionResult Contact()
        {
            if (Request["name"] != null)
            {
                ViewBag.Message = "You Say Request: " + Request["name"].ToString();
            }
            var model = new List<ListItem>
                        {
                            new ListItem {Value = "10", Text = "10 điểm"},
                            new ListItem {Value = "20", Text = "20 điểm"},
                            new ListItem {Value = "30", Text = "30 điểm"},
                        };
            var list = HttpContext.Request.Params.AllKeys.ToList();

            ViewBag.List = list;

            return View(model);

        }
    }
}