using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Text.RegularExpressions;
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

        public ActionResult Abstract(int limit)
        {

            var posts = storeDB.Posts.Where(p => p.Online).OrderByDescending(p => p.Date).Include(p => p.Tag);
            if(limit != 0)
            {
                posts = storeDB.Posts.Where(p => p.Online).OrderByDescending(p => p.Date).Take(limit).Include(p => p.Tag);  
            }
            return View(posts.ToList());
        }

        public ActionResult Navigation(int tag, string title)
        {
            var posts = storeDB.Posts.Where(p => p.TagId == tag).OrderByDescending(p => p.Date).Include(p => p.Tag);
            ViewBag.CurrentTag = storeDB.Tags.Find(tag).Name;
            return View(posts);
        }

        
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


        public ActionResult Archive()
        {
            var posts = storeDB.Posts.ToList();
      
            return View(posts);
        }

        public ActionResult GetArchives(string month, string year)
        {
            var posts = storeDB.Posts.Where(p => p.Year == year).Include(p => p.Tag);
            if (month != null)
            {
                posts = storeDB.Posts.Where(p => p.Month == month).Where(p => p.Year == year).Include(p => p.Tag);
            }

            ViewBag.Month = month;
            ViewBag.Year = year;
            
            return View(posts);
        }

    }
}
