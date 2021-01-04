using System;
using System.Collections.Generic;

namespace StackZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //elementi se u stack dodaju i brisu samo sa vrha pomocu funkcija push/pop
            Stack<string> kutijaKnjiga = new Stack<string>();
            kutijaKnjiga.Push("Harry Potter");
            kutijaKnjiga.Push("Lord of the Rings");
            kutijaKnjiga.Push("Hunger Games");

            foreach (var item in kutijaKnjiga)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("=================================");
            Console.WriteLine("     Vadjenje elementa");
            Console.WriteLine("=================================");
            Console.WriteLine("Izvadjen element: " + kutijaKnjiga.Pop());
            Console.WriteLine();
            foreach (var item in kutijaKnjiga)
            {
                Console.WriteLine(item);
            }
        }
    }
}