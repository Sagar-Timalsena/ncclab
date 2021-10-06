using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab6.Models;

namespace Lab6.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _db;

        public StudentController(StudentContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Student.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if(ModelState.IsValid)
            {
                _db.Add(std);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(std);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            var getStudentDetails = await _db.Student.FindAsync(id);
            return View(getStudentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student std)
        {
            if(ModelState.IsValid)
            {
                _db.Update(std);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(std);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getStudentDetails = await _db.Student.FindAsync(id);
            return View(getStudentDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var getStudentDetails = await _db.Student.FindAsync(id);
            return View(getStudentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getStudentDetails = await _db.Student.FindAsync(id);
            _db.Student.Remove(getStudentDetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
