using Microsoft.EntityFrameworkCore;
using PeoplesData.Models;

namespace PeoplesData.Contexts
{
    public class DefaultContext : DbContext
    {
        public virtual DbSet<PeopleDetail> PeopleDetails { get; set; }

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }
    }
}
