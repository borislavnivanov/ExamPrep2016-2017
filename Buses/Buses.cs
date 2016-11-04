using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Buses
    {
        static void Main()
        {
            int busses = int.Parse(Console.ReadLine());
            int[] speeds = new int[busses];
            for (int i = 0; i < busses; i++)
            {
                speeds[i] = int.Parse(Console.ReadLine());
            }

            int groups = 1;
            int checkPosition = 0;

            for (int i = 1; i < speeds.Length; i++)
            {
                if (speeds[i] <= speeds[checkPosition])
                {
                    groups++;
                    checkPosition = i;
                }
            }
            Console.WriteLine(groups);
        }
    }
}
