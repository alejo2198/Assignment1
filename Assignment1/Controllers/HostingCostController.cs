using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// Receives an integer representing the number of days elapsed since the client started web hosting. 
        /// This API Call is responsible for calculating the price that it will cost for those days. It uses Fortnights
        /// to calculate the cost + HST.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The price before tax, the dollar amount of tax and the total cost.</returns>
        /// <example>
        /// GET api/HostingCost/0 -> 
        /// “1 fortnights at $5.50/FN = $5.50 CAD”
        /// “HST 13% = $0.72 CAD”
        /// “Total = $6.22 CAD"
        /// </example>
        /// <example>
        /// GET api/HostingCost/15 -> 
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        /// “HST 13% = $1.43 CAD”
        /// “Total = $12.43 CAD"
        /// </example>
        /// <example>
        /// GET api/HostingCost/140 -> 
        /// “1 fortnights at $5.50/FN = $60.50 CAD”
        /// “HST 13% = $7.87 CAD”
        /// “Total = $68.37 CAD"
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            //calculate number of fortnights
            int fortnights = (id / 14) + 1;

            //calculate total cost before taxes
            double preTax = fortnights * 5.5;

            //calculate cost of HST
            double hst = preTax * .13;

            //calculate total cost for the client
            double total = preTax + hst;

            //toString("0.00") is used to format integers into strings with 2 decimal places
            return new string[] { 
                fortnights.ToString() + " fortnights at $5.50/FN = $" + preTax.ToString("0.00") + " CAD",           
                "HST 13% = $" + hst.ToString("0.00") + " CAD",
                "Total = $" + total.ToString("0.00") + " CAD"
            };
        }
    }
}
