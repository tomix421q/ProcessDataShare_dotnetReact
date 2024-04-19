using api.Interfaces.Live;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/opelmachines")]
    [ApiController]
    public class OpelController : ControllerBase
    {
        private readonly IOpelLiveDataService _opelLiveDataService;

        public OpelController(IOpelLiveDataService opelLiveDataService)
        {
            _opelLiveDataService = opelLiveDataService;
        }


        // 
        //________________________Armrest FD___________________________
        // 
        [HttpGet]
        [Route("armrestfront")]
        public async Task<IActionResult> GetOpelArmrestFrontLiveData()
        {
            string ipAddress = "10.184.159.45";
            var (success, errorMessage) = await _opelLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var opelData = await _opelLiveDataService.GetOpelArmrestLiveData();
                return Ok(opelData);
            }

        }

        // 
        //________________________Armrest RD___________________________
        // 
        [HttpGet]
        [Route("armrestrear")]
        public async Task<IActionResult> GetOpelArmrestRearLiveData()
        {
            string ipAddress = "10.184.159.46";
            var (success, errorMessage) = await _opelLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var opelData = await _opelLiveDataService.GetOpelArmrestLiveData();
                return Ok(opelData);
            }

        }

        // 
        //________________________Insert FD___________________________
        // 
        [HttpGet]
        [Route("insertfront")]
        public async Task<IActionResult> GetOpelInsertFrontLiveData()
        {
            string ipAddress = "10.184.159.48";
            var (success, errorMessage) = await _opelLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var opelData = await _opelLiveDataService.GetOpelInsertLiveData();
                return Ok(opelData);
            }
        }

        // 
        //________________________Insert RD___________________________
        // 
        [HttpGet]
        [Route("insertrear")]
        public async Task<IActionResult> GetOpelInsertRearLiveData()
        {
            string ipAddress = "10.184.159.47";
            var (success, errorMessage) = await _opelLiveDataService.SetIpAddress(ipAddress);
            if (!success)
            {
                return Ok(new { Error = errorMessage });
            }
            else
            {
                var opelData = await _opelLiveDataService.GetOpelInsertLiveData();
                return Ok(opelData);
            }
        }





    }
}