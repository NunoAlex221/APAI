using System;
using System.Collections.Generic;
using System.IO;

namespace Tarefa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath("lyrics.txt");
            string lyrics = File.ReadAllText(path);
            

            string[] palavras = lyrics.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> PalavrasRepetidas = new Dictionary<string, int>();
            for (int i = 0; i < palavras.Length; i++)
            {
                if (PalavrasRepetidas.ContainsKey(palavras[i]))
                {
                    int value = PalavrasRepetidas[palavras[i]];
                    PalavrasRepetidas[palavras[i]] += 1;
                }
                else
                {
                    PalavrasRepetidas.Add(palavras[i], 1);   
                }
            }
            foreach (KeyValuePair<string, int> kvp in PalavrasRepetidas)
            {
                Console.WriteLine($"{kvp.Key} repete {kvp.Value} vezes");
            }
        }
    }
    
}
