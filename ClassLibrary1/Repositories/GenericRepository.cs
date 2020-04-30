using ClassLibrary1.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ClassLibrary1.Entities;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private ApplicationContext context = null;
        private DbSet<T> table = null;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public async void Delete(int id)
        {
            var entity = table.SingleOrDefault(s => s.Id == id);
            table.Remove(entity);
            await context.SaveChangesAsync();
        }
        public IEnumerable<T> GetAll()
        {
            return this.context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await table.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async void Insert(T obj)
        {
            await table.AddAsync(obj);
            await context.SaveChangesAsync();
        }

        public async void Update(T obj)
        {
            var entity = table.SingleOrDefault(s => s.Id == obj.Id);
            table.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
