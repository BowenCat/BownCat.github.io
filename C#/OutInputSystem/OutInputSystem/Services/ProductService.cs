
using BuildSchoolBizApp.ViewModels;
using OutInDataLibrary.Models;
using OutInDataLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.Services
{
    internal class ProductService
    {
        //public static List<ProductViewModel> fakeProducts=new List<ProductViewModel>();假資料
        public OperationResult Create(ProductViewModel input)
        {
            var result=new OperationResult();
            try
            {
                var repository = new OutInRepository(new OutInModel());
                var entity = new Product
                { PartNo=input.PartNo,PartName=input.PartName};
                repository.Create(entity);
                repository.SaveChanges();
                result.IsSuccessful=true;
                //if(fakeProducts.Any(x=>x.PartNo==input.PartNo)) 假資料
                //{
                //    throw new ArgumentException($"PartNo:{input.PartNo}exists");
                //}
                //else
                //{
                //    fakeProducts.Add(input);
                //    result.IsSuccessful=true;
                //}
            }
            catch(Exception ex)
            {
                result.IsSuccessful=false;
                result.Exception=ex;
            }
            return result;
        }
        public IEnumerable<ProductViewModel> GetProducts()
        {
            var repository = new OutInRepository(new OutInModel());
            foreach (var item in repository.GetAll<Product>().OrderBy((x) => x.PartNo))
            {
                yield return new ProductViewModel()
                {
                    PartNo = item.PartNo,
                    PartName = item.PartName
                };
            }
        }
    }
}
