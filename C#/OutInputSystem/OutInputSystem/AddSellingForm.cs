using OutInputSystem.Services;
using OutInputSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutInputSystem
{
    public partial class AddSellingForm : Form
    {
        public AddSellingForm()
        {
            InitializeComponent();
        }

        private void AddSellingForm_Load(object sender, EventArgs e)
        {
            BindProductListBox();
            BindSalesManListBox();
        }

        private void BindSalesManListBox()
        {
            var service = new SalesManService();
            var data = service.GetSalesMen();
            SalesManListBox.DataSource = data.ToList();
            SalesManListBox.DisplayMember = "Name";
            SalesManListBox.ValueMember = "JobNumber";
        }

        private void BindProductListBox()
        {
            var service = new ProductService();
            var data = service.GetProducts();
            ProductsListBox.DataSource = data.ToList();
            ProductsListBox.DisplayMember = "PartName";
            ProductsListBox.ValueMember = "PartNo";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var partNo = (string)ProductsListBox.SelectedValue;
            var quantity = (int)outPutNumericUpDown.Value;
            if (!CanSell(partNo, quantity))
            {
                MessageBox.Show("庫存不足");
                return;
            }
            var viewModel = new SellingViewModel
            {
                PartNo = partNo,
                SalesJobNumber = (int)SalesManListBox.SelectedValue,
                Quantity = quantity,
                UnitPrice = (int)uniPriceNumericUpDown.Value,
                SellingDay = outPutDateTimePicker.Value,
            };
            var service = new SellingService();
            var result = service.Create(viewModel);
            if (result.IsSuccessful)
            {
                MessageBox.Show("新增出貨資料成功");
            }
            else
            {
                var path = result.WriteLog();
                MessageBox.Show($"發生錯誤，請參考 {path}");
            }

        }
        private static bool CanSell(string partNo, int quantity)
        {
            var service = new ProcurementService();
            Debug.WriteLine(service.GetStock(partNo));
            return (service.GetStock(partNo) >= quantity);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
