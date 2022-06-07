using System;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            
            Console.WriteLine("Introduceti string1 ");
            str1 = Console.ReadLine();

            Console.WriteLine("Introduceti string2 ");
            str2 = Console.ReadLine();
            int index = str1.IndexOf(str2);
            if (index < 0)
                Console.WriteLine("Nu exista string2 ");
            else
                Console.WriteLine("Found '{0}' in '{1}' at position {2}", str2, str1, index+1);

        }

        }
    }



