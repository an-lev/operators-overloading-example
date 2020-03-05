using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class SizeSpecification : BaseSpecification<Product>
    {
        private readonly Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public override bool IsSutisfied(Product item)
        {
            return item.Size == _size;
        }
    }
}
