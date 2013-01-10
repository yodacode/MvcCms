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
    //[Authorize(Roles = "Administrator")]
    [Authorize]
    public class PostManagerController : Controller
    {
        

        public CmsEntities db = new CmsEntities();

        public static string SanitizeUrl(string str)
        {
            string cleanString = str.ToLower().Replace(" ", "-"); // ToLower() on the string thenreplaces spaces with hyphens
            cleanString = Regex.Replace(cleanString, @"[^a-zA-Z0-9\/_|+ -]", ""); // removes all non-alphanumerics/underscore/hyphens
            return cleanString;
        }

        //
        // GET: /PostManager/

        public ViewResult Index()
        {
            var posts = db.Posts.Include(p => p.Tag).Include(p => p.Author);
            return View(posts.ToList());
        }

        //
        // GET: /PostManager/Details/5

        public ViewResult Details(int id)
        {
            Post post = db.Posts.Find(id);
            return View(post);
        }

        //
        // GET: /PostManager/Create

        public ActionResult Create()
        {
            ViewBag.TagId = new SelectList(db.Tags, "TagId", "Name");
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name");
            ViewBag.KeyId = new SelectList(db.Keys, "KeyId", "Name");
            return View();
        } 

        //
        // POST: /PostManager/Create

        [HttpPost, ValidateInput(false)]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                if (post.Slug != null)
                {
                    post.Slug = SanitizeUrl(post.Slug);
                }
                else
                {
                    post.Slug = SanitizeUrl(post.Title);
                }
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.TagId = new SelectList(db.Tags, "TagId", "Name", post.TagId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", post.AuthorId);
            ViewBag.KeyId = new SelectList(db.Keys, "KeyId", "Name", post.KeyId);
            return View(post);
        }
        
        //
        // GET: /PostManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            Post post = db.Posts.Find(id);
            ViewBag.TagId = new SelectList(db.Tags, "TagId", "Name", post.TagId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", post.AuthorId);
            return View(post);
        }

        //
        // POST: /PostManager/Edit/5

        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                if (post.Slug != null)
                {
                    post.Slug = SanitizeUrl(post.Slug);
                }
                else
                {
                    post.Slug = SanitizeUrl(post.Title);
                }
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TagId = new SelectList(db.Tags, "TagId", "Name", post.TagId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", post.AuthorId);
            return View(post);
        }

        //
        // GET: /PostManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Post post = db.Posts.Find(id);
            return View(post);
        }

        //
        // POST: /PostManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}