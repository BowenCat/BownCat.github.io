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
    public partial class QueryStockForm : Form
    {
        public QueryStockForm()
        {
            InitializeComponent();
        }

        private void QueryStockForm_Load(object sender, EventArgs e)
        {
            var service = new ProcurementService();
            dataGridView1.DataSource = service.GetInventoryList().ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
