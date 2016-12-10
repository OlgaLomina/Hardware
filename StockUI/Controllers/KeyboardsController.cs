using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HardwareAPI;

namespace StockUI.Controllers
{
    public class KeyboardsController : Controller
    {
        private HardwareModel db = new HardwareModel();

        // GET: Keyboards
        public ActionResult Index()
        {
            var keyboards = Stock.GetKeyboards();
            return View(keyboards);
        }

        // GET: Keyboards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Keyboard keyboard = db.Keyboards.Find(id);
            if (keyboard == null)
            {
                return HttpNotFound();
            }
            return View(keyboard);
        }

        // GET: Keyboards/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(db.Brands.OrderBy(a => a.Name), "Id", "FullName");
            return View();
        }

        // POST: Keyboards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Model,SerialNumber,Wireless,Color,Price,Commentary,Count,BrandId")] Keyboard keyboard)
        {
            if (ModelState.IsValid)
            {
                Stock.AddKeyboard(keyboard);               
                return RedirectToAction("Index");
            }

            ViewBag.BrandId = new SelectList(db.Brands.OrderBy(a => a.Name), "Id", "FullName", keyboard.BrandId);
            return View(keyboard);
        }

        // GET: Keyboards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Keyboard keyboard = db.Keyboards.Find(id);
            if (keyboard == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name", keyboard.BrandId);
            return View(keyboard);
        }

        // POST: Keyboards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Model,SerialNumber,Wireless,Color,Price,Commentary,Count,BrandId")] Keyboard keyboard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(keyboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BrandId = new SelectList(db.Brands, "Id", "Name", keyboard.BrandId);
            return View(keyboard);
        }

        // GET: Keyboards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Keyboard keyboard = db.Keyboards.Find(id);
            if (keyboard == null)
            {
                return HttpNotFound();
            }
            return View(keyboard);
        }

        // POST: Keyboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Keyboard keyboard = db.Keyboards.Find(id);
            db.Keyboards.Remove(keyboard);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
