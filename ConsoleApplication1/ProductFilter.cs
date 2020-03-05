using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var item in products)
            {
                if (item.Color == color)
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var item in products)
            {
                if (item.Size == size)
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var item in products)
            {
                if (item.Color == color && item.Size == size)
                {
                    yield return item;
                }
            }
        }
    }
}
