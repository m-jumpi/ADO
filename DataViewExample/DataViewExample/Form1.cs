using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        DataView customerDataView;
        DataView orderDataView;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            customerDataView = new DataView(northwindDataSet1.Customers);
            orderDataView = new DataView(northwindDataSet1.Orders);
            customerDataView.Sort = "CustomerID";
            CustomersGrid.DataSource = customerDataView;

        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customerDataView.Sort = SortTextBox.Text;
            customerDataView.RowFilter = FilterTextBox.Text;

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customerDataView.AddNew();
            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toy";
            newCustomRow.EndEdit();
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            string selectedCustomerID = CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value.ToString();
            DataRowView selectedRow = customerDataView[customerDataView.Find(selectedCustomerID)];
            orderDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            OrdersGrid.DataSource = orderDataView;
        }
    }
}
