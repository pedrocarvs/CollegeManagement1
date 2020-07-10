using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using CollegeManagement.DAL;
using CollegeManagement.Models;
using CollegeManagement.ViewModel;
using Microsoft.Ajax.Utilities;

namespace CollegeManagement.Controllers
{
    public class CourseController : Controller
    {
        private CollegeContext db = new CollegeContext();

        // GET: Course
        public ActionResult Index()
        {

           List<CourseViewModel>  cvm = (from c in db.Courses
                                    join s in db.Subjects on c.CourseID equals s.CourseID into s1
                                    from s2 in s1.DefaultIfEmpty()
                                    join e in db.Enrollments on s2.SubjectID equals e.SubjectID into e1
                                    from e2 in e1.DefaultIfEmpty()
                                    join g in db.Grades on e2.GradeID equals g.ID into g1
                                    from g2 in g1.DefaultIfEmpty()
                                         select new CourseViewModel
                                         {
                                             CourseId = c.CourseID,
                                             Title = c.Title,
                                             TotalTeachers =  e1.Select(x=>x.Subject.Teacher).Count(), 
                                             TotalStudents =  e1.Select(x=>x.StudentID).Count(),
                                             AvgGrade = g1.Average(x => x.Value)
                                    }).GroupBy(x=>x.Title).Select(x=>x.FirstOrDefault()).ToList();



            return View(cvm);
        }

        // GET: Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseID,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
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
