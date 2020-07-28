using System;

namespace Enumeracao_Enum
{
    class Program
    {
        //enum Dias { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        //enum Dias : short { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        //enum Dias { Domingo = 10, Segunda = 25, Terça = 48, Quarta = 8, Quinta, Sexta, Sábado };

        //Para acessar o valor de vários elementos ao mesmo tempo, é preciso antes preparar 
        //a enumeração.O atributo System.FlagsAttribute deve ser usado na declaração da 
        //enumeração.O exemplo completo que segue retorna Segunda, Sexta, Sábado:
        [Flags] public enum Dias { Segunda = 0x01, Quarta = 0x02, Sexta = 0x04, Sábado = 0x08, }
        enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            //int x = (int)Dias.Domingo;
            //int y = (int)Dias.Sexta;
            //Console.WriteLine(x);  // 0
            //Console.WriteLine(y);  // 5
            //Console.ReadKey();

            Dias d = Dias.Sábado | Dias.Segunda | Dias.Sexta;
            Console.WriteLine(d); // Segunda, Sexta, Sábado

            string name = Enum.GetName(typeof(Dias), 2);
            Console.WriteLine("The 2th day in the enum is " + name); //The 2th day in the enum is Quarta
            foreach (int values in Enum.GetValues(typeof(Dias)))
            {
                Console.WriteLine(values); //1 2 4 8
            }

            Console.ReadKey();
        }
    }
}
