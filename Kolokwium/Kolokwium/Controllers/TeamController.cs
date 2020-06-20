using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Exceptions;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IFootballDbService _service;
        public TeamController(IFootballDbService service)
        {
            _service = service;
        }

        [Route("/api/championships/1/teams")]
        [HttpGet("{id:int}")]
        public IActionResult GetTeams(int id)
        {
            try
            {
                var result = _service.GetTeams(id);
                return Ok(result);
            }
            catch (NotFoundChampionShipException exc)
            {
                return NotFound(exc.Message);
            }
        }
    }
}