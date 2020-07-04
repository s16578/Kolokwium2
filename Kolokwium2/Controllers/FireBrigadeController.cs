using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.DTO.Request;
using Kolokwium2.DTO.Response;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers
{
    [Route("/api/firefighters")]
    [ApiController]
    public class FireBrigadeController : ControllerBase
    {
        private readonly IFireBrigadeDbService _context;

        public FireBrigadeController(IFireBrigadeDbService context)
        {
            _context = context;
        }
        
       [HttpGet("{id})"]
       [Route("/api/firefighters/{id}/actions")]

       public IActionResult GetAction(int id)
        {
            ICollection<FirefightersResponseDto> response;
            try
            {
             response = _context.GetActions(id);
            
            if(response.Count() == 0)
            {
                return Ok("No action for Fireman");
            }
            }
            catch (InvalidOperationException e)
            {
                return BadRequest(e);
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("/api/actions/1/fire-trucks")]

        public IActionResult PostFireTrackToAction(FireTruckRequestDto firetruck)
        {
            try
            {
                _context.PostFireTruck(firetruck);
            }catch(InvalidOperationException e)
            {
                return BadRequest(e);
            }
            return Ok();
        }

    }
}
