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
    internal class ProcurementService
    {
        public OperationResult Create(ProcurementViewModel input)
        {
            var result = new OperationResult();
            try
            {
                var repository = new OutInRepository(new OutInModel());
                Procurement entity = new Procurement
                {
                    PartNo = input.PartNo,
                    PurchasingDay = input.PurchasingDay,
                    Quantity = input.Quantity,
                    InvetoryQuantity = input.InvetoryQuantity,
                    UintPrice = input.UintPrice
                };

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
        public int GetStock(string partNo)
        {
            var repository = new OutInRepository(new OutInModel());
            return repository.GetAll<Procurement>().Where((x) => x.PartNo == partNo)
            .Sum(x => x.InvetoryQuantity);
        }
        public IEnumerable<InvetoryQueryViewModel> GetInventoryList()
        {
            var repository = new OutInRepository(new OutInModel());
            var temp = from p in repository.GetAll<Product>()
                       join q in repository.GetAll<Procurement>()
                       on p.PartNo equals q.PartNo
                       select new
                       {
                           PartNo = p.PartNo,
                           PartName = p.PartName,
                           Quantity = q.InvetoryQuantity
                       };
            return from t in temp
                   group t by new { t.PartNo, t.PartName } into g
                   select new InvetoryQueryViewModel
                   {
                       PartName = g.Key.PartName,
                       PartNo = g.Key.PartNo,
                       TotalInvetoryQuantity = g.Sum((x) => x.Quantity)
                   };
        }


    }
}
