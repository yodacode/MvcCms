using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCms.Models;

namespace MvcCms.Controllers
{
    public class PostController : Controller
    {
        CmsEntities storeDB = new CmsEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var tags = storeDB.Tags.ToList();
            return View(tags);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string tag)
        {
            var tagModel = new Tag { Name = tag };
            return View(tagModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var post = new Post { Title = "Post " + id };
            return View(post);
        }
    }
}
