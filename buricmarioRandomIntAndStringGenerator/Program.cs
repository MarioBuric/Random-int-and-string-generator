using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmarioRandomIntAndStringGenerator
{
    class Program
    {
        static Random random = new Random();

        public static void Run()
        {
            Console.WriteLine("0068 - RandomNumbers");
            Console.WriteLine();


            Console.WriteLine("Random number: {0}", GetRandomNumber());
            Console.WriteLine("Random number between [10, 8000]: {0}",
                GetRandomNumberBetween(10, 8001));
            Console.WriteLine();
            Console.WriteLine("Random 100 bytes: {0}", string.Join(", ", GetRandomBytes(100)));
            Console.WriteLine();
            Console.WriteLine("Random string: {0}", GetRandomString(20));

            Console.ReadKey();
        }

        static int GetRandomNumber()
        {
            return random.Next();
        }

        static int GetRandomNumberBetween(int min, int max)
        {
            return random.Next(min, max);
        }

        static byte[] GetRandomBytes(int howMany)
        {
            byte[] result = new byte[howMany];

            random.NextBytes(result);

            return result;
        }

        static string GetRandomString(int length)
        {
            StringBuilder sb = new StringBuilder(length); // capacity

            string myAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789$#&%!@";

            for (int i = 0; i < sb.Capacity; i++)
            {
                int index = random.Next(0, myAlphabet.Length);
                sb.Append(myAlphabet[index]);
            }

            return sb.ToString();
        }
    }
}

