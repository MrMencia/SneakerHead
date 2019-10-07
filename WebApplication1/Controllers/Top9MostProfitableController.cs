using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Top9MostProfitableController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        
        
        // GET: Top9MostProfitable--
        public ActionResult Index()
        {
            List<Top9MostProfitable> top9MostProfitables = context.Top9MostProfitables.ToList();

            return View(top9MostProfitables);
        }

        // GET: Top9MostProfitable/Details/5--
        public ActionResult Details(int id)
        {
            Top9MostProfitable top9 = context.Top9MostProfitables.Where(t => t.Id == id).Single();

            return View(top9);
        }

        // GET: Top9MostProfitable/Create
        public ActionResult Create()
        {
            Top9MostProfitable top9 = new Top9MostProfitable();
            return View(top9);
        }

        // POST: Top9MostProfitable/Create--
        [HttpPost]
        public ActionResult Create(Top9MostProfitable top9)
        {
            try
            {
                context.Top9MostProfitables.Add(top9);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            catch
            {
                return View();

            }
        }

        // GET: Top9MostProfitable/Edit/5--
        public ActionResult Edit(int id)
        {
            Top9MostProfitable top9 = context.Top9MostProfitables.Find(id);
            if (top9 == null)
            {
                return HttpNotFound();
            }
            return View(top9);

            
        }

        // POST: Top9MostProfitable/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Top9MostProfitable top9)
        {
            try
            {
                var top9InDb = context.Top9MostProfitables.Where(s => s.Id == top9.Id).SingleOrDefault();
                top9InDb.SneakerName = top9.SneakerName;
                top9InDb.RetailValue = top9.RetailValue;
                top9InDb.ResaleValue = top9.ResaleValue;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Top9MostProfitable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Top9MostProfitable/Delete/5
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
