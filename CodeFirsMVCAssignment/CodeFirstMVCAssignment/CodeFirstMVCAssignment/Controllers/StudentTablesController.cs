using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstMVCAssignment.Models;

namespace CodeFirstMVCAssignment.Controllers
{
    public class StudentTablesController : Controller
    {
        private StudentEntities db = new StudentEntities();

        // GET: StudentTables
        public ActionResult Index()
        {
            return View(db.StudentTable.ToList());
        }
        public ActionResult GetStudentScaffolded()
        {
            List<StudentTable> st = db.StudentTable.ToList();
            return View(st);
        }

        // GET: StudentTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudentTable.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // GET: StudentTables/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SearchBy(string searchBy, string search)
        {
            if (searchBy == "City")
            {
                return View(db.StudentTable.Where(x => x.City == search).ToList());
            }
            else if (searchBy == "Percentage")
            {
                return View(db.StudentTable.Where(x => x.Percentage.ToString() == search).ToList());
            }
            else if (searchBy == "Branch")
            {
                return View(db.StudentTable.Where(x => x.Branch == search).ToList());
            }
            else
            {
                //return View();
                return View(db.StudentTable.Where(x => x.Id.ToString() == search).ToList());
            }

        }
        public ActionResult searchbyPercentage(int start, int end)
        {
            //List<StudentTable> st=sc.StudentTable.Where(x=>x.Percentage >start && x.Percentage<end).ToList();
            List<StudentTable> st = (from c in db.StudentTable
                                     where c.Percentage >= start && c.Percentage <= end
                                     select c).ToList();
            return View(st);
        }

        // POST: StudentTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,Id,Name,City,Branch,Percentage")] StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                db.StudentTable.Add(studentTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentTable);
        }

        // GET: StudentTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudentTable.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // POST: StudentTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,Id,Name,City,Branch,Percentage")] StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentTable);
        }

        // GET: StudentTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudentTable.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // POST: StudentTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentTable studentTable = db.StudentTable.Find(id);
            db.StudentTable.Remove(studentTable);
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
