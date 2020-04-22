using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Software2_project.Context;
using Software2_project.Models;
using Software2_project.ViewModel;

namespace Software2_project.Controllers
{
    public class StudentController : Controller
    {
        examinationContext _context = new examinationContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["username"] != null && Session["role"].Equals("student"))
            {
                short id = (short)Session["id"];
                var student = _context.studentDb.Single(a => a.id == id);
                return View(student);
            }

            return RedirectToAction("Login", "Home");
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult editStudentProfile(short id)
        {
            if (Session["username"] != null && Session["role"].Equals("student"))
            {
                StudentModel student = _context.studentDb.Find(id);
                return View(student);
            }

            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public ActionResult updateStudentProfile(StudentModel student)
        {
            if (Session["username"] != null && Session["role"].Equals("student"))
            {
                var studentInDb = _context.studentDb.Single(p => p.id == student.id);
                studentInDb.name = student.name;
                studentInDb.phone = student.phone;
                studentInDb.e_mail = student.e_mail;
                studentInDb.address = student.address;
                studentInDb.gender = student.gender;
                studentInDb.age = student.age;
                studentInDb.username = student.username;

                _context.SaveChanges();
                return RedirectToAction("editStudentProfile", new RouteValueDictionary(new { Controller = "Student", Action = "editStudentProfile", id = student.id }));
            }

            return RedirectToAction("Login", "Home");
        }

        public ActionResult listExams()
        {
            if (Session["username"] != null && Session["role"].Equals("student"))
            {
                var studentId = (short)Session["id"];
                StudentModel student = _context.studentDb.Find(studentId);
                var courses = student.courseModel.ToList();
                return View(courses);
            }

            return RedirectToAction("Login", "Home");
        }

        public ActionResult showExam(short id)
        {
            if (Session["username"] != null && Session["role"].Equals("student"))
            {
                var questions = _context.questionDb.Where(q => q.CourseId == id).ToList();
                CourseModel course = _context.courseDb.Single(c => c.id == id);

                var viewModel = new CourseQuestionsViewModel
                {
                    course = course,
                    questions = questions
                };

                return View(viewModel);
            }

            return RedirectToAction("Login", "Home");
        }
    }
}