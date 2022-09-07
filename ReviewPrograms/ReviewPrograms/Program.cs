using System;

namespace ReviewPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Programs");
            Console.WriteLine("Enter 1 to check Vowel or consonant");
            Console.WriteLine("Enter 2 to check positive negative or zero");
            Console.WriteLine("Enter 3 to check largest of three numbers");
            Console.WriteLine("Enter 4 to check largest of three numbers using nested if");
            Console.WriteLine("Enter 5 to print alphabets from a to z");
           
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        VowelOrNot check = new VowelOrNot();
                        check.Vowels();
                        break;
                    case 2:
                        PositiveNegative result = new PositiveNegative();
                        result.Numbers();
                        break;
                    case 3:
                        LargestOfThree resultOne = new LargestOfThree();
                        resultOne.Largest();
                        break;
                    case 4:
                        LargestNumberUsingNestedIf resultTwo = new LargestNumberUsingNestedIf();
                        resultTwo.Largest();
                        break;
                    case 5:
                        PrintAlphabets resultThree = new PrintAlphabets();
                        resultThree.Alphabets();
                        break;

                    default:
                        Console.WriteLine("Enter valid number");
                        break;
                }
            }

        }
    }
}
