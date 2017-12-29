using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OptionsTechnicalAnalysis.DataAccessLayer;
using OptionsTechnicalAnalysis.RepositoryContracts;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;
using OptionsTechnicalAnalysis.ServiceContracts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OptionsTechnicalAnalysis.Controllers
{
    public class TimeSeriesDataController : Controller
    {
        private readonly ITimeSeriesDataService timeSeriesDataService;

        public TimeSeriesDataController(ITimeSeriesDataService timeSeriesDataService)
        {
            this.timeSeriesDataService = timeSeriesDataService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SearchTimeSeriesDaily(string symbol = "MSFT", string outPutSize = "compact")
        {
            var timeSeriesQueryObject = new TimeSeriesDataQueryObject();
            timeSeriesQueryObject.Symbol = symbol;
            timeSeriesQueryObject.OutputSize = outPutSize;

            var dailyTimeSeriesData = await timeSeriesDataService.GetTimeSeriesData(timeSeriesQueryObject);

            return View(dailyTimeSeriesData);
        }
    }
}
