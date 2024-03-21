using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.BLL.Services.Interfaces;
using Sales.API.Utils;
using Sales.DTO;

namespace Sales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IJourneyService _journeyService;

        public FlightController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
        }

        [HttpGet]
        [Route("Journey")]
        public async Task<IActionResult> Journey(string origin, string dest, int? maxFlights)
        {
            var response = new HttpResponse<JourneyDTO>();

            try
            {
                response.IsSuccess = true;
                response.Value = await _journeyService.GetJourneyPath(origin, dest, maxFlights);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }

            return Ok(response);
        }
    }
}
