using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.RepositoryQueryObjects
{
    public class DailySimpleMovingAverageQueryObject
    {
        public string Symbol { get; set; } = "MSFT";
        public string TimePeriod { get; set; }
        //close, open, high or low
        public string SeriesType { get; set; } = "close";
    }
}
