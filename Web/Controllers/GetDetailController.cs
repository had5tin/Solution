using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Web.Controllers
{
    public class GetDetailController : Controller
    {
        //
        // GET: /GetDetail/
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Product()
        {
            var model = new ListItem { Value = "1", Text = "2" };
            return PartialView("_Product", model);
        }
        public PartialViewResult Feature()
        {
            var model = new ListItem { Value = "3", Text = "4" };
            return PartialView("_Feature", model);
        }
    }
}