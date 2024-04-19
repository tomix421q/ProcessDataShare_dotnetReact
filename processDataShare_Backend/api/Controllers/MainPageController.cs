using api.Interfaces.Live;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    public class MainPageController : ControllerBase
    {
        private readonly IMainLiveDataService _mainLiveDataService;

        public MainPageController(IMainLiveDataService mainLiveDataService)
        {
            _mainLiveDataService = mainLiveDataService;
        }


        [HttpGet]
        [Route("dashboard-live-data")]
        public async Task<IActionResult> GetDashboardLiveData()
        {
            var dashboardData = await _mainLiveDataService.GetDashboardData();
            return Ok(dashboardData);
        }





















    }
}