using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Clockwork.API.Helpers;
using Clockwork.Data.Models;
using Clockwork.Business.Interfaces;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class CurrentTimeController : Controller
    {
        private readonly ICurrentTimeService _currentTimeService;

        public CurrentTimeController(ICurrentTimeService currentTimeService)
        {
            _currentTimeService = currentTimeService;
        }
        // GET api/currenttime
        [HttpGet]
        public IActionResult Get(string timeZone)
        {
            var currentTime = GenerateCurrentTimeByTimeZone(timeZone);

            _currentTimeService.Add(currentTime);

            return Ok(currentTime);
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var timeList = _currentTimeService.GetAll();
            return Ok(timeList);
        }

        private CurrentTimeQuery GenerateCurrentTimeByTimeZone(string timeZone)
        {
            var utcTime = DateTime.UtcNow.Unspecified();
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
            var timeZoneTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZoneInfo).Unspecified();
            var ip = this.HttpContext.Connection.RemoteIpAddress.ToString();

            var currentTime = new CurrentTimeQuery
            {
                UTCTime = utcTime,
                ClientIp = ip,
                Time = timeZoneTime,
                TimeZone = timeZoneInfo.DisplayName
            };

            return currentTime;
        }
    }
}
