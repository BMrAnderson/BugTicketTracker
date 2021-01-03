using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IDescribable
    {
        string Title { get; }
        string Description { get; }
    }
}
