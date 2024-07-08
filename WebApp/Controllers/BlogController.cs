using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.PL.WebApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
