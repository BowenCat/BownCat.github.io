using OutInDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInDataLibrary.Repositories
{
    public class SalesManRepository//OutInRepository //<SalesMan>
    {
        
        //public SalesManRepository(OutInModel context)//:base(context)
        //{
        //    if (context == null) { throw new ArgumentNullException(); }
        //    _context = context;

        //}

        //public void Create(SalesMan value)
        //{
        //    _context.Entry(value).State = EntityState.Added;
        //}
        //public void Update(SalesMan value)
        //{
        //    _context.Entry(value).State = EntityState.Modified;
        //}
        //public void Delete(SalesMan value)
        //{
        //    _context.Entry(value).State = EntityState.Deleted;
        //}
        //public SalesMan Get(int jobNumber)
        //{
        //    return _context.SalesMan.FirstOrDefault((x) => x.JobNumber == jobNumber);
        //}
        //public IQueryable<SalesMan> GetAll()
        //{
        //    return _context.SalesMan.OrderBy((x) => x.JobNumber);
        //}
        //public void SaveChanges()
        //{
        //    _context.SaveChanges();
        //}

    }
}
