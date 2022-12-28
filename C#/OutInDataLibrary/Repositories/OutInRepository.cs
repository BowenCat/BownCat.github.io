using OutInDataLibrary.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace OutInDataLibrary.Repositories
{
    public  class OutInRepository
    {
        private DbContext _context;
        public OutInRepository(DbContext context)
        {
            _context = context;
        }
        public void Create<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Added;
        }
        public void Update<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Modified;
        }
        public void Delete<T>(T value) where T : class
        {
            _context.Entry(value).State = EntityState.Deleted;
        }
        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }
        //public IQueryable<T> GetAll<T, TKey>(Expression<Func<T, TKey>> keySelector) where T : class
        //{
        //    return _context.Set<T>().OrderBy(keySelector);
        //}

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}