using PeoplesData.Interfaces;
using PeoplesData.Models;

namespace PeoplesData.Services
{
    public class PeoplesdetailsService : IPeoplesdetailsService
    {
        private readonly IPeoplesdetailsRepository _peoplesdetailsRepository;

        public PeoplesdetailsService(IPeoplesdetailsRepository peoplesdetailsRepository)
        {
            _peoplesdetailsRepository = peoplesdetailsRepository;
        }

        public async Task<IEnumerable<PeopleDetail>> GetAllPeoplesDetailsAsync()
        {
            try
            {
                IEnumerable<PeopleDetail> peopleDetails = await _peoplesdetailsRepository.GetAllPeoplesDetailsAsync();
                return peopleDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
