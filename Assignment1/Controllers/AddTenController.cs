using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives an integer input,adds 10 to the input.
        /// </summary>
        /// <param name="id">the integer that 10 will be added to</param>
        /// <returns>the integer input plus 10d</returns>
        /// <example>
        /// GET api/Square/2 -> 8
        /// </example>
        /// <example>
        /// GET api/Square/-3 -> 7
        /// </example>   
        /// <example>
        /// GET api/Square/5 -> 15
        /// </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
