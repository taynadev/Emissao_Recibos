using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aliare.DataBase.Repositories
{
    public class GenericRepository<T> where T : class
    {
        protected readonly FinanceiroContext context;
        protected readonly DbSet<T> DbSet;

        public GenericRepository()
        {
            this.context = new FinanceiroContext();
            DbSet = this.context.Set<T>();
        }

        public void Add(T obj)
        {
            DbSet.Add(obj);
        }

        public void Update(T obj)
        {
            DbSet.Update(obj);
        }

        public void Remove(T obj)
        {
            DbSet.Remove(obj);
        }

        public void RemoveWhere(Expression<Func<T, bool>> Filter)
        {
            DbSet.RemoveRange(DbSet.Where(Filter).ToList());
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IList<T> Get(Expression<Func<T, bool>> Filter)
        {
            return DbSet.Where(Filter).ToList();
        }

        public IList<T> GetAll()
        {
            return DbSet.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
