using System;

namespace Tarefa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word1: ");
            string word1 = Console.ReadLine();

            Console.WriteLine("Word2: ");
            string word2 = Console.ReadLine();

            Console.WriteLine($"Anagram true or false? {Anagram.IsAnagram(word1, word2)}");
        }
    }
}
