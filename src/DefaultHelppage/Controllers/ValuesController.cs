using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DefaultHelppage.Controllers
{
    /// <summary>   A controller for handling values. </summary>
    public class ValuesController : ApiController
    {
        /// <summary>   Gets all available values. </summary>
        ///
        /// <returns>   An enumerator that allows foreach to be used to process the matched items. </returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>   Gets the value using the given identifier as postfix. </summary>
        ///
        /// <param name="id">   The Identifier. </param>
        ///
        /// <returns>   A string. </returns>
        public string Get(int id)
        {
            return "value"+id;
        }

        /// <summary>   Post this message. </summary>
        ///
        /// <param name="value">    The value. </param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>   Updates the value with the given ID. </summary>
        ///
        /// <param name="id">       The Identifier to update. </param>
        /// <param name="value">    The value. </param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>   Deletes the value with the given ID. </summary>
        ///
        /// <param name="id">   The Identifier to delete. </param>
        public void Delete(int id)
        {
        }
    }
}
