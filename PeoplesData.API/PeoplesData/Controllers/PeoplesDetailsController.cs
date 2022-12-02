using Microsoft.AspNetCore.Mvc;
using PeoplesData.Interfaces;

namespace PeoplesData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesDetailsController : Controller
    {
        private readonly IPeoplesdetailsService _peoplesdetailsService;

        public PeoplesDetailsController(IPeoplesdetailsService peoplesdetailsService)
        {
            _peoplesdetailsService = peoplesdetailsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var result = await _peoplesdetailsService.GetAllPeoplesDetailsAsync();
            return Ok(result);
        }
    }
}
