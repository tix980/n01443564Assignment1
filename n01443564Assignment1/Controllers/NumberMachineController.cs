using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    ///objective: create a method which applies four mathematical operations(+,-,*,/) to an input number
    /// <summary>
    ///  This method will take in an input for a number and output the total value of the input number with four mathematical operations applied.
    /// </summary>
    /// <param name="id">input of a number</param>
    /// <returns> the input number + the input number,dvided by the input number, then times the input number</returns>
    /// <example>
    /// GET api/NumberMachine/10 ->20
    /// GET api/NumberMachine/-5 ->-10
    /// GET api/NumberMachine/-9 ->-18
    /// </example>
    public class NumberMachineController : ApiController
    {
        //Get api/NumberMachine/id
        public int Get(int id)
        {
            return ((id + id) / id) * id;
        }
    }
}

