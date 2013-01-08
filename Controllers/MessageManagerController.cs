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
    public class MessageManagerController : Controller
    {
        private CmsEntities db = new CmsEntities();

        //
        // GET: /MessageManager/

        public ViewResult Index()
        {
            return View(db.Messages.ToList());
        }

        public void Update(int id)
        { 
            var msg = db.Messages.Find(id);
            if (TryUpdateModel(msg))
            {
                if (msg.Statment == true)
                {
                    msg.Statment = false;
                }
                else
                {
                    msg.Statment = true;
                }
                
                db.SaveChanges();
                
            }
        }

        public int CounterMessages(string statment)
        {
            if (statment == "read")
            {
                return db.Messages.Count();
            }
            else if (statment == "noread")
            {
                 //db.Messages.find(

                return db.Messages.Count(); 
                   
            }
            
              
        }

        //
        // GET: /MessageManager/Details/5

        public ViewResult Details(int id)
        {
            Message message = db.Messages.Find(id);
            var msg = db.Messages.Find(id);
            if (TryUpdateModel(msg))
            {
                msg.Statment = true;
            }    
            db.SaveChanges();
            return View(message);
        }
        

        //
        // GET: /MessageManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            Message message = db.Messages.Find(id);
            return View(message);
        }

        //
        // POST: /MessageManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Message message = db.Messages.Find(id);
            db.Messages.Remove(message);
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