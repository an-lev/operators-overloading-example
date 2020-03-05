using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, BaseSpecification<Product> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSutisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}
