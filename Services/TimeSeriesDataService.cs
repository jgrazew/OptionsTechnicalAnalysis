using OptionsTechnicalAnalysis.Models;
using OptionsTechnicalAnalysis.RepositoryContracts;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;
using OptionsTechnicalAnalysis.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.Services
{
    public class TimeSeriesDataService : ITimeSeriesDataService
    {
        private readonly ITimeSeriesDataRepository timeSeriesDataRepository;

        public TimeSeriesDataService(ITimeSeriesDataRepository timeSeriesDataRepository)
        {
            this.timeSeriesDataRepository = timeSeriesDataRepository;
        }

        public async Task<TimeSeriesDataRoot> GetTimeSeriesData(TimeSeriesDataQueryObject stock)
        {
            var timeSeriesData = new TimeSeriesDataRoot();

            timeSeriesData = await timeSeriesDataRepository.Get(stock);

            return timeSeriesData;
        }
    }
}
