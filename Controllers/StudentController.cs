using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext db;
        public StudentController(StudentDbContext context)
        {
            db = context;
        }

        public IActionResult GetData()
        {
            var dt=db.students. ToList();
            return View(dt);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student stdobj)
        {
            db.students.Add(stdobj);
            db.SaveChanges();
            return RedirectToAction("GetData");

        }
        
        public IActionResult Delete(int id)
        {
            var dlt = db.students.Where(m => m.id == id).FirstOrDefault();
            db.students.Remove(dlt);
            db.SaveChanges();
            return RedirectToAction("GetData");

        }
        public IActionResult Edit(int id)
        {
            var edt = db.students.Where(m => m.id == id).FirstOrDefault();
            return View(edt);
          
        }
        public IActionResult Details(int id)
        {
            var edt = db.students.Where(m => m.id == id).FirstOrDefault();
            return View(edt);
           
        }
    }
}
