using System.Collections.Generic;
using Clockwork.Business.Interfaces;
using Clockwork.Data;
using Clockwork.Data.Models;
using System.Linq;

namespace Clockwork.Business.Services
{
    public class CurrentTimeService : ICurrentTimeService
    {
        private readonly IRepository<CurrentTimeQuery> _currentTimeQueryRepository;

        public CurrentTimeService(IRepository<CurrentTimeQuery> currentTimeQueryRepository)
        {
            _currentTimeQueryRepository = currentTimeQueryRepository;
        }

        public void Add(CurrentTimeQuery currentTimeQuery)
        {
            _currentTimeQueryRepository.Add(currentTimeQuery);
            _currentTimeQueryRepository.Commit();
        }

        public List<CurrentTimeQuery> GetAll()
        {
            return _currentTimeQueryRepository.GetAll(
                orderBy: src => src.OrderByDescending(x => x.CurrentTimeQueryId)).ToList();
        }

    }
}
