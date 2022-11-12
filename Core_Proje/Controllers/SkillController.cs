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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.PageName = "Skill List";
            ViewBag.Url = "Skill";
            ViewBag.Description = "Skill List";
            var values = skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.PageName = "Adding Skill";
            ViewBag.Url = "Skill";
            ViewBag.Description = "Adding Skill";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.Add(skill);
            return RedirectToAction("Index"); // ekleme yapıldıktan sonra ındex action unu git orda da listeleme işlemi yapılıyor zaten.
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.GetById(id);
            skillManager.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.PageName = "Skill Update";
            ViewBag.Url = "Skill";
            ViewBag.Description = "Update";
            var values = skillManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.Update(skill);
            return RedirectToAction("Index");
        }
    }
}
