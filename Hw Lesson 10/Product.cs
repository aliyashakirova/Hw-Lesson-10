using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProject
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public virtual void ProductInfo(Product product)
        {
            Console.WriteLine($"The product name is {product.Name}");
            Console.WriteLine($"The price is {product.Price}");
            Console.WriteLine($"The production date is {product.ProductionDate}");
            Console.WriteLine($"The expiration date is {product.ExpireDate}");
            if (IsExpired(product))
                Console.WriteLine("The product is expired.");
            else
                Console.WriteLine("The product is ok");
        }

        public virtual bool IsExpired(Product product)
        {
            bool exp = false;
            if (product.ExpireDate < DateTime.Now)
            {
                //Console.WriteLine("It's expired");
                exp = true;
            }
            return exp;
        }
        public List<Product> ExpensiveProducts(List<Product> prodList)
        {
            List<Product> expProducts = new List<Product>();
            foreach (var product in prodList)
            {
                if (IsPriceMoreThan300(product))
                {
                    expProducts.Add(product);
                }
            }
            return expProducts;
        }

        public bool IsPriceMoreThan300(Product product)
        {
            if (product.Price>300)
            {
                return true;
            }
            return false;
        }
        public void PrintNameAndCountPair(Dictionary<string, int> productDictionary)
        {
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Name = {product.Key}, Count = {product.Value}");
            }
        }

        public void PrintNameAndPricePair(Dictionary<string, double> productDictionary)
        {
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Name = {product.Key}, Price = {product.Value}");
            }
        }
        public void PrintName(Dictionary<string, int> productDictionary)
        {
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Name = {product.Key}");
            }
        }

        public void PrintCount(Dictionary<string, int> productDictionary)
        {
            foreach (var product in productDictionary)
            {
                Console.WriteLine($"Name = {product.Value}");
            }
        }

        public Product(string name, double price, DateTime pd, DateTime ed)
        {
            Name = name;
            Price = price;
            ProductionDate = pd;
            ExpireDate = ed;
        }
        public Product()
        {

        }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public class ProductComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                //first by Name
                int result = x.Name.CompareTo(y.Name);

                //then Price
                if (result == 0)
                    result = x.Price.CompareTo(y.Price);

                return result;
            }
        }

    }
}
