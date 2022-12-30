using OutInputSystem.Services;
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
    public partial class QuerySellingBySalesForm : Form
    {
        public QuerySellingBySalesForm()
        {
            InitializeComponent();
        }

        private void QuerySellingBySalesForm_Load(object sender, EventArgs e)
        {
            BindSalesManListBox();
        }

        private void BindSalesManListBox()
        {
            var service = new SalesManService();
            var data = service.GetSalesMen();
            SalesListBox.DataSource = data.ToList();
            SalesListBox.DisplayMember = "Name";
            SalesListBox.ValueMember = "JobNumber";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int jobNumber = (int)SalesListBox.SelectedValue;
            var begin = dateTimePicker1.Value.Date;
            var end = dateTimePicker2.Value.Date.AddDays(1);
            var service = new SellingService();
            var data = service.GetSellingBySalesAndDay(jobNumber, begin, end);
            dataGridView1.DataSource = data.ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
