using api.Helpers;
using api.Interfaces.CollectFromDb;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/db")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {

        private readonly IDataFromDb _dbdata;

        public DatabaseController(IDataFromDb dbdata)
        {
            _dbdata = dbdata;
        }


        // _________________________________EQC MACHINES________________________________
        [HttpGet]
        [Route("eqc1")]
        public async Task<IActionResult> GetAlleqc1([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc1Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc2")]
        public async Task<IActionResult> GetAlleqc2([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc2Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc3")]
        public async Task<IActionResult> GetAlleqc3([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc3Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc4")]
        public async Task<IActionResult> GetAlleqc4([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc4Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc5")]
        public async Task<IActionResult> GetAlleqc5([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc5Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc6")]
        public async Task<IActionResult> GetAlleqc6([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc6Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc7")]
        public async Task<IActionResult> GetAlleqc7([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc7Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }

        [HttpGet]
        [Route("eqc8")]
        public async Task<IActionResult> GetAlleqc8([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var eqcdb = await _dbdata.GetAllEqc8Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { eqcdb, totalRecords });
        }



        // _________________________________ASQ MACHINES________________________________
        [HttpGet]
        [Route("asq2")]
        public async Task<IActionResult> GetAllasq2([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var asqdb = await _dbdata.GetAllAsq2Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { asqdb, totalRecords });
        }

        [HttpGet]
        [Route("asq3")]
        public async Task<IActionResult> GetAllasq3([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var asqdb = await _dbdata.GetAllAsq3Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { asqdb, totalRecords });
        }


        [HttpGet]
        [Route("asq4")]
        public async Task<IActionResult> GetAllasq4([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var asqdb = await _dbdata.GetAllAsq4Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { asqdb, totalRecords });
        }



        [HttpGet]
        [Route("asq5")]
        public async Task<IActionResult> GetAllasq5([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var asqdb = await _dbdata.GetAllAsq5Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { asqdb, totalRecords });
        }



        [HttpGet]
        [Route("asq6")]
        public async Task<IActionResult> GetAllasq6([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var asqdb = await _dbdata.GetAllAsq6Async(query);
            var totalRecords = await _dbdata.GetNumRecords();
            return Ok(new { asqdb, totalRecords });
        }


    }
}