using OutInDataLibrary.Models;
using OutInDataLibrary.Repositories;
using OutInputSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInputSystem.Services
{
    internal class SalesManService
    {
        public OperationResult Create(SalesManViewModel input)
        {
            var result = new OperationResult();
            try
            {
                var repository = new OutInRepository(new OutInModel());
                var entity = new SalesMan
                { Name=input.Name };
                repository.Create(entity);
                repository.SaveChanges();
                result.IsSuccessful = true;
                //if(fakeProducts.Any(x=>x.PartNo==input.PartNo))
                //{
                //    throw new ArgumentException($"PartNo:{input.PartNo}exists");
                //}
                //else
                //{
                //    fakeProducts.Add(input);
                //    result.IsSuccessful=true;
                //}
            }
            catch (Exception ex)
            {
                result.IsSuccessful = false;
                result.Exception = ex;
            }
            return result;
        }
        public bool IsNameExist(SalesManViewModel input)
        {
            var repository = new OutInRepository(new OutInModel());
            return repository.GetAll<SalesMan>().Any((x) => x.Name == input.Name);
        }
        public IEnumerable<SalesManViewModel> GetSalesMen()
        {
            var repository = new OutInRepository(new OutInModel());
            foreach (var item in repository.GetAll<SalesMan>().OrderBy((x) => x.JobNumber))
            {
                yield return new SalesManViewModel()
                {
                    JobNumber = item.JobNumber,
                    Name = item.Name
                };
            }
        }
    }
}
