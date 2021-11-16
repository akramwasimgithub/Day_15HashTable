using System;
using System.Collections.Generic;
using System.Text;

namespace Day15HashTable
{
    class UC3
    {

            public void Remove()
            {

                MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(5);
                string sentence = "Paranoids are not paranoid because they are paranoid but because" +
                " they keep putting themselves deliberately into paranoid avoidable situations";
                string[] words = sentence.ToLower().Split(" ");
                foreach (string word in words)
                {
                    int count = myMapNode.Get(word);
                    if (count == 0)
                        count = 1;
                    else
                        count ++;
                    myMapNode.Add(word, count);
                }
                
                myMapNode.Remove("avoidable");
            
            }
        
        
    }
}

