using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.DAL;

namespace RepositoryPattern.Controllers
{
    public class FacultyController : Controller
    {
        //private RepositoryPatternContext db = new RepositoryPatternContext();
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Faculty
        public ActionResult Index()
        {
            var faculty = unitOfWork.FacultyRepository.Get();
            return View(faculty.ToList());
        }

        // GET: Faculty/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Faculty faculty = unitOfWork.FacultyRepository.GetByID(id);
            if (faculty == null)
            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // GET: Faculty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faculty/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacultyId,Name")] Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.FacultyRepository.Insert(faculty);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(faculty);
        }

        // GET: Faculty/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faculty faculty = unitOfWork.FacultyRepository.GetByID(id);
            if (faculty == null)
            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // POST: Faculty/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacultyId,Name")] Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.FacultyRepository.Update(faculty);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(faculty);
        }

        // GET: Faculty/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faculty faculty = unitOfWork.FacultyRepository.GetByID(id);
            if (faculty == null)
            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // POST: Faculty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Faculty faculty = unitOfWork.FacultyRepository.GetByID(id);
            unitOfWork.FacultyRepository.Delete(faculty);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
