using OutInputSystem.Services;
using OutInputSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutInputSystem
{
    public partial class AddProcurementForm : Form
    {
        public AddProcurementForm()
        {
            InitializeComponent();
        }

        private void AddProcurementForm_Load(object sender, EventArgs e)
        {
            var service = new ProductService();
            var data = service.GetProducts();
            ProductsListBox.DataSource = data.ToList();
            ProductsListBox.DisplayMember = "PartName";
            ProductsListBox.ValueMember = "PartNo";
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            var viewModel = new ProcurementViewModel()
            {
                PartNo = (string)ProductsListBox.SelectedValue,
                PurchasingDay = InputDateTimePicker.Value,
                Quantity = (int)QtyNumericUpDown.Value,
                InvetoryQuantity = (int)QtyNumericUpDown.Value,
                UintPrice = (int)UniPriceNumericUpDown.Value,
            };
            var service = new ProcurementService();
            var result = service.Create(viewModel);
            if(result.IsSuccessful)
            {
                MessageBox.Show("新增資料成功");
            }
            else
            {
                var path = result.WriteLog();
                MessageBox.Show($"發生錯誤，請參考{path}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
