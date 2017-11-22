using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Artjoker.IoC.Interfaces
{
    public interface IHelloGreeter : IGreeter
    {
        string SayHello();
    }
}