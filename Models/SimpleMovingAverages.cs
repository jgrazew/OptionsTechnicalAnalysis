using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


//this will have models for 10-, 20-, 50-, and 200-day simple moving averages
namespace OptionsTechnicalAnalysis.Models
{
    public class SmaRoot
    {
        [JsonProperty(PropertyName = "Meta Data")]
        public SmaMetaData MetaData { get; set; }
        //the string in the dictionary is the date time stamp
        [JsonProperty(PropertyName = "Technical Analysis: SMA")] 
        public Dictionary<string, SmaJsonClass> Data { get; set; }
    }

    public class SmaMetaData
    {
        [JsonProperty(PropertyName = "1: Symbol")]
        public string Symbol { get; set; }
        [JsonProperty(PropertyName = "2: Indicator")]
        public string Indicator { get; set; }
        [JsonProperty(PropertyName = "3: Last Refreshed")]
        public DateTime LastRefreshed { get; set; }
        [JsonProperty(PropertyName = "4: Interval")]
        public string Interval { get; set; }
        [JsonProperty(PropertyName = "5: Time Period")]
        public string TimePeriod { get; set; }
        [JsonProperty(PropertyName = "6: Series Type")]
        public string SeriesType { get; set; }
        [JsonProperty(PropertyName = "7: Time Zone")]
        public string TimeZone { get; set; }
    }

    public class SmaJsonClass
    {
        [JsonProperty(PropertyName = "SMA")]
        public double Sma { get; set; }
    }
}
