using Apeam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Apeam1.Controllers
{
    public class SaleController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sale/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Sale/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                sales sale = new sales();
                DateTime actualDate = DateTime.Today;
                sale.customer = collection["customer"];
                sale.date_sale = actualDate;
                sale.payment = collection["payment"];
                sale.total_sale = Convert.ToDouble(collection["grandTotalOfSale"]);
                db.sales.Add(sale);
                db.SaveChanges();
                //return View("Index");
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: Sale/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sale/Edit/5
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

        // GET: Sale/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sale/Delete/5
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
