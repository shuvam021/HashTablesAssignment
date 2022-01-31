using System;
using System.Linq;
using System.Collections.Generic;

namespace HashTablesAssignment
{
    class Program
    {
        public static void CountWordFrequency(string sentence)
        {
            var hashTable = new MyMapNode<string, int>(6);
            string[] words = sentence.Split(' '); // {"to", "be", "or", "not", "to", "be"}
            foreach (string word in words)
            {
                if (hashTable.Exists(word))
                    hashTable.Add(word, hashTable.Get(word) + 1);
                else
                    hashTable.Add(word, 1);
            }
            Console.WriteLine("Dispalying after add operation");
            hashTable.Display();
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            CountWordFrequency("to be or not to be");

            CountWordFrequency("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
        }
    }
}
