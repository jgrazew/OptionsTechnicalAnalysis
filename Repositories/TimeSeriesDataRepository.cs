using Newtonsoft.Json;
using OptionsTechnicalAnalysis.Models;
using OptionsTechnicalAnalysis.RepositoryContracts;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.Repositories
{
    public class TimeSeriesDataRepository : ITimeSeriesDataRepository
    {
        public async Task<TimeSeriesDataRoot> Get(TimeSeriesDataQueryObject model)
        {
            var client = new HttpClient();
            //full outPutSize returns up to 20 years of historical data
            var task = await client.GetAsync($"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={model.Symbol}&outputsize={model.OutputSize}&apikey=apikey");
            var jsonString = task.Content.ReadAsStringAsync().Result; 

            TimeSeriesDataRoot res = JsonConvert.DeserializeObject<TimeSeriesDataRoot>(jsonString);

            return res;
        }
    }
}
