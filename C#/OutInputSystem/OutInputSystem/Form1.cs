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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            //var form = new AddProductForm();
            //form.ShowDialog();
            ShowSubFrom(new AddProductForm());
        }

        private void AddSalesManButton_Click(object sender, EventArgs e)
        {
            ShowSubFrom(new AddSalesManForm());
        }

        private void AddProcurementFormbutton_Click(object sender, EventArgs e)
        {
            ShowSubFrom(new AddProcurementForm());
        }
        private void addSellingButton_Click(object sender, EventArgs e)
        {
            ShowSubFrom(new AddSellingForm());
        }
        private void searchSalesSellabutton_Click(object sender, EventArgs e)
        {
            ShowSubFrom(new QuerySellingBySalesForm());
        }
        private void searchStuckButton_Click(object sender, EventArgs e)
        {
            ShowSubFrom(new QueryStockForm());
        }
        private static void ShowSubFrom(Form form)
        {
            form.ShowDialog();
        }

    }
}
