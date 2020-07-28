using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Convert
{
    class Byte
    {
        public int
        bits = 8;
        public static implicit operator int(Byte b)
        {
            return b.bits;
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public static explicit operator string(Person per)
        {
            return per.Name;
        }
    }

    class Money
    {
        public Money(decimal amount)
        {
            Amount = amount;
        }
        public decimal Amount { get; set; }
        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }
        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Conversão Inplicita do usuario
            Byte b = new Byte();
            int totalBits = b;
            Console.WriteLine(totalBits); //8

            // Conversão Explicita do usuario
            Person per = new Person { Age = 22, Name = "Ali" };
            string name = (string)per;
            Console.WriteLine(name); //Ali

            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;
            Console.WriteLine(amount); //42,42
            Console.WriteLine(truncatedAmount); //42

            int value = Convert.ToInt32(“42”);
            value = int.Parse(“42”);
            bool success = int.TryParse(“42”, out value);

            Console.ReadKey();
        }
    }
}
