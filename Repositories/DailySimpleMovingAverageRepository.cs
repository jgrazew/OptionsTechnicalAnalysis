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
    public class DailySimpleMovingAverageRepository : IDailySimpleMovingAverageRepository
    {
        public async Task<SmaRoot> Get(DailySimpleMovingAverageQueryObject model)
        {
            var client = new HttpClient();
            var task = await client.GetAsync($"https://www.alphavantage.co/query?function=SMA&symbol={model.Symbol}&interval=daily&time_period={model.TimePeriod}&series_type={model.SeriesType}&apikey=apikey");
            var jsonString = task.Content.ReadAsStringAsync().Result;

            //dynamic fyn = JsonConvert.DeserializeObject(jsonString);

            SmaRoot res = JsonConvert.DeserializeObject<SmaRoot>(jsonString);

            return res;
        }
    }
}
