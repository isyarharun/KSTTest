using KST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KST.Manager.Interfaces
{
    public interface INameManager
    {
        void SortAllNames(string sourceFile);
        void SortAllNames(string[] allNames);
    }
}
