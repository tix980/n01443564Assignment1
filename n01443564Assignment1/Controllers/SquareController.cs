using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    public class SquareController : ApiController
    {   /// <summary>
        /// Returns the square of the integer input {id}.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET api/Square/id 
        public int Get(int id)
        {
            return id * id;
        }
    }
}