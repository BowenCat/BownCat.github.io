using BizDataLibrary.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace BizDataLibrary.Repositories
{                               //泛型類別的條件 1.實作泛型介面或是繼承泛型類別
                                //              2.該泛型型別會使用在欄位、屬性或索引子其中之一  
    public  class BizRepository  //泛型皆用在方法上，所以未具備泛型類別條件
    {
        public BizRepository(DbContext context)
        {
            if (context == null)
            { throw new ArgumentNullException(); }
            _context = context;
        }
        private DbContext _context;
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
       
        public IQueryable<T> GetAll<T>()where T : class
        {
            return _context.Set<T>();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}