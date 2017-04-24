using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SAM_V2.Models;

namespace SAM_V2.Controllers
{
    public class ProposalsController : Controller
    {
        private SAM_V2Context db = new SAM_V2Context();

        public string OrganBag { get; private set; }

        // GET: Proposals
        public ActionResult Index()
        {
            return View(db.Proposals.ToList());
        }

        // GET: Proposals/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // GET: Proposals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proposals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocNo,OrganName,Date,Subject,ActName,StartDate,EndDate,Place,StdBudget,OthName,OthBudget,Total,Act1,Act2,Act3,Act4,Act5,Act6,UrlFile,Result1,Comment1,Result2,Comment2,Result3,Comment3,Result4,Comment4,Result5,Comment5,Result6,Comment6,Result7,Comment7")] Proposal proposal)
        {
            if (ModelState.IsValid)
            {
                db.Proposals.Add(proposal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proposal);
        }

        // GET: Proposals/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // POST: Proposals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocNo,OrganName,Date,Subject,ActName,StartDate,EndDate,Place,StdBudget,OthName,OthBudget,Total,Act1,Act2,Act3,Act4,Act5,Act6,UrlFile,Result1,Comment1,Result2,Comment2,Result3,Comment3,Result4,Comment4,Result5,Comment5,Result6,Comment6,Result7,Comment7")] Proposal proposal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proposal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proposal);
        }

        // GET: Proposals/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // POST: Proposals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Proposal proposal = db.Proposals.Find(id);
            db.Proposals.Remove(proposal);
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

      /*  public ActionResult OrganName(string OrganName) {
            var OrganNamelst = new List<string>();
            var OrganNameQry = from d in db.Organizations orderby d.OrganName select d.OrganName;
            OrganNamelst.AddRange(OrganNameQry.Distinct());
            ViewBag.OrganBag = new SelectList(OrganNamelst);
            var organ = from m in db.Organizations
                         select m; 
            if (!string.IsNullOrEmpty(OrganBag))
            {
                organ = organ.Where(x => x.OrganName == OrganBag);
            }
            return View(organ); }*/
    }
}
