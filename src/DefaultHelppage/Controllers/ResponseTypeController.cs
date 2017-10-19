using RestDocumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DefaultHelppage.Controllers
{
    /// <summary>   A controller for handling response types. </summary>
    [RoutePrefix("api/ResponseType")]
    public class ResponseTypeController : ApiController
    {
        /// <summary>
        ///     Gets a sample object
        /// </summary>
        ///
        /// <param name="id">   The Identifier to get. </param>
        ///
        /// <returns>   A fancy sample dto. </returns>
        [Route("{id}", Name = "GetSample")]
        [ResponseType(typeof(SampleDto))]
        public IHttpActionResult Get(long id)
        {
            if (id == 23)
                return NotFound();

            return this.Content(HttpStatusCode.OK, new SampleDto
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
        /// <returns>   The created sample dto. </returns>
        [HttpPost]
        [ResponseType(typeof(SampleDto))]
        public IHttpActionResult Create([FromBody] SampleDto item)
        {
            if (item == null)
                return BadRequest();

            return CreatedAtRoute("GetSample", new { id = item.Id }, item);
        }
    }
}
