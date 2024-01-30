using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Receives an integer input, returns the square of that input.
        /// </summary>
        /// <param name="id">the integer to square</param>
        /// <returns>the square of integer id</returns>
        /// <example>
        /// GET api/Square/2 -> 4
        /// </example>
        /// <example>
        /// GET api/Square/-3 -> 9
        /// </example>   
        /// <example>
        /// GET api/Square/5 -> 25
        /// </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
