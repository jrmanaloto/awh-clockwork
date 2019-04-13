using Clockwork.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Clockwork.Data
{
    public class ClockworkContext : DbContext
    {
        public DbSet<CurrentTimeQuery> CurrentTimeQueries { get; set; }

        public ClockworkContext(DbContextOptions<ClockworkContext> options)
            : base(options)
        {
        }
    }
}
    