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

        public ActionResult Abstract()
        {
            var posts = storeDB.Posts.ToList();
            return View(posts);
        }

        //
        // GET: /Store/Browse
        public ActionResult Browse(string tag)
        {
            var tagModel = storeDB.Tags.Include("Posts").Single(g => g.Name == tag);
            return View(tagModel);
        }

        //
        // GET: /Store/Details
        public ActionResult Details(int id, string title)
        {
            var post = storeDB.Posts.Find(id);
            return View(post);
        }

        public ActionResult GetMenuTags()
        {
            var tags = storeDB.Tags.ToList();
            return View(tags);
        }
    }
}
