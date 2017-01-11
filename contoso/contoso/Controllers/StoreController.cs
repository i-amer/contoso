using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace contoso.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hi from the Store Controller --> index page";
        }
        public string Browse()
        {
            return "Hi from the Store Controller --> browse page";
        }
        public string Details()
        {
            return "Hi from the Store Controller --> details page";
        }
    }
}