using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewPrograms
{
    class PositiveNegative
    {
        public void Numbers()
        {
            int num;

            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Entered number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Entered number is nagative ");
            }
            else
            {
                Console.WriteLine("Entered number is zero ");
            }

           
        }
    }
}

