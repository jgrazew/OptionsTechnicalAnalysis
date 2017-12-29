using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.RepositoryQueryObjects
{
    public class TimeSeriesDataQueryObject
    {
        public string Symbol { get; set; } = "MSFT";
        public string OutputSize { get; set; } = "compact";
    }
}
