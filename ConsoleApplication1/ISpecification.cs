using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class BaseSpecification<T> 
    {
        public abstract bool IsSutisfied(T item);

        public static BaseSpecification<T> operator &(
            BaseSpecification<T> first,
            BaseSpecification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }
}
