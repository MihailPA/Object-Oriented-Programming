////Problem 5. 64 Bit array
//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05._64_Bit_array
{
    public class Test
    {
        public static void Main()
        {
            TestBitArray64();
        }

        private static void TestBitArray64()
        {
            var sb = new StringBuilder();

            var bitArray = new BitArray(32);
            sb.AppendLine("Number: 32");

            sb.Append("Indexer: ");
            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                sb.Append(bitArray[i]);
            }

            sb.Append("\nForeach: ");
            Console.Write(sb);
            sb.Clear();

            foreach (var bit in bitArray)
            {
                sb.Insert(0, bit);
            }

            var anotherbitArray = new BitArray(46);

            sb.AppendLine()
                .AppendLine("\nAnother number: 46")
                .AppendFormat("Equals: {0}", bitArray.Equals(anotherbitArray))
                .AppendLine()
                .AppendFormat("== {0}", bitArray == anotherbitArray)
                .AppendLine()
                .AppendFormat("!= {0}", bitArray != anotherbitArray);

            Console.WriteLine(sb);
        }
    }
}


