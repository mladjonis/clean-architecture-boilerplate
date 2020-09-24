using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstractions
{
    public interface IHandler<TResponse>
       where TResponse : struct
    {
        TResponse Handle();
    }
}
