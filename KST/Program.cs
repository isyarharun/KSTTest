using KST.Common.Implementations;
using KST.Common.Interfaces;
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
            ILogger _logger = new ConsoleLogger();
            try
            {
                if (args.Length == 2 && args[0].ToLower() == "name-sorter" && args[1].ToLower() == "./unsorted-names-list.txt")
                {
                    string fileSource = Path.GetFileName(args[1]);
                    var test = File.Exists(fileSource);
                    INameManager nameManager = new NameManager();
                    nameManager.SortAllNames(fileSource);
                }
                else
                {
                    Console.WriteLine("please provide a valid input");
                }
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
