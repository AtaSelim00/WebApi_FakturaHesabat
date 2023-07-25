using FacturaProject.Business.Abstract;
using FacturaProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturaProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakturaController : ControllerBase
    {

        IHeaderService _headerService;
        IBodyService _bodyService;
        public FakturaController(IHeaderService headerService, IBodyService bodyService)
        {

            _headerService = headerService;
            _bodyService = bodyService;
        }

        [HttpPost("addHeader")]
        public IActionResult Add([FromBody] FakturaHeader fakturaHeader)
        {
            var result = _headerService.Insert(fakturaHeader);
            if (fakturaHeader == null)
            {
                return BadRequest(result);

            }
            else
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addBody")]
        public IActionResult Add([FromBody] FakturaBody fakturaBody)
        {
            var result = _bodyService.Insert(fakturaBody);
            if (fakturaBody == null)
            {
                return BadRequest(result);

            }
            else
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
