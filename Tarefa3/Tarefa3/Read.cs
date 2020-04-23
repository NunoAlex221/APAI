using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarefa3
{
    public class Read
    {
        public static string[] ReadI(string file)
        {
            return File.ReadAllLines(file);
        }
    }
}
