using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week4IfStatement.Controllers
{
    public class Practice1Controller : ApiController
    {
        // To find out if had enough money for toy
        // If has enough -> true
        // if not enough -> false
        // routing curl http://localhost:62784/api/week4ifstatement/practiace1/
        // the denomination per unit of 0/0/0/15/0 -> 'True'
        // the denomination per unit of 20/0/*0/1/1 -> 'False'
        // the denomination per unit of 100/20/2/4/0 -> 'True'
        /// <summary>
        /// To find out if enough coin for toy
        /// </summary>
        /// <param name="n">number of units in Nickle</param>
        /// <param name="d">number of units in Dime</param>
        /// <param name="q">number of units in quarter</param>
        /// <param name="l">number of units in Loonies</param>
        /// <param name="t">number of units in Toonies</param>
        /// <returns>The total units of each denomination is great than 10.50</returns>
        [HttpGet]
        [Route("api/Week4IfStatement/Practice1/{n}/{d}/{q}/{l}/{t}")]

        public string Practice1 (int n, int d, int q, int l, int t)
        {
            var TotalN = 0.05 * n;
            var TotalD = 0.10 * d;
            var TotalQ = 0.25 * q;
            var TotalL  = 1.00 * l;
            var TotalT  = 2.00 * t;
            var Practice1 = TotalN + TotalD + TotalQ + TotalL + TotalT;

            if (Practice1 > 10.50)
            {
                return "True";
            } else
            {
                return "False";
            }
        }

    }
}
