using Microsoft.AspNetCore.Mvc;
using dziennikzywieniowy.Models;
using dziennikzywieniowy.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace dziennikzywieniowy.Controllers
{
    public class EntriesController : Controller
    {
        private readonly AppDbContext _context;

        public EntriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string search, DateTime? date)
        {
            IQueryable<Entry> entries = _context.Entries.AsNoTracking();

            if (!string.IsNullOrEmpty(search))
            {
                entries = entries.Where(e => e.MealName.Contains(search));
                ViewBag.Search = search;
            }
            if (date.HasValue)
            {
                entries = entries.Where(e => e.Date.Date == date.Value.Date);
                ViewBag.Date = date.Value.ToString("yyyy-MM-dd");
            }
            return View(entries.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Entry entry)
        {
            if (!ModelState.IsValid)
            {
                return View(entry);
            }

            _context.Entries.Add(entry);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Entries/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var entry = _context.Entries.FirstOrDefault(e => e.Id == id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Entry entry)
        {
            if (!ModelState.IsValid)
            {
                return View(entry);
            }

            _context.Entries.Update(entry);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Entries/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var entry = _context.Entries.FirstOrDefault(e => e.Id == id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }

        [HttpPost]
        [ActionName("RemoveEntry")]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveEntry(int id, string _method)
        {
            if (_method == "DELETE")
            {
                var entry = _context.Entries.FirstOrDefault(e => e.Id == id);
                if (entry == null)
                {
                    return NotFound();
                }

                _context.Entries.Remove(entry);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}