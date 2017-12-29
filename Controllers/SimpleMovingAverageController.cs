    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OptionsTechnicalAnalysis.DataAccessLayer;
using OptionsTechnicalAnalysis.ServiceContracts;

namespace OptionsTechnicalAnalysis.Controllers
{
    public class SimpleMovingAverageController : Controller
    {
        private readonly ISimpleMovingAverageService simpleMovingAverageService;

        public SimpleMovingAverageController(ISimpleMovingAverageService simpleMovingAverageService)
        {
            this.simpleMovingAverageService = simpleMovingAverageService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> SimpleMovingAverageTrends(string symbol = "MSFT")
        {
            var smaTrendData = await simpleMovingAverageService.GetTrendData(symbol);

            return View(smaTrendData);
        }
    }
}