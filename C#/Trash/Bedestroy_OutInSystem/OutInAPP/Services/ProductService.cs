using OutInAPP.ViewModels;
using OutInDataLibrary.Models;
using OutInDataLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInAPP.Services
{
    public class ProductService
    {
        //public static List<ProductViewModel> fakeProducts 假資料
        //    = new List<ProductViewModel>();
        public OperationResult Create(ProductViewModel input)
        {
            var result = new OperationResult();
            try
            {
                var repository = new OutInRepository(new OutInModel());
                var entity = new Product
                { PartName = input.PartName,PartNo = input.PartNo};
                repository.Create(entity);
                repository.SaveChanges();
                result.IsSuccessful = true;
                //if(fakeProducts.Any(x=>x.PartNo == input.PartNo))
                //{
                //    throw new ArgumentException($"PartNo:{input.PartNo}已存在");
                //}
                //else
                //{
                //    fakeProducts.Add(input);
                //    result.IsSuccessful = true;
                //}
            }
            catch(Exception ex)
            {
                result.IsSuccessful = false;
                result.Exception = ex;
            }
            return result;
        }
    }
}
