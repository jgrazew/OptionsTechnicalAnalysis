using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsTechnicalAnalysis.Models
{
    //time series data with a non adj close
    public class TimeSeriesDataRoot
    {
        [JsonProperty(PropertyName = "Meta Data")]
        public TimeSeriesDataMetaData metaData { get; set; }
        [JsonProperty(PropertyName = "Time Series (Daily)")]
        public Dictionary<string, TimeSeriesDataJsonClass> Data { get; set; }
    }

    public class TimeSeriesDataMetaData
    {
        [JsonProperty(PropertyName = "1. Information")]
        public string Information { get; set; }
        [JsonProperty(PropertyName = "2. Symbol")]
        public string Symbol { get; set; }
        [JsonProperty(PropertyName = "3. Last Refreshed")]
        public DateTime LastRefreshed { get; set; }
        [JsonProperty(PropertyName = "4. Output Size")]
        public string OutputSize { get; set; }
        [JsonProperty(PropertyName = "5. Time Zone")]
        public string TimeZone { get; set; }
    }

    public class TimeSeriesDataJsonClass
    {
        [JsonProperty(PropertyName = "1. open")]
        public double open { get; set; }
        [JsonProperty(PropertyName = "2. high")]
        public double high { get; set; }
        [JsonProperty(PropertyName = "3. low")]
        public double low { get; set; }
        [JsonProperty(PropertyName = "4. close")]
        public double close { get; set; }
        [JsonProperty(PropertyName = "5. volume")]
        public double volume { get; set; }
    }
}
