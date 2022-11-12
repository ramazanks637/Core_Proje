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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.PageName = "Service Update";
            ViewBag.Url = "Service";
            ViewBag.Description = "Update";
            var values = serviceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.PageName = "Adding Service";
            ViewBag.Url = "Service";
            ViewBag.Description = "Adding ";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.Add(service);
            return RedirectToAction("Index"); // ekleme yapıldıktan sonra ındex action unu git orda da listeleme işlemi yapılıyor zaten.
        }
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.GetById(id);
            serviceManager.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.PageName = "Service Update";
            ViewBag.Url = "Service";
            ViewBag.Description = "Update";
            var values = serviceManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.Update(service);
            return RedirectToAction("Index");
        }
    }
}
