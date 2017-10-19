using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreSwaggerDocumentation.Controllers
{
    /// <summary>   A controller for handling values. </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        /// <summary>   Gets all available values. </summary>
        ///
        /// <returns>   An enumerator that allows foreach to be used to process the matched items. </returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>   Gets the value using the given identifier as postfix. </summary>
        ///
        /// <param name="id">   The Identifier to get. </param>
        ///
        /// <returns>   A string. </returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>   Post this message. </summary>
        ///
        /// <param name="value">    The value. </param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>   Updates the value with the given ID. </summary>
        ///
        /// <param name="id">       The Identifier to get. </param>
        /// <param name="value">    The value. </param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>   Deletes the value with the given ID. </summary>
        ///
        /// <param name="id">   The Identifier to get. </param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
