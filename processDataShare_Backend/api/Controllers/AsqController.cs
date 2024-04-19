using Microsoft.AspNetCore.Mvc;
using api.Interfaces.Live;


namespace Stackup.Api.Controllers
{

    [Route("api/asqmachines")]
    [ApiController]
    public class AsqController : ControllerBase
    {
        private readonly IAsqLiveDataService _asqLiveDataService;

        public AsqController(IAsqLiveDataService asqLiveDataService)
        {
            _asqLiveDataService = asqLiveDataService;
        }



        // 
        //________________________Asq_2___________________________
        // 
        [HttpGet]
        [Route("asq2")]
        public async Task<IActionResult> GetAsq2LiveData()
        {
            string ipAddress = "10.184.159.109";
            var (success, errorMessage) = await _asqLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var asqData = await _asqLiveDataService.GetAsqLiveData();
                return Ok(asqData);
            }

        }

        // 
        //________________________Asq_3___________________________
        // 
        [HttpGet]
        [Route("asq3")]
        public async Task<IActionResult> GetAsq3LiveData()
        {
            string ipAddress = "10.184.159.240";
            var (success, errorMessage) = await _asqLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var asqData = await _asqLiveDataService.GetAsqLiveData();
                return Ok(asqData);
            }

        }

        // 
        //________________________Asq_4___________________________
        // 
        [HttpGet]
        [Route("asq4")]
        public async Task<IActionResult> GetAsq4LiveData()
        {
            string ipAddress = "10.184.159.12";
            var (success, errorMessage) = await _asqLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var asqData = await _asqLiveDataService.GetAsqLiveData();
                return Ok(asqData);
            }

        }

        // 
        //________________________Asq_5___________________________
        // 
        [HttpGet]
        [Route("asq5")]
        public async Task<IActionResult> GetAsq5LiveData()
        {
            string ipAddress = "10.184.159.108";
            var (success, errorMessage) = await _asqLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var asqData = await _asqLiveDataService.GetAsqLiveData();
                return Ok(asqData);
            }

        }

        // 
        //________________________Asq_6___________________________
        // 
        [HttpGet]
        [Route("asq6")]
        public async Task<IActionResult> GetAsq6LiveData()
        {
            string ipAddress = "10.184.159.184";
            var (success, errorMessage) = await _asqLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var asqData = await _asqLiveDataService.GetAsqLiveData();
                return Ok(asqData);
            }

        }









    }
}


