using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProjectedResaleValueChartController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: ProjectedResaleValueChart
        public ActionResult Index(int id)
        {
            ProjectedResaleValueChart projectedResaleValueChart = context.ProjectedResaleValueChart.Where(c => c.Id == id).SingleOrDefault();

            bool LimitedShoe = projectedResaleValueChart.LimitedShoe;
            bool ShoeConditionNew = projectedResaleValueChart.ShoeConditionNew;
            bool HolidayShoe = projectedResaleValueChart.HolidayShoe;


            if (LimitedShoe == true)
            {
                projectedResaleValueChart.ProjectedResaleValue += 250;

            }
            else
            {
                projectedResaleValueChart.ProjectedResaleValue += 0;


            }
            if (ShoeConditionNew == true)
            {
                projectedResaleValueChart.ProjectedResaleValue += 50;

            }
            else
            {
                projectedResaleValueChart.ProjectedResaleValue -= 75;


            }
            if (HolidayShoe == true)
            {
                projectedResaleValueChart.ProjectedResaleValue += 100;

            }
            else
            {
                projectedResaleValueChart.ProjectedResaleValue += 0;


            }



            return View(projectedResaleValueChart);
        }




        
        public ActionResult Create()
        {
            return View();
        }




        // POST: ProjectedResaleValueChart/Create
        [HttpPost]
        public ActionResult Create(ProjectedResaleValueChart thing)
        {
            try
            {
                // TODO: Add insert logic here
                context.ProjectedResaleValueChart.Add(thing);
                context.SaveChanges();
                return RedirectToAction("Index", new { id = thing.Id});
            }
            catch
            {
                return View();
            }
        }



        // GET: ProjectedResaleValueChart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // POST: ProjectedResaleValueChart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectedResaleValueChart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectedResaleValueChart/Delete/5
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
