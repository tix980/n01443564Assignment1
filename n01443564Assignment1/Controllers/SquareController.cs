using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    ///objective: create a method which returns the square of  the input value.
    /// <summary>
    ///  This method will take in an input for an interger number and calculate the value of the square of the input number
    /// </summary>
    /// <param name="id">An interger number</param>
    /// <returns> the input number *the input number</returns>
    /// <example>
    /// GET api/Square/2 -> 4
    /// GET api/Square/-2 -> 4
    /// GET api/Square/10 -> 100
    /// </example>
    public class SquareController : ApiController
    {
        //GET api/Square/id 
        public int Get(int id)
        {
            return id * id;
        }
    }
}