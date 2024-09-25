using login.Controllers.Data;
using login.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace login.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationContext _context;

        public StudentController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Students.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                var std = new Student()
                {
                    Name = model.Name,
                    City = model.City,
                    State = model.State,
                    Standerd = model.Standerd,
                };
                _context.Students.Add(std);
                _context.SaveChanges();
                TempData["error"] = "Record Saved!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["message"] = "Empty Field can't submit";
                return View(model);
            }
                
        }

        public IActionResult Delete(int id)
        {
            var std = _context.Students.SingleOrDefault(e => e.Id == id);
            _context.Students.Remove(std);
            _context.SaveChanges();
            TempData["error"] = "Record Deleted";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            var std = _context.Students.SingleOrDefault(e => e.Id == Id);
            var result = new Student()
            {
                Name = std.Name,
                City = std.City,
                State = std.State,
                Standerd = std.Standerd,
            };
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Student model)
        {
            var std = new Student()
            {
                Id = model.Id,
                Name = model.Name,
                City = model.City,
                State = model.State,
                Standerd = model.Standerd,
            };
            _context.Students.Update(std);
            _context.SaveChanges();
            TempData["error"] = "Record Updated";
            return RedirectToAction("Index");
        }
    }
}
