using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.PageName = "Project List";
            ViewBag.Url = "Portfolio";
            ViewBag.Description = "Project List";
            var values = portfolioManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.PageName = "Add Project";
            ViewBag.Url = "Portfolio";
            ViewBag.Description = "Adding";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.Add(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.GetById(id);
            portfolioManager.Delete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.PageName = "Portfolio Update";
            ViewBag.Url = "Portfolio";
            ViewBag.Description = "Update";
            var values = portfolioManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);

            if (results.IsValid)
            {
                portfolioManager.Update(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors )
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
