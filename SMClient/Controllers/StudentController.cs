using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMClient.Controllers
{
    public class StudentController : Controller
    {
        private ServiceReference2.ServiceClient service = new ServiceReference2.ServiceClient();

        // GET: Student
        public ActionResult Index()
        {
            List<Student> listS = new List<Student>();
            var list = service.GetNewStudent();
          foreach ( var item in list)
            {
                listS.Add(new Student() { 
                    Id= item.Id,
                    Name = item.Name,
                    DateOfBirth= item.DateOfBirth,
                    Gender = item.Gender,
                    Email = item.Email,
                    Description = item.Description
                });
            }

           
            return View(listS);
        }

        // GET: Student/Details/5
     

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DateOfBirth,Gender,Email,Description")] Student student)
        {
            
            try
            {
                var stdr = service.AddStudent(student.Id, student.Name, student.DateOfBirth, student.Gender, student.Email, student.Description);


                // TODO: Add insert logic here

                return View();
            //    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(Student student,string id)
        {
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name,DateOfBirth,Gender,Email,Description")] Student student)
        {
            try
            {
                // TODO: Add update logic here
                var std = service.EditStudent(student.Id, student.Name, student.DateOfBirth, student.Gender, student.Email, student.Description);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
