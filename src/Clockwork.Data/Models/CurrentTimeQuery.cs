using System;

namespace Clockwork.Data.Models
{
    public class CurrentTimeQuery
    {
        public int CurrentTimeQueryId { get; set; }
        public string TimeZone { get; set; }
        public DateTime Time { get; set; }
        public string ClientIp { get; set; }
        public DateTime UTCTime { get; set; }
    }
}
