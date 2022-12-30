using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutInputSystem.ViewModels
{
    internal class ProcurementViewModel //for AddProcurementForm (新增進貨資料)
    {
        public int ProcurementId { get; set; }
        public string PartNo { get; set; }
        public DateTime PurchasingDay { get; set; }
        public int Quantity { get; set; }
        public int UintPrice { get; set; }
        public int InvetoryQuantity { get; set; } //存貨數量

    }
}
