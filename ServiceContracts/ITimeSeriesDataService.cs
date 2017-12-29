using OptionsTechnicalAnalysis.Models;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.ServiceContracts
{
    public interface ITimeSeriesDataService
    {
        Task<TimeSeriesDataRoot> GetTimeSeriesData(TimeSeriesDataQueryObject stock);
    }
}
