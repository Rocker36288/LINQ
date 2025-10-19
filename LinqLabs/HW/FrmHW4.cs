using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs.HW
{
    public partial class FrmHW4 : Form
    {
        public FrmHW4()
        {
            InitializeComponent();

            var flies = dir.GetFiles();
            this.dataGridView1.DataSource = flies;
        }
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

        private void btnSize_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = from n in dir.GetFiles()
                    group n by n.Length > 1024 ? "小於1KB" : "大於1KB" into g
                    select new { Size = g.Key, Count = g.Count(), MyGroup = g };

            this.dataGridView2.DataSource = q.ToList();

            foreach (var group in q)
            {
                string header = $"{group.Size},({group.Count})";
                TreeNode pNode = this.treeView1.Nodes.Add(header);
                foreach (var item in group.MyGroup)
                {
                    pNode.Nodes.Add(item.ToString());
                }
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = from n in dir.GetFiles()
                    group n by n.CreationTime.Year >= 2025 ? "2025年" : "2025以前" into g
                    select new { Year = g.Key, Count = g.Count(), MyGroup = g };

            this.dataGridView2.DataSource = q.ToList();

            foreach (var group in q)
            {
                string header = $"{group.Year},({group.Count})";
                TreeNode pNode = this.treeView1.Nodes.Add(header);
                foreach (var item in group.MyGroup)
                {
                    pNode.Nodes.Add(item.ToString());
                }
            }
        }
        NorthwindEntities db = new NorthwindEntities();

        private void btnProductPrice_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = from n in db.Products
                    group n by n.UnitPrice < 30 ? "<30元" : n.UnitPrice < 60 ? "30~59元" : "60元以上" into g
                    select new { Price = g.Key, Count = g.Count(), MyGroup = g };

            this.dataGridView1.DataSource = db.Products.ToList();
            this.dataGridView2.DataSource = q.ToList();

            foreach (var group in q)
            {
                string header = $"{group.Price},({group.Count})";
                TreeNode pNode = this.treeView1.Nodes.Add(header);
                foreach (var item in group.MyGroup)
                {
                    pNode.Nodes.Add(item.ProductName);
                }
            }
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].LegendText = "Price";
            this.chart1.Series[0].XValueMember = "Price";
            this.chart1.Series[0].YValueMembers = "Count";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private void btnGroupByYear_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = from n in db.Orders
                    group n by n.OrderDate.Value.Year into g
                    select new { Year = g.Key, Count = g.Count(), MyGroup = g };

            this.dataGridView1.DataSource = db.Orders.ToList();
            this.dataGridView2.DataSource = q.Select(n => new { n.Year, n.Count }).ToList();

            foreach (var group in q)
            {
                string header = $"{group.Year},({group.Count})";
                TreeNode node = this.treeView1.Nodes.Add(header);
            }

            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].LegendText = "Year";
            this.chart1.Series[0].XValueMember = "Year";
            this.chart1.Series[0].YValueMembers = "Count";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnGroupByYearMonth_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = from n in db.Orders.ToList()
                    group n by n.OrderDate.Value.ToString("yyyy/MM") into g
                    select new { YearMonth = g.Key, Count = g.Count(), MyGroup = g };

            this.dataGridView1.DataSource = db.Orders.ToList();
            this.dataGridView2.DataSource = q.Select(n => new { n.YearMonth, n.Count }).ToList();

            foreach (var group in q)
            {
                string header = $"{group.YearMonth},({group.Count})";
                TreeNode node = this.treeView1.Nodes.Add(header);
            }

            this.chart1.DataSource = q.Select(n => new { n.YearMonth, n.Count }).ToList();
            this.chart1.Series[0].LegendText = "YearMonth";
            this.chart1.Series[0].XValueMember = "YearMonth";
            this.chart1.Series[0].YValueMembers = "Count";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = from n in db.Orders.ToList()
                    group n by n.OrderDate.Value.ToString("yyyy/MM") into g
                    select new
                    {
                        YearMonth = g.Key,
                        Count = g.Count(),
                        MyGroup = g,
                        TotalPrice = $"{g.Sum(n => n.Order_Details.Sum(o => o.UnitPrice * o.Quantity)):C2}"
                    };

            this.dataGridView1.DataSource = db.Orders.ToList();
            this.dataGridView2.DataSource = q.Select(n => new { n.YearMonth, n.Count, n.TotalPrice }).ToList();

            foreach (var group in q)
            {
                string header = $"{group.YearMonth},(數量:{group.Count}),({group.TotalPrice})";
                TreeNode node = this.treeView1.Nodes.Add(header);
            }

            this.chart1.DataSource = q.Select(n => new { n.YearMonth, n.TotalPrice }).ToList();
            this.chart1.Series[0].LegendText = "YearMonth";
            this.chart1.Series[0].XValueMember = "YearMonth";
            this.chart1.Series[0].YValueMembers = "TotalPrice";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnTop5Sales_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = db.Orders.ToList()
                             .GroupBy(n => n.EmployeeID)
                             .Select(n => new
                             {
                                 EmployeeID = n.Key,
                                 TotalPrice = n.Sum(n1 => n1.Order_Details.Sum(n2 => n2.UnitPrice * n2.Quantity))
                             })
                             .OrderByDescending(n => n.TotalPrice)
                             .Take(5)
                             .Select(n => new
                             {
                                 n.EmployeeID,
                                 TotalPrice = $"{n.TotalPrice:C2}"
                             });

            this.dataGridView1.DataSource = db.Orders.ToList();
            this.dataGridView2.DataSource = q.Select(n => new { n.EmployeeID, n.TotalPrice }).ToList();

            foreach (var group in q)
            {
                string header = $"{group.EmployeeID},({group.TotalPrice})";
                TreeNode node = this.treeView1.Nodes.Add(header);
            }

            this.chart1.DataSource = q.Select(n => new { n.EmployeeID, n.TotalPrice }).ToList();
            this.chart1.Series[0].LegendText = "EmployeeID";
            this.chart1.Series[0].XValueMember = "EmployeeID";
            this.chart1.Series[0].YValueMembers = "TotalPrice";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btnTop5Price_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            var q = db.Products.ToList()
                               .OrderByDescending(n => n.UnitPrice)
                               .Take(5)
                               .Select(n =>new
                               {
                                   n.ProductName,
                                   Price =$"{n.UnitPrice:C2}"                                   
                               });
            this.dataGridView1.DataSource = db.Products.ToList();
            this.dataGridView2.DataSource = q.ToList();

            foreach (var group in q)
            {
                string header = $"{group.ProductName},({group.Price})";
                TreeNode node = this.treeView1.Nodes.Add(header);
            }

            this.chart1.DataSource = q.Select(n => new { n.ProductName, n.Price }).ToList();
            this.chart1.Series[0].LegendText = "ProductName";
            this.chart1.Series[0].XValueMember = "ProductName";
            this.chart1.Series[0].YValueMembers = "Price";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
    }
}
