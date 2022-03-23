using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace LINQsqlSproc
{
    public partial class Form1 : Form
    {
        //Northwind db = new Northwind(@"C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\northwnd.mdf");
        private static SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Northwind;Integrated Security=True");
        Northwind db = new Northwind(conn);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string param = textBox1.Text;
            var custquery=db.CustOrdersDetail(Convert.ToInt32(param));
            string msg = "";
            foreach (CustOrdersDetailResult custOrdersDetail in custquery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "")
            {
                msg = "No result.";
            }
            MessageBox.Show(msg);
            param = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string param = textBox2.Text;
            var custquery = db.CustOrderHist(param);
            string msg = "";
            foreach (CustOrderHistResult custOrderHist in custquery)
            {
                msg = msg + custOrderHist.ProductName + "\n";
            }
            if (msg == "")
            {
                msg = "No result.";
            }
            MessageBox.Show(msg);
            param = "";
            textBox1.Text = "";
        }
    }
}
