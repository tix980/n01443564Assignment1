using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the string "Hello World!" via POST method.
        /// </summary>
        /// <returns></returns>
        //POST api/Greeting -> "Hello World!"
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns the string "Greetings to{int id}people!"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET api/Greeting/id ->"Greetings to{int id}people!"
        public string Get(int id)
        {
            return "Greetings to" + " " + id + " " + "people!";

        }
    }
}