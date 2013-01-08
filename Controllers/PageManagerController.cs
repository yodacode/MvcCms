using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCms.Models;

namespace MvcCms.Controllers
{
    [Authorize]
    public class PageManagerController : Controller
    {
        private CmsEntities db = new CmsEntities();

        //
        // GET: /PageManager/

        public ViewResult Index()
        {
            var pages = db.Pages.Include(p => p.Author);
            return View(pages.ToList());
        }

        //
        // GET: /PageManager/Details/5

        public ViewResult Details(int id)
        {
            Page page = db.Pages.Find(id);
            return View(page);
        }

        //
        // GET: /PageManager/Create

        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name");
            //ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name");
            return View();
        } 

        //
        // POST: /PageManager/Create

        [HttpPost,ValidateInput(false)]
        public ActionResult Create(Page page)
        {
            if (ModelState.IsValid)
            {
                db.Pages.Add(page);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", page.AuthorId);
            return View(page);
        }
        
        //
        // GET: /PageManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            Page page = db.Pages.Find(id);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", page.AuthorId);
            return View(page);
        }

        //
        // POST: /PageManager/Edit/5

        [HttpPost,ValidateInput(false)]
        public ActionResult Edit(Page page)
        {
            if (ModelState.IsValid)
            {
                db.Entry(page).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", page.AuthorId);
            return View(page);
        }

        //
        // GET: /PageManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Page page = db.Pages.Find(id);
            return View(page);
        }

        //
        // POST: /PageManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Page page = db.Pages.Find(id);
            db.Pages.Remove(page);
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