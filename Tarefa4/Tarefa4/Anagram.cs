using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Tarefa4
{
    public class Anagram
    {
       public static bool IsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            var word1_ = word1.ToLower().ToCharArray();
            var word2_ = word2.ToLower().ToCharArray();

            Array.Sort(word1_);
            Array.Sort(word2_);

            word1 = new string(word1_);
            word2 = new string(word2_);

            return word1 == word2;
        }
    }
}
