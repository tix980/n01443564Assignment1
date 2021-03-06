﻿using System;
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
            ///objective: create a method which returns total value of fornights fees, HST 13% tax, and hosting cost
            ///by entering an integer number of fornight.
            /// <summary>
            /// This method will take in an input for the number of days and will calculate the total value of fornights,
            ///HST 13% tax, and the hosting cost.
            /// </summary>
            /// <param name="id">integer  number of days</param>
            /// <returns>Total fornights fees, Total HST 13% tax, and Total hosting cost</returns>
            /// <example>
            /// GET api/HostingCost/0 ->“1 fortnights at $5.50/FN = $5.50 CAD”,“HST 13% = $0.72 CAD”,“Total = $6.22 CAD”
            /// GET api/HostingCost/14 ->“2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”
            /// GET api/HostingCost/15 ->“2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”
            /// GET api/HostingCost/21 ->“2 fortnights at $5.50/FN = $11.00 CAD”,“HST 13% = $1.43 CAD”,“Total = $12.43 CAD”
            /// GET api/HostingCost/28 ->“3 fortnights at $5.50/FN = $16.50 CAD”,“HST 13% = $2.14 CAD”,“Total = $18.64 CAD”
            /// </example>
            decimal totalFornights = (id/ 14)+1;
            totalFornights = Math.Round(totalFornights,2);
            decimal totalFornightsFees = totalFornights * 5.50M;
            totalFornightsFees = Math.Round(totalFornightsFees,2);
            decimal hst = totalFornightsFees * 0.13M;
            hst = Math.Round(hst,2);
            decimal total = totalFornightsFees + hst;
            return new string[]
            {
                totalFornights.ToString() + " fortnights at $5.50/FN = $" + totalFornightsFees.ToString() +" CAD",
                "HST 13% = $" + hst,
                "Total = $" + total,
            };
        }
    }
}

