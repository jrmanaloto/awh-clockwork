using System;
using System.Linq;
using System.Web.Mvc;

namespace Clockwork.Web.Models
{
    public class HomeViewModel
    {
        public SelectListItem[] TimeZoneList { get; set; }

        public HomeViewModel()
        {
            TimeZoneList = TimeZoneInfo.GetSystemTimeZones().Select(tz => new SelectListItem()
            {
                Text = tz.DisplayName,
                Value = tz.Id
            }).ToArray();
        }
    }
}