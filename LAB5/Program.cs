using System;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
        }
        static void Ex1()
        //sa se scrie un prg care va afisa pozitia unui substring intr-un string, ambele siruri citite de la tast.
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
                Console.WriteLine("Found '{0}' in '{1}' at position {2}", str2, str1, index);

        }
        static void Ex2()
        //scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom
        {
            
           
            Console.Write("Introduceti un string : ");
            string inputstr = Console.ReadLine();
            string reversestr = string.Empty;
            if (inputstr != null)
            {
                for (int i = inputstr.Length - 1; i >= 0; i--)
                {
                    reversestr += inputstr[i].ToString();
                }
                if (reversestr == inputstr)
                {
                    Console.WriteLine("String este Palindrom Initial= {0} and Final= {1}", inputstr, reversestr);
                }
                else
                {
                    Console.WriteLine("String nu este Palindrom Input = {0} and Output= {1}", inputstr, reversestr);
                }
            }
            Console.ReadLine();
        }
    }

}


