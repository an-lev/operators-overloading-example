using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ColorSpecification : BaseSpecification<Product>
    {
        private readonly Color _color; 

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public override bool IsSutisfied(Product item)
        {
            return item.Color == _color;
        }
    }
}
