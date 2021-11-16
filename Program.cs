using System;

namespace Day15HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            {

                Console.WriteLine("=====UC1===== ");
                UC1WordFrequency freq = new UC1WordFrequency();
                freq.Frequency();

                Console.WriteLine("\n ====== UC2====== ");
                UC2 freq1 = new UC2();
                freq1.FreqOfParagraph();


                Console.WriteLine("\n =====UC3===== ");
                UC3 remove = new UC3();
                remove.Remove();

            }
        }
    }
}
