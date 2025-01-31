using Microsoft.AspNetCore.Mvc;
using dziennikzywieniowy.Data;
using dziennikzywieniowy.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace dziennikzywieniowy.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string searchName, string searchCategory)
        {
            IQueryable<Product> products = _context.Products.AsNoTracking();
            if (!string.IsNullOrEmpty(searchName))
            {
                products = products.Where(e => e.Name.Contains(searchName));
                ViewBag.SearchName = searchName;
            }
            if (!string.IsNullOrEmpty(searchCategory))
            {
                products = products.Where(e => e.Category.Contains(searchCategory));
                ViewBag.SearchCategory = searchCategory;
            }
            return View(products.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tworzenie nowego produktu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Formularz edycji produktu
        [HttpGet("/Products/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Edycja produktu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Formularz potwierdzenia usunięcia produktu
        [HttpGet("/Products/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Usunięcie produktu
        [HttpPost]
        [ActionName("RemoveProduct")]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveProduct(int id, string _method)
        {
            if (_method == "DELETE")
            {
                var product = _context.Products.Find(id);
                if (product == null)
                {
                    return NotFound();
                }

                _context.Products.Remove(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}