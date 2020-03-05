using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, BaseSpecification<T> specification);
    }
}
