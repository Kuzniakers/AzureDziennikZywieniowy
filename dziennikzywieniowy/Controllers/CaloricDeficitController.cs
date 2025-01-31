using Microsoft.AspNetCore.Mvc;
using dziennikzywieniowy.Data;
using dziennikzywieniowy.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace dziennikzywieniowy.Controllers
{
    public class CaloricDeficitController : Controller
    {
        private readonly AppDbContext _context;

        public CaloricDeficitController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string search)
        {
            IQueryable<CaloricDeficit> deficits = _context.CaloricDeficits.AsNoTracking();
            if (!string.IsNullOrEmpty(search))
            {
                deficits = deficits.Where(e => e.ActivityName.Contains(search));
                ViewBag.Search = search;
            }

            return View(deficits.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CaloricDeficit deficit)
        {
            if (!ModelState.IsValid)
            {
                return View(deficit);
            }

            _context.CaloricDeficits.Add(deficit);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/CaloricDeficit/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var deficit = _context.CaloricDeficits.FirstOrDefault(e => e.Id == id);
            if (deficit == null)
            {
                return NotFound();
            }
            return View(deficit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CaloricDeficit deficit)
        {
            if (!ModelState.IsValid)
            {
                return View(deficit);
            }

            _context.CaloricDeficits.Update(deficit);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("RemoveDeficit")]
        public IActionResult RemoveDeficit(int id, string _method)
        {
            if (_method == "DELETE")
            {
                var deficit = _context.CaloricDeficits.FirstOrDefault(e => e.Id == id);
                if (deficit == null)
                {
                    return NotFound();
                }

                _context.CaloricDeficits.Remove(deficit);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}