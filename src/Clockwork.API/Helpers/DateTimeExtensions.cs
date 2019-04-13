using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clockwork.API.Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTime Unspecified(this DateTime dateTime)
        {
            return DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
        }
    }
}
