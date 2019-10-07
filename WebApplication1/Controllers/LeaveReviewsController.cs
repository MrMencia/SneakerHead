using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LeaveReviewsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: LeaveReviews
        public ActionResult Index()
        {
            List<LeaveReviews> leaveReviewsForSeller = context.leaveReviews.ToList();

            return View(leaveReviewsForSeller);
        }

        // GET: LeaveReviews/Details/5
        public ActionResult Details(int id)
        {
            LeaveReviews leaveReviews = context.leaveReviews.Where(t => t.Id == id).Single();

            return View(leaveReviews);
        }

        // GET: LeaveReviews/Create
        public ActionResult Create()
        {
            LeaveReviews leaveReviews = new LeaveReviews();

            return View(leaveReviews);
        }

        // POST: LeaveReviews/Create
        [HttpPost]
        public ActionResult Create(LeaveReviews leaveReviews)
        {
            try
            {
                context.leaveReviews.Add(leaveReviews);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveReviews/Edit/5
        public ActionResult Edit(int id)
        {
            LeaveReviews leaveReviews = context.leaveReviews.Find(id);
            if (leaveReviews == null)
            {
                return HttpNotFound();
            }
            return View(leaveReviews);



        }

        // POST: LeaveReviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LeaveReviews leaveReviews)
        {
            try
            {
                var LeaveReviewsForSellerInDb = context.leaveReviews.Where(s => s.Id == leaveReviews.Id).SingleOrDefault();
                LeaveReviewsForSellerInDb.LeaveReviewsForSeller = leaveReviews.LeaveReviewsForSeller;
                LeaveReviewsForSellerInDb.RateSellerBasedOnExperience = leaveReviews.RateSellerBasedOnExperience;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveReviews/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeaveReviews leaveReviews = context.leaveReviews.Find(id);
            if (leaveReviews == null)
            {
                return HttpNotFound();
            }
            return View(leaveReviews);
        }

        // POST: LeaveReviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                LeaveReviews leaveReviews = context.leaveReviews.Find(id);
                context.leaveReviews.Remove(leaveReviews);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
