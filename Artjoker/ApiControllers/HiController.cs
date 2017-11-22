using Artjoker.IoC;
using Artjoker.IoC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Artjoker.ApiControllers
{
    public class HiController : ApiController
    {
        IGreeter greeter;
        public HiController(IHiGreeter igreeter)
        {
            greeter = igreeter;
        }
        [HttpGet]
        public string Get()
        {
            return greeter.SayHello();
        }
    }
}
