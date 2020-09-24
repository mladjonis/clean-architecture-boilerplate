using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstractions.Helpers
{
    public interface ITextHasher
    {
        string Hash(string plainText);
    }
}
