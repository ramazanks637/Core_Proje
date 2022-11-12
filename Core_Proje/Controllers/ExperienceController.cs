using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.PageName = "Experience List";
            ViewBag.Url = "Experience";
            ViewBag.Description = "Experience List";
            var values = experienceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.PageName = "Adding Experience";
            ViewBag.Url = "Experience";
            ViewBag.Description = "Adding Experience";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.Add(experience);
            return RedirectToAction("Index"); // ekleme yapıldıktan sonra ındex action unu git orda da listeleme işlemi yapılıyor zaten.
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.GetById(id);
            experienceManager.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.PageName = "Experience Update";
            ViewBag.Url = "Experience";
            ViewBag.Description = "Experience Update";
            var values = experienceManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.Update(experience);
            return RedirectToAction("Index");
        }

    }
}
