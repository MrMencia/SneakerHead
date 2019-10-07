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
    public class SneakerSellerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SneakerSeller
        public ActionResult Index()
        {
            var currentUserId = User.Identity.GetUserId();
            var currentSneakerSeller = db.SneakerSellers.Where(a => a.ApplicationId == currentUserId).ToList();
            return View(currentSneakerSeller);

            
        }

        // GET: SneakerSeller/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SneakerSeller sneakerSeller = db.SneakerSellers.Find(id);
            if (sneakerSeller == null)
            {
                return HttpNotFound();
            }
            return View(sneakerSeller);

        }

        // GET: SneakerSeller/Create
        public ActionResult Create()
        {
            SneakerSeller sneakerSeller = new SneakerSeller();
            return View();
        }

        // POST: SneakerSeller/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName,LastName,StreetAddress,City,State,ZipCode")] SneakerSeller sneakerSeller)
        {
            if (ModelState.IsValid)
            {
                sneakerSeller.ApplicationId = User.Identity.GetUserId();
                db.SneakerSellers.Add(sneakerSeller);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = sneakerSeller.Id });

            }

            return View(sneakerSeller);
        }


        // GET: SneakerSeller/Edit/5
        public ActionResult Edit(int id)
        {

       

            SneakerSeller sneakerSeller = db.SneakerSellers.Find(id);
            if (sneakerSeller == null)
            {
                return HttpNotFound();
            }

            return View(sneakerSeller);
        }

        // POST: SneakerSeller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SneakerSeller sneakerSeller)
        {
            var sneakerSellerInDb = db.SneakerSellers.Where(s => s.Id == sneakerSeller.Id).SingleOrDefault();
            sneakerSellerInDb.FirstName = sneakerSellerInDb.FirstName;
            sneakerSellerInDb.LastName = sneakerSellerInDb.LastName;
            sneakerSellerInDb.StreetAddress = sneakerSellerInDb.StreetAddress;
            sneakerSellerInDb.City = sneakerSellerInDb.City;
            sneakerSellerInDb.State = sneakerSellerInDb.State;
            sneakerSellerInDb.ZipCode = sneakerSellerInDb.ZipCode;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: SneakerSeller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SneakerSeller/Delete/5
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


        //public ActionResult GenerateProjectedResale()
       // {





        }


    }






//}
