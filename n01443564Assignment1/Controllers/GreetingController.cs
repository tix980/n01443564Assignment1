using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    ///objective: create a method which returns the string "Hello World!"
    /// <summary>
    ///  This method will would display "Hello World!" by sending a post request.
    /// </summary>
    /// <returns> the string"Hello World!"</returns>
    /// <example>
    ///POST api/Greeting -> "Hello World!"
    /// </example>
    public class GreetingController : ApiController
    {

        public string Post()
        {
            return "Hello World!";
        }

        ///objective: create a method which describes how many people are being greeted by entering an input number. 
        /// <summary>
        /// This method will take in an input for a number and will output the total value of people that are greeted.
        /// </summary>
        /// <param name="id">total number of people</param>
        /// <returns>sentence which describe total people are greeted</returns>
        /// <example>
        /// GET api/Greeting/3 ->"Greetings to 3 people!"
        /// GET api/Greeting/6 ->"Greetings to 6 people!"
        /// GET api/Greeting/0 ->"Greetings to 0 people!"
        /// </example>
        public string Get(int id)
        {
            return "Greetings to " + id +" people!";

        }
    }
}