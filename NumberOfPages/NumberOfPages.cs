using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPages
{
    class NumberOfPages
    {
        static void Main()
        {
            string D = Console.ReadLine();
            int number = int.Parse(D);
            int pages;

            for (pages = 1; number != 0 ; pages++)
            {
                number -= pages.ToString().Length;
            }

            Console.WriteLine(--pages);

        }
    }
}
