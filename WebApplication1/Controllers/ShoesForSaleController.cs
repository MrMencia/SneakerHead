using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ShoesForSaleController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: ShoesForSale (DONE)
        public ActionResult Index()
        {
            List<ShoesForSale> shoesForSales = context.ZapatosParaVenda.ToList();


            return View(shoesForSales);
        }


        // GET: ShoesForSale/Details/5 (Done)
        public ActionResult Details(int id)
        {
            ShoesForSale shoesForSale = context.ZapatosParaVenda.Where(z => z.Id == id).Single();
            return View(shoesForSale);
        }


        // GET: ShoesForSale/Create (DONE)
        public ActionResult Create()
        {
            ShoesForSale shoesForSale = new ShoesForSale();

            return View(shoesForSale);
        }



        // POST: ShoesForSale/Create (Done)
        [HttpPost]
        public ActionResult Create(ShoesForSale shoesForSale ) 
        {
            if (ModelState.IsValid)
            {
               
                context.ZapatosParaVenda.Add(shoesForSale);
                context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(shoesForSale);
        }



        // GET: ShoesForSale/Edit/5 (DONE)
        public ActionResult Edit(int id)
        {
            ShoesForSale shoesForSale = context.ZapatosParaVenda.Find(id);
            if (shoesForSale == null)
            {
                return HttpNotFound();
            }
            return View(shoesForSale);

            
        }



        // POST: ShoesForSale/Edit/5 (Done)
        [HttpPost]
        public ActionResult Edit(int id, ShoesForSale shoesForSale)
        {
            try
            {
                var ShoesForSaleInDb = context.ZapatosParaVenda.Where(s => s.Id == shoesForSale.Id).SingleOrDefault();
                ShoesForSaleInDb.BrandofShoeForSale = shoesForSale.BrandofShoeForSale;
                ShoesForSaleInDb.NameOfShoe = shoesForSale.NameOfShoe;
                ShoesForSaleInDb.CondiciondeZapatos = shoesForSale.CondiciondeZapatos;
                ShoesForSaleInDb.GetShoeSizeForSale = shoesForSale.GetShoeSizeForSale;
                ShoesForSaleInDb.ShoePrice = shoesForSale.ShoePrice;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: ShoesForSale/Delete/5 (Done)
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoesForSale/Delete/5
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
