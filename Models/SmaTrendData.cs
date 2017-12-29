using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this model contains data that will be used to look at some trends that use SMA's 
//including when stock prices move above SMA's or when different SMA's cross
namespace OptionsTechnicalAnalysis.Models
{
    public class SmaTrendData
    {
        public SmaRoot TenDaySma { get; set; }
        public SmaRoot TwentyDaySma { get; set; }
        public SmaRoot FiftyDaySma { get; set; }
        public SmaRoot TwoHundredDaySma { get; set; }
        public TimeSeriesDataRoot DailyTimeSeriesData { get; set; }
    }
}
