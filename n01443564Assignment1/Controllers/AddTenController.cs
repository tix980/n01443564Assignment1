using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{   
    ///objective: create a method which returns 10 more than the input value.
    /// <summary>
    ///  This method will take in an input for an interger number and calculate the value of 10 more than the input number
    /// </summary>
    /// <param name="id"> An interger number</param>
    /// <returns> the input number + 10</returns>
    /// <example>
    /// GET api/AddTen/21 ->31
    /// GET api/AddTen/0 ->10
    /// GET api/AddTen/-9 ->1
    /// </example>
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            return id + 10;
        }

    }
}
