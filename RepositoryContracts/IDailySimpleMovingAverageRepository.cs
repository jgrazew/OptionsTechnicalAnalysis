using OptionsTechnicalAnalysis.Models;
using OptionsTechnicalAnalysis.RepositoryQueryObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.RepositoryContracts
{
    public interface IDailySimpleMovingAverageRepository
    {
        Task<SmaRoot> Get(DailySimpleMovingAverageQueryObject model);
    }
}
