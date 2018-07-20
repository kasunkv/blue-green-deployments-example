using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlueGreenWithARM.Web.Models;
using Microsoft.Extensions.Options;

namespace BlueGreenWithARM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;

        public HomeController(IOptions<AppSettings> optionsAcessor)
        {
            _appSettings = optionsAcessor.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["SlotSetting"] = _appSettings.SlotSettingExample;
            ViewData["NonSlotSetting"] = _appSettings.NonSlotSettingExample;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
