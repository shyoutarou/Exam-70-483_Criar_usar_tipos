using System;
using System.Linq.Expressions;

namespace Expressao_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(addFunc(2, 3)); // 5

            BlockExpression blockExpr = Expression.Block(
                    Expression.Call(null, typeof(Console).GetMethod("Write",
                    new Type[] { typeof(String) }), Expression.Constant("Hello ")),
                    Expression.Call(null, typeof(Console).GetMethod("WriteLine",
                    new Type[] { typeof(String) }), Expression.Constant("World!"))
                    );

            Expression.Lambda<Action>(blockExpr).Compile()(); // Hello World!

            Console.ReadKey();
        }
    }
}
