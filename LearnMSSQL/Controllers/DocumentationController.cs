using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LearnMSSQL.Controllers
{
    [AllowAnonymous]
    public class DocumentationController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}
