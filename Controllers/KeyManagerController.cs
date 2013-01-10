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
    public class KeyManagerController : Controller
    {
        private CmsEntities db = new CmsEntities();

        //
        // GET: /KeyManager/

        public ViewResult Index()
        {
            return View(db.Keys.ToList());
        }

        //
        // GET: /KeyManager/Details/5

        public ViewResult Details(int id)
        {
            Key key = db.Keys.Find(id);
            return View(key);
        }

        //
        // GET: /KeyManager/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /KeyManager/Create

        [HttpPost]
        public ActionResult Create(Key key)
        {
            if (ModelState.IsValid)
            {
                db.Keys.Add(key);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(key);
        }
        
        //
        // GET: /KeyManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            Key key = db.Keys.Find(id);
            return View(key);
        }

        //
        // POST: /KeyManager/Edit/5

        [HttpPost]
        public ActionResult Edit(Key key)
        {
            if (ModelState.IsValid)
            {
                db.Entry(key).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(key);
        }

        //
        // GET: /KeyManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Key key = db.Keys.Find(id);
            return View(key);
        }

        //
        // POST: /KeyManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Key key = db.Keys.Find(id);
            db.Keys.Remove(key);
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