using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Value_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "texto aqui";
            char extrai = b[6];
            Console.WriteLine(extrai); //a
            Console.WriteLine(extrai + b); //atexto aqui
            Console.WriteLine(extrai + "2"); //a2
            Console.WriteLine(b + '2'); //texto aqui2
            Console.WriteLine(extrai + '2'); //147
            Console.WriteLine((int)extrai); //97 , valor ASCII
            Console.WriteLine(extrai + 2); //99

            // cria uma variável para armazenar um tipo de valor usando o formulário de alias 
            // mas não atribui uma variável
            int myInt;
            int myNewInt = new int();

            // cria uma variável para armazenar um tipo de valor .NET 
            // esse tipo é a versão .NET do formulário de alias int 
            // observe o uso da palavra-chave new, estamos criando um objeto 
            // do System.Int32 class
            System.Int32 myInt32 = new System.Int32();

            // você precisará comentar a primeira instrução Console.WriteLine 
            // como o Visual Studio gerará um erro sobre o uso de uma variável 
            // não atribuída. Isso evita o uso de um valor que foi armazenado no 
            // local da memória antes da criação dessa variável
            //Console.WriteLine (myInt);

            // imprime o valor padrão atribuído a uma variável int 
            // que não tinha nenhum valor atribuído anteriormente
            Console.WriteLine(myNewInt);

            // essa instrução funcionará bem e imprimirá o valor padrão para 
            // esse tipo, que nesse caso é 0
            Console.WriteLine(myInt32);


            // assigning one value type to another
            int myInt2;
            int secondInt;
            // myInt will be assigned the value of 2 
            myInt2 = 2;
            // secondInt will contain the value 2 after this statement executes
            secondInt = myInt2;

            myInt2 = 3;
            // output the value of the variables
            Console.WriteLine(myInt2);
            Console.WriteLine(secondInt);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
