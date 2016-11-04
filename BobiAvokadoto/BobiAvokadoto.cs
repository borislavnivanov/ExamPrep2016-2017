using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobiAvokadoto
{
    class BobiAvokadoto
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            uint combNumber = uint.Parse(Console.ReadLine());
            uint[] combinations = new uint[combNumber];
            uint result;
            uint bestresult = 0;

            for (int i = 0; i < combNumber; i++)
            {
                combinations[i] = uint.Parse(Console.ReadLine());       
            }

            for (int i = 0; i < combinations.Length; i++)
            {
                result = combinations[i] & head;
                bestresult = Math.Max(bestresult, result);
            }
            Console.WriteLine(bestresult);

        }
    }
}
