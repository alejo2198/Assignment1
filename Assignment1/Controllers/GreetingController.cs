using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Post request that returns "Hello World!"
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST api/Greeting -> "Hello World!"
        /// </example>
        /// <example>
        /// POST api/Greeting/"anything" -> "Hello World!"
        /// </example>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Receives integer input that determines amount of people. Greets that many people.
        /// </summary>
        /// <param name="id">integer that represents amount of people</param>
        /// <returns>A greeting to the number of people enetered by the parameter </returns>
        /// <example>
        /// GET api/Greeting/3 -> "Greetings to 3 people!"
        /// </example>
        /// <example>
        /// GET api/Greeting/7 -> "Greetings to 7 people!"
        /// </example>
        /// <example>
        /// GET api/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        public string Get (int id)
        {
            return "Greetings to " + id.ToString() + " people!";
        }
    }
}
