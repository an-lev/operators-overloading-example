using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class AndSpecification<T> : BaseSpecification<T>
    {
        private BaseSpecification<T> _first;
        private BaseSpecification<T> _second;

        public AndSpecification(BaseSpecification<T> first, BaseSpecification<T> second)
        {
            _first = first;
            _second = second;
        }

        public override bool IsSutisfied(T item)
        {
            return _first.IsSutisfied(item) && _second.IsSutisfied(item);
        }
    }
}
