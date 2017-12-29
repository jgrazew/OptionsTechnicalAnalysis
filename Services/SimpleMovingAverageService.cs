using OptionsTechnicalAnalysis.Models;
using OptionsTechnicalAnalysis.ServiceContracts;
using OptionsTechnicalAnalysis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OptionsTechnicalAnalysis.RepositoryContracts;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;

namespace OptionsTechnicalAnalysis.Services
{
    public class SimpleMovingAverageService : ISimpleMovingAverageService
    {
        private readonly ITimeSeriesDataRepository timeSeriesDataRepository;
        private readonly IDailySimpleMovingAverageRepository dailySimpleMovingAverageRepository;

        public SimpleMovingAverageService(ITimeSeriesDataRepository timeSeriesDataRepository, IDailySimpleMovingAverageRepository dailySimpleMovingAverageRepository)
        {
            this.timeSeriesDataRepository = timeSeriesDataRepository;
            this.dailySimpleMovingAverageRepository = dailySimpleMovingAverageRepository;
        }
        public async Task<SmaTrendData> GetTrendData(string symbol)
        {
            var smaTrendData = new SmaTrendData();

            //Ten Day SMA
            var tenDayQueryObject = new DailySimpleMovingAverageQueryObject();
            tenDayQueryObject.Symbol = symbol;
            tenDayQueryObject.TimePeriod = "10";
            smaTrendData.TenDaySma = await dailySimpleMovingAverageRepository.Get(tenDayQueryObject);

            //Twenty Day SMA
            var twentyDayQueryObject = new DailySimpleMovingAverageQueryObject();
            twentyDayQueryObject.Symbol = symbol;
            twentyDayQueryObject.TimePeriod = "20";
            smaTrendData.TwentyDaySma = await dailySimpleMovingAverageRepository.Get(twentyDayQueryObject);

            //Fifty Day SMA
            var fiftyDayQueryObject = new DailySimpleMovingAverageQueryObject();
            fiftyDayQueryObject.Symbol = symbol;
            fiftyDayQueryObject.TimePeriod = "50";
            smaTrendData.FiftyDaySma = await dailySimpleMovingAverageRepository.Get(fiftyDayQueryObject);

            //Two Hundred Day SMA
            var twoHundredDayQueryObject = new DailySimpleMovingAverageQueryObject();
            twoHundredDayQueryObject.Symbol = symbol;
            twoHundredDayQueryObject.TimePeriod = "200";
            smaTrendData.TwoHundredDaySma = await dailySimpleMovingAverageRepository.Get(twoHundredDayQueryObject);

            //Time Series Data; output size compact returns last 100 data points
            var timeSeriesQueryObject = new TimeSeriesDataQueryObject();
            timeSeriesQueryObject.Symbol = symbol;
            smaTrendData.DailyTimeSeriesData = await timeSeriesDataRepository.Get(timeSeriesQueryObject);

            return smaTrendData;
        }
    }
}
