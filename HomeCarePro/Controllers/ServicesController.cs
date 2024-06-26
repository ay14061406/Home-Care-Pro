﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeCarePro.Models;

namespace HomeCarePro.Controllers
{
    public class ServicesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Services
        public async Task<ActionResult> Index()
        {
            return View(await db.Services.ToListAsync());
        }

        public async Task<ActionResult> Book()
        {
            return View();
        }

        public async Task<ActionResult> Track()
        {
            return View();
        }

        public async Task<ActionResult> TrackSH()
        {
            return View();
        }

        public async Task<ActionResult> Pay()
        {
            return View();
        }

        public async Task<ActionResult> Sub()
        {
            return View();
        }

        public async Task<ActionResult> Loyal()
        {
            return View();
        }

        public async Task<ActionResult> Support()
        {
            return View();
        }

        public async Task<ActionResult> Customize()
        {
            return View();
        }

        public string BookingConfirm(string BookingTime)
        {
            return "Your Booking is confirmed with ID 123 ";
        }

        

            public string TrackDet()
        {
            return "Your Booking is on 5th may , 12pm";
        }

        public string TrackSHDet()
        {
            return "Your Shipment will arrive on 5th may";
        }

        public string PayDone()
        {
            return "Thank you , your payment is done and your service is confirmed";
        }

        public string SubDone()
        {
            return "Thank you , Please complete payment on payment page with ID 123";
        }

        public string LoyalDone()
        {
            return "Thank you for Joining us";
        }

        public string SupDone()
        {
            return "Thank you , our team is working to solve your request";
        }

        public string CusDone()
        {
            return "Thank you , our team will contact you soon";
        }

        // GET: Services/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = await db.Services.FindAsync(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // GET: Services/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,type,price")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(service);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = await db.Services.FindAsync(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,type,price")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(service).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = await db.Services.FindAsync(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Service service = await db.Services.FindAsync(id);
            db.Services.Remove(service);
            await db.SaveChangesAsync();
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
