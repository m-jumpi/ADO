﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDataSetXml
{
    public partial class Form1 : Form
    {
        DataSet NorthwinDataSet = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSchemaButton_Click(object sender, EventArgs e)
        {
            NorthwinDataSet.ReadXmlSchema("Northwind.xsd");
            CustomersGrid.DataSource = NorthwinDataSet.Tables["Customers"];
            OrdersGrid.DataSource = NorthwinDataSet.Tables["Orders"];
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            NorthwinDataSet.ReadXml("Northwind.xml");
        }
    }
}
