using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public Program(IFilter<Product> filter )
        {

        }

        static void Main(string[] args)
        {
            var apple = new Product { Name = "Aplle", Color = Color.Green, Size = Size.Small };
            var tree = new Product { Name = "Tree", Color = Color.Green, Size = Size.Large };
            var house = new Product { Name = "House", Color = Color.Blue, Size = Size.Large };

            var products = new[] { apple, tree, house };

            BaseSpecification<Product> colorSpecification = new ColorSpecification(Color.Green);
            BaseSpecification<Product> sizeSpecification = new SizeSpecification(Size.Small);

            var spec = colorSpecification & sizeSpecification;
            IFilter<Product> filter = new BetterFilter();

            foreach (var item in filter.Filter(products, spec))
            {
                Console.WriteLine(string.Format("{0} {1} {2}", item.Name, item.Size, item.Color));
            }
        }
    }
}
