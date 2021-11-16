using System;
using System.Collections.Generic;
using System.Text;

namespace Day15HashTable
{
    public class UC1WordFrequency
    {
        public void Frequency()
        {
            Console.WriteLine("To be or not to be");
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(5);
            string sentence = "To be or not to be";
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
            int frequency = myMapNode.Get("be");
            Console.WriteLine("Frequency of be = " + frequency);
        }
    }
}
