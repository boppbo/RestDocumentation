using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestDocumentation.Models;

namespace NetCoreSwaggerDocumentation.Controllers
{
    /// <summary>   A controller for handling response types. </summary>
    [Route("api/[controller]")]
    public class ResponseTypeController : Controller
    {
        /// <summary>
        ///     Gets a sample object
        /// </summary>
        ///
        /// <param name="id">   The Identifier to get. </param>
        ///
        /// <returns>   An IActionResult. </returns>
        [HttpGet("{id}", Name = "GetSample")]
        [ProducesResponseType(typeof(SampleDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult Get(long id)
        {
            if (id == 23)
                return NotFound();

            return new ObjectResult(new SampleDto
            {
                Id = id,
                IsValid = id % 2 == 0,
                Name = "Just a sample",
                NestedDto = new NestedDto { Id = id }
            });
        }

        /// <summary>
        ///     Creates a sample object
        /// </summary>
        ///
        /// <param name="item"> The item. </param>
        ///
        /// <returns>   An IActionResult. </returns>
        [HttpPost]
        [ProducesResponseType(typeof(SampleDto), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        public IActionResult Create([FromBody] SampleDto item)
        {
            if (item == null)
                return BadRequest();

            return CreatedAtRoute("GetSample", new { id = item.Id }, item);
        }
    }
}