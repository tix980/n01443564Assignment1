using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//
namespace n01443564Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {
            return new string[]
            {
                ((id)/14)+1 +" "+"fortnights at $5.50/FN = $" + (((id)/14)+1)*5.50 + " " +"CAD",
                "HST 13% = $" + ((((id)/14)+1)*5.50) * 0.13,
                "Total = $" + (((((id)/14)+1)*5.50) + ((((id)/14)+1)*5.50) * 0.13),
            };
        }
    }
}

