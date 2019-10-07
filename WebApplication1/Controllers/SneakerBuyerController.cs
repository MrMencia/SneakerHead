using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SneakerBuyerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SneakerBuyer
        public ActionResult Index()
        {
            var currentUserId = User.Identity.GetUserId();
            var currentSneakerBuyer = db.SneakerBuyers.Where(a => a.ApplicationId == currentUserId).ToList();
            return View(currentSneakerBuyer);
        }

        // GET: SneakerBuyer/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SneakerBuyer sneakerBuyer = db.SneakerBuyers.Find(id);
            if (sneakerBuyer == null)
            {
                return HttpNotFound();
            }
            return View(sneakerBuyer);
        }

        // GET: SneakerBuyer/Create
        public ActionResult Create()
        {
            SneakerBuyer sneakerBuyer = new SneakerBuyer();
            return View();
        }

        // POST: SneakerBuyer/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName,LastName,StreetAddress,City,State,ZipCode")] SneakerBuyer sneakerBuyer)
        {
            if (ModelState.IsValid)
            {
               sneakerBuyer.ApplicationId = User.Identity.GetUserId();
                db.SneakerBuyers.Add(sneakerBuyer);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = sneakerBuyer.Id });

            }

            return View(sneakerBuyer);

        }

        // GET: SneakerBuyer/Edit/5
        public ActionResult Edit(int id)
        {

         

            SneakerBuyer sneakerBuyer = db.SneakerBuyers.Find(id);
            if (sneakerBuyer == null)
            {
                return HttpNotFound();
            }
            return View(sneakerBuyer);
        }

        // POST: SneakerBuyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,  SneakerBuyer sneakerBuyer)
        {
            try
            {
                var sneakerBuyerInDb = db.SneakerBuyers.Where(s => s.Id == sneakerBuyer.Id).SingleOrDefault();
                sneakerBuyerInDb.FirstName = sneakerBuyerInDb.FirstName;
                sneakerBuyerInDb.LastName = sneakerBuyerInDb.LastName;
                sneakerBuyerInDb.StreetAddress = sneakerBuyerInDb.StreetAddress;
                sneakerBuyerInDb.City = sneakerBuyerInDb.City;
                sneakerBuyerInDb.State = sneakerBuyerInDb.State;
                sneakerBuyerInDb.ZipCode = sneakerBuyerInDb.ZipCode;
                db.SaveChanges();
                return RedirectToAction("Index"); 
            }
            catch
            {
                return View("Index");
            }

        }

        // GET: SneakerBuyer/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SneakerBuyer sneakerBuyer = db.SneakerBuyers.Find(id);
            if (sneakerBuyer == null)
            {
                return HttpNotFound();
            }
            return View(sneakerBuyer);
        }

        // POST: SneakerBuyer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
