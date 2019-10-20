using KST.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KST.Repository.Implementation
{
    public class FileRepository : IFileRepository
    {
        private string _fileSource;
        public FileRepository(string fileSource)
        {
            _fileSource = fileSource;
        }

        public void Add(string[] item)
        {
            File.WriteAllLines("sorted-names-list.txt", item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string[] ReadAll()
        {
            var unsortedNames = File.ReadAllLines(_fileSource);
            return unsortedNames;
        }
    }
}
