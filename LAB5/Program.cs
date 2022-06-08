using System;
using System.Linq;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            Ex6();
            //Ex7();
        }
        static void Ex1()
        //sa se scrie un prg care va afisa pozitia unui substring intr-un string, ambele siruri citite de la tast.
        {


            Console.WriteLine("Introduceti string1 ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Introduceti string2 ");
            string str2 = Console.ReadLine();
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
            string inputsir = Console.ReadLine();
            string reversesir = string.Empty;
            if (inputsir != null)
            {
                for (int i = inputsir.Length - 1; i >= 0; i--)
                {
                    reversesir += inputsir[i].ToString();
                }
                if (reversesir == inputsir)
                {
                    Console.WriteLine("String este Palindrom Initial= {0} and Final= {1}", inputsir, reversesir);
                }
                else
                {
                    Console.WriteLine("String nu este Palindrom Input = {0} and Output= {1}", inputsir, reversesir);
                }
            }
            Console.ReadLine();
        }
        static void Ex3()
        //scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere, ambele citite de la tast.
        {


            Console.WriteLine("Introduceti sirul:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Introduceti caracterul cautat:");
            char charDeGasit = Convert.ToChar(Console.Read());
            int numar = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == charDeGasit)
                    numar++;
            }

            Console.WriteLine("Caracterul {0} a aparut de {1} ori", charDeGasit, numar);

            Console.ReadLine();
        }
        static void Ex4()
        //Scrieti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura
        {
            char[] vocale = { 'a', 'e', 'i', 'o', 'u' };


            string str1 = Console.ReadLine();

            int i;
            int nrVocale = 0;

            for (i = 0; i < str1.Length; i++)
            {
                //if ( (vocale, str1[i])!=null))
                if (Array.IndexOf(vocale, str1[i]) != -1)
                {
                    nrVocale++;
                }
            }

            Console.WriteLine("Numarul de vocale  este:{0} ", nrVocale);


        }
        static void Ex5()
        //Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
        //de la tastatura, ignorand caseing-ul literelor.

        {
            Console.WriteLine("Introduceti sirul:");
            string sir = Console.ReadLine();
            char[] caractereSir = sir.ToLower().ToArray();

            char caracterMaxim = caractereSir[0];
            int aparitiiCaracterMaxim = 0;

            int aparitiiCaracterCurent;

            for (int i = 0; i < caractereSir.Length; i++)
            {
                aparitiiCaracterCurent = sir.ToLower().Split(caractereSir[i]).Length - 1;

                if (aparitiiCaracterCurent > aparitiiCaracterMaxim)
                {
                    aparitiiCaracterMaxim = aparitiiCaracterCurent;
                    caracterMaxim = caractereSir[i];
                }
            }
            Console.WriteLine(" Caracterul {0} apare de:{1} ori ", caracterMaxim, aparitiiCaracterMaxim);
        }
        static void Ex6()
        //Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din 
        // sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
        {
            Console.WriteLine("Introduceti sirul:");
            string sir = Console.ReadLine();

             
            string[] sir1 = sir.Trim().ToLower().Split(' ');
          
            string sirNou = "";
           
            for (int i = 0; i < sir1.Length; i++)
            {
                sirNou += sir1[i][0].ToString().ToUpper() + sir1[i].Substring(1) + " ";
            }
          
            sirNou = sirNou.Trim();
            Console.WriteLine("sir Nou este {0}", sirNou);

        }
     
    }
}


        
          


         
                










