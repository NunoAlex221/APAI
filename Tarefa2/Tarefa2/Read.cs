using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tarefa2
{
    public class Readtxt
    {
        public static void Read(string file)
        {
            Invetory invetory = new Invetory();
            XElement content = XElement.Load(file);

            foreach(var item in content.Elements())
            {
                invetory.AddToList(new InventoryItem(item.Element("name").Value,
                    Int32.Parse(item.Element("weight").Value),
                    Int32.Parse(item.Element("quantity").Value)));

                Console.WriteLine(invetory.ToString());
            }
        }
    }
}
