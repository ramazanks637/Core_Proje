using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2: ViewComponent
    {
        Context context = new();
        public IViewComponentResult Invoke()
        {
            ViewBag.ProjeSayisi = context.Portfolios.Count();
            ViewBag.MesajSayisi = context.Messages.Count();
            ViewBag.HizmetSayisi = context.Services.Count();
            return View();
        }
    }
}
