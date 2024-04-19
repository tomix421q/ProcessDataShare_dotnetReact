using api.Interfaces.Live;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/eqcmachines")]
    [ApiController]
    public class EqcController : ControllerBase
    {
        private readonly IEqcLiveDataService _eqcLiveDataService;

        public EqcController(IEqcLiveDataService eqcLiveDataService)
        {
            _eqcLiveDataService = eqcLiveDataService;
        }

        // 
        //________________________EQC_1___________________________
        // 
        [HttpGet]
        [Route("eqc1")]
        public async Task<IActionResult> GetEqc1LiveData()
        {
            string ipAddress = "10.184.159.173";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_2___________________________
        // 
        [HttpGet]
        [Route("eqc2")]
        public async Task<IActionResult> GetEqc2LiveData()
        {
            string ipAddress = "10.184.159.174";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_3___________________________
        // 
        [HttpGet]
        [Route("eqc3")]
        public async Task<IActionResult> GetEqc3LiveData()
        {
            string ipAddress = "10.184.159.175";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_4___________________________
        // 
        [HttpGet]
        [Route("eqc4")]
        public async Task<IActionResult> GetEqc4LiveData()
        {
            string ipAddress = "10.184.159.176";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_5___________________________
        // 
        [HttpGet]
        [Route("eqc5")]
        public async Task<IActionResult> GetEqc5LiveData()
        {
            string ipAddress = "10.184.159.89";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_6___________________________
        // 
        [HttpGet]
        [Route("eqc6")]
        public async Task<IActionResult> GetEqc6LiveData()
        {
            string ipAddress = "10.184.159.99";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_7___________________________
        // 
        [HttpGet]
        [Route("eqc7")]
        public async Task<IActionResult> GetEqc7LiveData()
        {
            string ipAddress = "10.184.159.171";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }

        // 
        //________________________EQC_8___________________________
        // 
        [HttpGet]
        [Route("eqc8")]
        public async Task<IActionResult> GetEqc8LiveData()
        {
            string ipAddress = "10.184.159.101";
            var (success, errorMessage) = await _eqcLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var eqcData = await _eqcLiveDataService.GetEqcLiveData();
                return Ok(eqcData);
            }

        }
    }
}