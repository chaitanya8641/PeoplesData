using PeoplesData.Models;

namespace PeoplesData.Interfaces
{
    public interface IPeoplesdetailsRepository
    {
        Task<IEnumerable<PeopleDetail>> GetAllPeoplesDetailsAsync();
    }
}
