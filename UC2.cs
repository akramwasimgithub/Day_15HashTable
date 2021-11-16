using System;
using System.Collections.Generic;
using System.Text;

namespace Day15HashTable
{
    class UC2
    {
        public void FreqOfParagraph()
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(5);

            Console.WriteLine("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");

            string sentence = "Paranoids are not paranoid because they are paranoid but because" +
            " they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int count = myMapNode.Get(word);
                if (count == 0)
                    count = 1;
                else
                    count++;
                myMapNode.Add(word, count);
            }
            int frequency = myMapNode.Get("paranoid");

            Console.WriteLine("         ");
            Console.WriteLine("Frequency of word paranoid in paragraph = " + frequency);
        }
    }
}
