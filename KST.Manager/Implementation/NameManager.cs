using KST.Common.Implementations;
using KST.Common.Interfaces;
using KST.Manager.Interfaces;
using KST.Model;
using KST.Repository.Implementation;
using KST.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KST.Manager.Implementation
{
    public class NameManager : INameManager
    {
        IFileRepository nameRepository;
        ILogger _logger;

        public NameManager()
        {
            _logger = new ConsoleLogger();
        }

        public void SortAllNames(string sourceFile)
        {
            nameRepository = new FileRepository(sourceFile);
            var allNames = nameRepository.ReadAll();
            SortAllNames(allNames);
        }

        public void SortAllNames(string[] allNames)
        {
            var unsortedNames = GetAllNames(allNames);
            var sortedNames = SortName(unsortedNames);
            nameRepository.Add(sortedNames.ToArray());
        }

        private List<Name> GetAllNames(string[] allNames)
        {
            List<Name> names = new List<Name>();
            foreach (var unsortedName in allNames)
            {
                var splitNames = unsortedName.Split(null).ToList();
                var nameLength = splitNames.Count();
                Name name = new Name();
                name.LastName = splitNames[nameLength - 1];
                splitNames.RemoveAt(nameLength - 1);
                name.FirstName = String.Join(" ", splitNames.ToArray());
                names.Add(name);
            }
            return names;
        }

        private List<string> SortName(List<Name> names)
        {
            var sortedNames = names.OrderBy(a => a.LastName).ThenBy(a => a.FirstName).ToList();
            // generate names
            List<string> newNames = new List<string>();
            foreach (var name in sortedNames)
            {
                var fullName = string.Format("{0} {1}", name.FirstName, name.LastName);
                newNames.Add(fullName);
                _logger.Log(fullName);
            }
            return newNames;
        }
    }
}
