using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Convert
{
    class Program
    {
        static void Main(string[] args)
        {

            int packedValue;

            // The API function call sets packedValue here....
            packedValue = 47483648;

            // Convert the packed value into an array of bytes.
            byte[] valueBytes = BitConverter.GetBytes(packedValue);

            Console.WriteLine(BitConverter.ToString(valueBytes));
            if (BitConverter.IsLittleEndian)
                Array.Reverse(valueBytes);

            // Unpack the two values.
            short firstHalf = BitConverter.ToInt16(valueBytes, 0); // 20
            short secondHalf = BitConverter.ToInt16(valueBytes, 2); // 0
            Console.WriteLine(firstHalf); // -29952
            Console.WriteLine(secondHalf); // 724

            byte[] recbytes = new byte[4];
            recbytes[0] = BitConverter.GetBytes(firstHalf)[0];
            recbytes[1] = BitConverter.GetBytes(firstHalf)[1];
            recbytes[2] = BitConverter.GetBytes(secondHalf)[0];
            recbytes[3] = BitConverter.GetBytes(secondHalf)[1];
            int reconstituted = BitConverter.ToInt32(recbytes, 0);
            Console.WriteLine(reconstituted); // 47483648

            Console.ReadKey();
        }
    }
}
