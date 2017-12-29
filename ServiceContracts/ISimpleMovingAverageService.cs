using OptionsTechnicalAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.ServiceContracts
{
    public interface ISimpleMovingAverageService
    {
        Task<SmaTrendData> GetTrendData(string symbol);
    }
}
