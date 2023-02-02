using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week4IfStatement.Controllers
{
    public class Practice2Controller : ApiController
    {
        //find the quardrant
        // each quardrant is 90 degree
        /// <summary>
        /// Find the quardrant
        /// </summary>
        /// <param name="x">x axis on horizontal line</param>
        /// <param name="y">y axis on vertical line</param>
        /// <returns>
        /// integers of 1/1 -> 1
        /// integers of -1/-1 -> 3
        /// integers of 1/-1 -> 4
        /// integers of 0/10 -> 0
        /// </returns>

        [HttpGet]
        [Route("api/Week4IfStatement/Practice2/{x}/{y}")]

        public string Practice2(int x, int y)
        {
            var q90 = (x > 0 && y > 0);
            var q180 = (x < 0 && y > 0);
            var q270 = (x < 0 && y < 0);
            var q360 = (x > 0 && y < 0);
            var Practice2 =  q90 || q180 || q270 || q360;
            
            
            if (Practice2 = q90)
            {
                return "The quardrant number is 1";
            } 
            else if (Practice2 = q180)
            {
                return "The quardrant number is 2";
            }
            else if (Practice2 = q270)
            {
                return "The quardrant number is 3";
            } 
            else if (Practice2 = q360)
            {
                return "The quardreant number is 4";
            }
            else
            {
                return "Output 0 does not lie in a quardrant";

            }
        }
    }
}
