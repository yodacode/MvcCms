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
    public class MessageController : Controller
    {
        public CmsEntities db = new CmsEntities();

        //
        // GET: /Message/

        public ActionResult Index()
        {
            return View();
        }

        //
        // POST: /PostManager/Create

        [HttpPost]
        public ActionResult Index(Message message)
        {
            if (ModelState.IsValid)
            {
                db.Messages.Add(message);
                db.SaveChanges();
                return RedirectToAction("Success", new { controller = "Message", action = "Success", id = message.MessageId });
            }
            
            return View(message);
        }

        public ActionResult GetMessages()
        {
            var messages = db.Messages.ToList();
            return View(messages);
        }

        public ActionResult Success(int id)
        {
            var recap = db.Messages.Find(id);
            return View(recap);
        }


    }
}
