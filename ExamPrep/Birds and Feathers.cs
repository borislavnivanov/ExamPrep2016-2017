using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BirdsAndFeathers
{
    class BirdsAndFeathers
    {
        static void Main()
        {
            double birds = double.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());
            double result = 0;

            bool birdsEven = true;
            if (birds % 2 == 0)
            {
                birdsEven = true;
            }
            else
            {
                birdsEven = false;
            }

            double featherAverage = feathers / birds;

            if (birdsEven == true)
            {
                result = featherAverage * 123123123123;
            }
            else
            {
                result = featherAverage / 317;
            }

            Console.WriteLine("{0:0.0000}", result);

        }
    }
}
