using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCms.Models;

namespace MvcCms.Controllers
{
    public class PageController : Controller
    {

        CmsEntities storeDB = new CmsEntities();

        //
        // GET: /Page/

        public ActionResult GetMenuPages()
        {
            var pages = storeDB.Pages.ToList();
            return View(pages);
        }

        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var page = storeDB.Pages.Find(id);
            return View(page);
        }

    }
}
