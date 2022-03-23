using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dataSet11.Customers;
            sqlDataAdapter1.Fill(dataSet11.Customers);

            BindingSource customersBindingSource = new BindingSource(dataSet11, "Customers");
            dataGridView1.DataSource = customersBindingSource;
            bindingNavigator1.BindingSource = customersBindingSource;
        }

        private void save_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet11);
        }
    }
}
