using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoogleGoogle.Models;

namespace MoogleGoogle.Controllers
{
    public class GatheringItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GatheringItems
        public ActionResult Index()
        {
            return View(db.GatheringItems.ToList());
        }

        // GET: GatheringItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GatheringItem gatheringItem = db.GatheringItems.Find(id);
            if (gatheringItem == null)
            {
                return HttpNotFound();
            }
            return View(gatheringItem);
        }

        // GET: GatheringItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GatheringItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,TimeStart,TimeEnd,Slot,Zone,Position,FastestRoute,Level,Perfecption,Type")] GatheringItem gatheringItem)
        {
            if (ModelState.IsValid)
            {
                db.GatheringItems.Add(gatheringItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gatheringItem);
        }

        // GET: GatheringItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GatheringItem gatheringItem = db.GatheringItems.Find(id);
            if (gatheringItem == null)
            {
                return HttpNotFound();
            }
            return View(gatheringItem);
        }

        // POST: GatheringItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,TimeStart,TimeEnd,Slot,Zone,Position,FastestRoute,Level,Perfecption,Type")] GatheringItem gatheringItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gatheringItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gatheringItem);
        }

        // GET: GatheringItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GatheringItem gatheringItem = db.GatheringItems.Find(id);
            if (gatheringItem == null)
            {
                return HttpNotFound();
            }
            return View(gatheringItem);
        }

        // POST: GatheringItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GatheringItem gatheringItem = db.GatheringItems.Find(id);
            db.GatheringItems.Remove(gatheringItem);
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
