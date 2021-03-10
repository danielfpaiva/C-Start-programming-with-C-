using System;

namespace ifStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggerNumber = 10;
            int smallerNumber = 0;

            Console.WriteLine("cond 1");
            if (biggerNumber != smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is not equal to " + smallerNumber);
            }

            Console.WriteLine("cond 2");
            if (biggerNumber == smallerNumber)
            {
                Console.WriteLine(biggerNumber + "is equal to" + smallerNumber);
            } else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("cond 3");
            if (biggerNumber > smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is greater than " + smallerNumber);
            } else if (biggerNumber != smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is not equal to " + smallerNumber);
            } else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("cond 4");
            if (biggerNumber > smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is greater than " + smallerNumber);
            }
            
            if (biggerNumber != smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is not equal to " + smallerNumber);
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("cond 5");
            if(biggerNumber <= smallerNumber)
            {
                Console.WriteLine("bigger is smaller");
            } else if (biggerNumber == smallerNumber)
            {
                Console.WriteLine("they are equal");
            } else if (biggerNumber != smallerNumber)
            {
                Console.WriteLine("they are not equal");
            } else if (biggerNumber > smallerNumber)
            {
                Console.WriteLine("bigger is greater");
            }


            Console.WriteLine("cond 6");
            if (biggerNumber <= smallerNumber)
            {
                Console.WriteLine("bigger is smaller");
            }
            if (biggerNumber == smallerNumber)
            {
                Console.WriteLine("they are equal");
            }
            if (biggerNumber != smallerNumber)
            {
                Console.WriteLine("they are not equal");
            }
            if (biggerNumber > smallerNumber)
            {
                Console.WriteLine("bigger is greater");
            }

            Console.WriteLine("cond 7");
            if ((biggerNumber > smallerNumber) && (biggerNumber < smallerNumber))
            {
                Console.WriteLine("first");
            } else if ((biggerNumber > smallerNumber) && (!(biggerNumber < smallerNumber)))
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("else");
            }

            Console.WriteLine("cond 8");
            if ((biggerNumber > smallerNumber) || (biggerNumber < smallerNumber))
            {
                Console.WriteLine("first");
            }
            else if ((biggerNumber > smallerNumber) || (!(biggerNumber < smallerNumber)))
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("else");
            }
        }
    }
}
