using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern;

public interface IGenericRepository<T> where T : class
{
    Task<T>? FindAsync(Guid? id);

    void Create(T entity);
}