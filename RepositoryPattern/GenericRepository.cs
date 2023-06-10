using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DbContext _context;

    public GenericRepository(DbContext context)
    {
        _context = context;
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public async Task<T>? FindAsync(Guid? id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}