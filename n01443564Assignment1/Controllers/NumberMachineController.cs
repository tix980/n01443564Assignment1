﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01443564Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //Get api/NumberMachine/id
        public int Get(int id)
        {
            return ((id + id) / id) * id;
        }
    }
}

