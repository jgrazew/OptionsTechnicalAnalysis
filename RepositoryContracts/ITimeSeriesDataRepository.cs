using OptionsTechnicalAnalysis.Models;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.RepositoryContracts
{
    public interface ITimeSeriesDataRepository
    {
        Task<TimeSeriesDataRoot> Get(TimeSeriesDataQueryObject model);
    }
}
