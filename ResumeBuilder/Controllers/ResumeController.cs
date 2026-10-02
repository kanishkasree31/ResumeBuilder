using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Models;

namespace ResumeBuilder.Controllers
{
    public class ResumeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Resume resume)
        {
            if (ModelState.IsValid)
            {
                return View("Preview", resume);
            }

            return View(resume);
        }
    }
}