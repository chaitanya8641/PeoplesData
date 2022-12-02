using PeoplesData.Models;

namespace PeoplesData.Interfaces
{
    public interface IPeoplesdetailsService
    {
        Task<IEnumerable<PeopleDetail>> GetAllPeoplesDetailsAsync();
    }
}
