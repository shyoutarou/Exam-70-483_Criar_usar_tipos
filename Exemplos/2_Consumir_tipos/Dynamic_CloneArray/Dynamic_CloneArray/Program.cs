using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_CloneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make an array of numbers.
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Error compilação: This doesn't work because array1.Clone is an object.
            //int[] array2 = array1.Clone();

            // This works.
            int[] array3 = (int[])array1.Clone();
            array3[5] = 55;

            // This also works.
            dynamic array4 = array1.Clone();
            array4[6] = 66;
            //Error execução: 'Não é possível converter implicitamente tipo 'string' em 'int''
            array4[7] = "This won't work";
        }
    }
}
