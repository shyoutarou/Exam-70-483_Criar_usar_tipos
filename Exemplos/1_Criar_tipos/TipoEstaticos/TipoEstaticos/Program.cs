using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoEstaticos
{
    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }

    static class Helper
    {
        public static int age;

        static Helper()
        {
            age = 22;
        }

        public static bool isLessThan_Extension(int compareValue)
        {
            //return true if origin value is less
            if (age < compareValue)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var oprod = new Product();
            var ocalc = new Calculator();

            oprod.Price = 1.99m;
            var desconto = ocalc.CalculateDiscount(oprod);
            Console.WriteLine(desconto); // 1,791

            Console.WriteLine(Helper.age); // 22
            Console.WriteLine(Helper.isLessThan_Extension(16));


            Console.ReadKey();
        }
    }
}
