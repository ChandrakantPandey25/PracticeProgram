using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewPrograms
{
    class LargestOfThree
    {
        public void Largest()
        {
            int numOne, numTwo, numThree;
            Console.WriteLine("Enter three numbers: ");

            numOne = Convert.ToInt32(Console.ReadLine());
            numTwo = Convert.ToInt32(Console.ReadLine());
            numThree = Convert.ToInt32(Console.ReadLine());

            if (numOne >= numTwo)
            {
                if (numOne >= numThree)
                    Console.WriteLine(numOne + " is the largest number");
                else
                    Console.WriteLine(numThree + " is the largest number");
            }

            else if (numTwo >= numThree)
                Console.WriteLine(numTwo + " is the largest number");

            else
                Console.WriteLine(numThree + " is the largest number");         


        }
    }
}
