using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.data.Interfaces;
using Shop.data.Entities;

namespace Shop.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _repository;

        public CategoriesController(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        // GET: Categories
        public IActionResult Index()
        {
            var categories = _repository.GetAll();
            return View(categories);
        }

        // GET: Categories/Details/5
        public IActionResult Details(int id)
        {
            var category = _repository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categorie category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            _repository.Add(category);
            return RedirectToAction(nameof(Index));
        }

        // GET: Categories/Edit/5
        public IActionResult Edit(int id)
        {
            var category = _repository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Categorie category)
        {
            if (id != category.CategoryId || !ModelState.IsValid)
            {
                return View(category);
            }
            _repository.Update(category);
            return RedirectToAction(nameof(Index));
        }

        // GET: Categories/Delete/5
        public IActionResult Delete(int id)
        {
            var category = _repository.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
