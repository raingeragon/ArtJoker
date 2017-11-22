using Artjoker.IoC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Artjoker.IoC
{
    public class HiGreeter : IHiGreeter
    {
        public string SayHello()
        {
            return "Hi there!";
        }
    }
}