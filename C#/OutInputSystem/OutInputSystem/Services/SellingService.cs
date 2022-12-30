using OutInDataLibrary.Models;
using OutInDataLibrary.Repositories;
using OutInputSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInputSystem.Services
{
    internal class SellingService
    {
        private Selling CreateSelling(OutInRepository repository, SellingViewModel input)
        {   //哪位出貨
            Selling entity = new Selling()
            {
                PartNo = input.PartNo,
                Quantity = input.Quantity,
                SalesJobNumber = input.SalesJobNumber,
                SellingDay = input.SellingDay,
                UnitPrice = input.UnitPrice
            };
            repository.Create(entity);
            // 要先 SaveChanges 才能拿到新的 Selling.SellingId
            repository.SaveChanges();
            return entity;
        }       
        
        private void CreateSellingSource(OutInRepository repository, int sellingId,int procurementId, int sellCount)
        {   //新增出貨紀錄(從哪次進貨做出貨)
            SellingSource sellingSource = new SellingSource()
            {
                ProcurementId = procurementId,
                SellingId = sellingId,
                Quantity = sellCount
            };
            repository.Create(sellingSource);
        }
        private void ComputeInvetory(OutInRepository repository, SellingViewModel input)
        {   //按先進先出扣除庫存
            Selling entity = CreateSelling(repository, input);
            var sellCount = input.Quantity;
            var products = repository.GetAll<Procurement>()
            .Where((x) => x.PartNo == input.PartNo && x.InvetoryQuantity > 0)
            .OrderBy((x) => x.PurchasingDay);
            foreach (var p in products)
            {
                if (sellCount <= 0)
                {
                    break;
                }
                else
                {
                    //throw new Exception("test");
                    if (p.InvetoryQuantity >= sellCount)
                    {
                        p.InvetoryQuantity = p.InvetoryQuantity - sellCount;
                        CreateSellingSource(repository, entity.SellingId, p.ProcurementId, sellCount);
                        sellCount = 0;
                    }
                    else
                    {
                        sellCount = sellCount - p.InvetoryQuantity;
                        CreateSellingSource(repository, entity.SellingId, p.ProcurementId, p.InvetoryQuantity);
                        p.InvetoryQuantity = 0;
                    }
                }
            }
        }
        public OperationResult Create(SellingViewModel input)
        {
            var result = new OperationResult();
            DbContext context = new OutInModel();
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var repository = new OutInRepository(context);
                    ComputeInvetory(repository, input);
                    repository.SaveChanges();
                    result.IsSuccessful = true;
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessful = false;
                    result.Exception = ex;
                    transaction.Rollback();
                }
            }
            return result;
        }
        public IEnumerable<SellingQueryViewModel> GetSellingBySalesAndDay(int jobNumber, DateTime begin, DateTime end)
        {
            var repository = new OutInRepository(new OutInModel());
            return from selling in repository.GetAll<Selling>()
                   join sales in repository.GetAll<SalesMan>()
                   on selling.SalesJobNumber equals sales.JobNumber
                   where selling.SalesJobNumber == jobNumber
                   && selling.SellingDay >= begin
                   && selling.SellingDay < end
                   select new SellingQueryViewModel
                   {
                       PartNo = selling.PartNo,
                       Quantity = selling.Quantity,
                       SalesJobNumber = selling.SalesJobNumber,
                       SalesName = sales.Name,
                       SellingDay = selling.SellingDay,
                       SellingId = selling.SellingId,
                       UnitPrice = selling.UnitPrice,
                       TotalPrice = selling.UnitPrice * selling.Quantity
                   };
        }
    }
}
