using KST.Manager.Implementation;
using KST.Manager.Interfaces;
using KST.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KST
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2 && args[0].ToLower() == "name-sorter" && args[1].ToLower() == "./unsorted-names-list.txt")
            {
                string fileSource = "unsorted-names-list.txt";
                INameManager nameManager = new NameManager();
                nameManager.SortAllNames(fileSource);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("please provide a valid input");
                Console.ReadLine();
            }

        }
    }
}
