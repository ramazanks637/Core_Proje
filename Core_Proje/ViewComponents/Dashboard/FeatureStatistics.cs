using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics: ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.YetenekSayisi = context.Skills.Count();
            ViewBag.OkunmamisMesajSayisi = context.Messages.Where(x => x.Status == false).Count();
            ViewBag.OkunmusMesajSayisi = context.Messages.Where(x => x.Status == true).Count();
            ViewBag.IsSayisi = context.Experiences.Count();

            return View();
        }
    }
}
