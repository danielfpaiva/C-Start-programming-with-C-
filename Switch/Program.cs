using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int switched = 5;
            int result = 0;

            switch (switched)
            {
                case 1:
                    result = 10;
                    break;
               case 3:
                    result = 30;
                    break;
                case 5:
                    result = 50;
                    break;

                default:
                     result = 100;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
