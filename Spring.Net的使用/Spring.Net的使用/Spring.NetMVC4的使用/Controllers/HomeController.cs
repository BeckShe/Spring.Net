using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spring.NetMVC4的使用.Controllers
{
    public class HomeController : Controller
    {
        public TestClass testClassServer { get; set; }
        // GET: Home
        public ActionResult Index()
        {
            return Content(testClassServer.TestGet());
        }
    }
}