using Clockwork.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clockwork.Business.Interfaces
{
    public interface ICurrentTimeService
    {
        void Add(CurrentTimeQuery currentTimeQuery);
        List<CurrentTimeQuery> GetAll();
    }
}
