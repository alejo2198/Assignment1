using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Receives an integer input and performs the following operations
        /// 1.Add 5
        /// 2.Subtract 6
        /// 3.Divide by 2
        /// 4.Multiply by 7
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The value after the 4 operations</returns>
        /// <example>
        /// GET api/NumberMachine/0 -> 0
        /// </example>
        /// <example>
        /// GET api/NumberMachine/6 -> 14
        /// </example>
        /// <example>
        /// GET api/NumberMachine/10 -> 28
        /// </example>
        public int Get(int id)
        {
            ///brackets added for visualization of steps as well as for correct BEDMAS operation.
           return ((id + 5 - 6) / 2) * 7;
        }
    }
}
