using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumerableEnumerator
{
    public class InfinityNumbersListEnumerator : IEnumerator<int>
    {
        //Por que -1? O cursor começa antes da posição zero(Reset), então 
        //este valor deve ser zero após a primeira chamada do método MoveNext.
        private int _current = -1;
        public int Current => _current;

        object IEnumerator.Current => _current;

        public bool MoveNext()
        {
            _current++;
            return true;
        }

        public void Reset()
        {
            _current = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }

    //Por enquanto vamos deixar o método Dispose assim mesmo.
    //Agora vamos para a implementação da lista que irá implementar IEnumerable<int>.
    public class InfinityNumbersList : IEnumerable<int>
    {
        private readonly InfinityNumbersListEnumerator _enumerator;

        public InfinityNumbersList()
        {
            _enumerator = new InfinityNumbersListEnumerator();
        }

        public IEnumerator<int> GetEnumerator() => _enumerator;

        IEnumerator IEnumerable.GetEnumerator() => _enumerator;
    }

    class Program
    {
        static void Main(string[] args)
        {
            InfinityNumbersList allNumbers = new InfinityNumbersList();
            foreach (int number in allNumbers)
            {
                Console.WriteLine(number);
                if (number >= 100)
                    break;
            }

            Console.ReadKey();
        }
    }
}
