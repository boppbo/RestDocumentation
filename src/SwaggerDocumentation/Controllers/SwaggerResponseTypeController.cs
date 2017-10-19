using RestDocumentation.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SwaggerDocumentation.Controllers
{
    /// <summary>   A controller for handling response types. </summary>
    [RoutePrefix("api/SwaggerResponseType")]
    public class SwaggerResponseTypeController : ApiController
    {
        /// <summary>
        ///     Gets a sample object
        /// </summary>
        ///
        /// <param name="id">   The Identifier to get. </param>
        ///
        /// <returns>   A fancy sample. </returns>
        [Route("{id}", Name = "SwaggerGetSample")]
        [SwaggerResponse(HttpStatusCode.OK, "", typeof(SampleDto))]
        [SwaggerResponse(HttpStatusCode.NotFound)]
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
        [SwaggerResponse(HttpStatusCode.Created, "", typeof(SampleDto))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.Unauthorized)]
        [SwaggerResponse(HttpStatusCode.Forbidden)]
        public IHttpActionResult Create([FromBody] SampleDto item)
        {
            if (item == null)
                return BadRequest();

            return CreatedAtRoute("SwaggerGetSample", new { id = item.Id }, item);
        }
    }
}
