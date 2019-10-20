using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KST.Repository.Interfaces
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        void Add(T item);
        T ReadAll();
    }
}
