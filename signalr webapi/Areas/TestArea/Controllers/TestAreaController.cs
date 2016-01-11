using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace signalr_webapi.Areas.TestArea.Controllers
{
	[RouteArea("TestArea")]
    public class TestAreaController : Controller
    {
		[Route("~/")]
        [Route("~/TestArea")]
        public ActionResult Index()
        {
            return View();
        }
    }
}