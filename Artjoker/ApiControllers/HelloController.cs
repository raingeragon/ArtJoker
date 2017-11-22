using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Artjoker.IoC;
using Artjoker.IoC.Interfaces;

namespace Artjoker.ApiControllers
{
    public class HelloController : ApiController
    {
        IGreeter greeter;
        public HelloController(IHelloGreeter igreeter)
        {
            this.greeter = igreeter;
        }
        [HttpGet]
        public string Get()
        {
            return greeter.SayHello();
        }

    }
}
