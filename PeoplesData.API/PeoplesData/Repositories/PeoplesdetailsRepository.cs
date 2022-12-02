using Microsoft.EntityFrameworkCore;
using PeoplesData.Contexts;
using PeoplesData.Interfaces;
using PeoplesData.Models;

namespace PeoplesData.Repositories
{
    public class PeoplesdetailsRepository : IPeoplesdetailsRepository
    {
        private readonly DefaultContext _context;

        public PeoplesdetailsRepository(DefaultContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PeopleDetail>> GetAllPeoplesDetailsAsync()
        {
            return await _context.PeopleDetails.ToListAsync();
        }
    }
}
