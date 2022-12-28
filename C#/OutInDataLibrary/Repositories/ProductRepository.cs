using OutInDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInDataLibrary.Repositories
{
    
    //internal class ProductRepository : OutInRepository
    //{
    //    public ProductRepository(OutInModel context):base(context)
    //    {
            
    //    }
        
    //    public Product Get(string partNo)
    //    {
    //        return _context.Product.FirstOrDefault(x=>x.PartNo == partNo);
    //    }
        //public override IQueryable<Product> GetAll()
        //{
        //    return _context.Product.OrderBy(x => x.PartNo);
        //}
        //public IQueryable<Selling> GetAll<TKey>(Expression<Func<Selling, TKey>> keySelector)
        //{
        //    return Context.Set<Selling>().OrderBy(keySelector);
        //}
}

