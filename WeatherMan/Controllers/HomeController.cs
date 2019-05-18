using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WeatherMan.Factory;
using WeatherMan.Models;
using WeatherMan.Util;

namespace WeatherMan.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MySettingsModel> _appSettings;

        public HomeController(IOptions<MySettingsModel> appSettings)
        {
            _appSettings = appSettings;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiUrl;
            ApplicationSettings.WebApiKey = appSettings.Value.WebApiKey;
        }

        public async Task<IActionResult> Index()
        {
            var data = await ApiClientFactory.Instance.GetAllData();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
