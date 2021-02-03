using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    public class CurrencyController : ApiController
    {
        //objective: create methods which describe how much you have given a certain number of coins

        // public means everyone can access tho http
        //{} is the method body

        /// <summary>
        /// This method will take in an input for the number of two dollars and will output the total value
        /// </summary>
        /// <param name="id">input of number of toonies</param>
        /// <returns>sentce which describe total currency</returns>
        /// <example>
        /// GET api/Currency/10 ->"you have $20 dollars"
        /// GET api/Currencyt/1 ->"you have $2 dollar"
        /// </example>
        public string Get(int id)
        {
            //the value of a tonnie is $2.00
            int toonievalue = 2;
            int amount = id * toonievalue;
            string message = "you have $" + amount.ToString() + " dollars!";
            return message;

        }

        /// <summary>
        /// This method will take in an input for the number of quarters and will output the total value
        /// curl -d "" "localhost:63481/api/currency/101", -d is data, "" is extra data
        /// </summary>
        /// <param name="id">input of number of quarters</param>
        /// <returns>sentce which describe total currency</returns>
        /// <example>
        /// POST api/Currency/10 ->"you have $2.50 dollars"
        /// POST api/Currencyt/1 ->"you have $0.25 dollar"
        /// </example>
        // decimal for quarters, with a M. use it on assignment 1 last question       
        public string Post(int id)
        {
            decimal quartervalue = 0.25M;
            decimal amount = id * quartervalue;
            string message = "you have $" + amount.ToString() + " dollars!";
            return message;
        }
    }
}



return new string[]
{
                int
                ((id)/14)+1 +" "+"fortnights at $5.50/FN = $" + (((id)/14)+1)*5.50 + " " +"CAD",
                "HST 13% = $" + ((((id)/14)+1)*5.50) * 0.13,
                "Total = $" + (((((id)/14)+1)*5.50) + ((((id)/14)+1)*5.50) * 0.13),
};
        }