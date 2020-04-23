using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tarefa3
{
    public class Write
    {
        private static string[] Invert(string[] lines)
        {
            int index = lines.Length - 1;
            string[] linesI = new string[lines.Length];

            for(int i = 0; i < lines.Length; i++)
            {
                linesI[i] = lines[index--];
            }
            return linesI;
        }

        public static void Write_(string[]lines)
        {
            File.WriteAllLines("lines_inverted.txt", Invert(lines));
        }
    }
}
