using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.WebRequestMethods;

namespace Starter
{
    public partial class FrmLINQ_To_XXX : Form
    {
        public FrmLINQ_To_XXX()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable<IGrouping<string, int>> q = from n in nums
            //group n by (n % 2 == 0) ? "偶數" : "奇數";

            IEnumerable<IGrouping<string, int>> q = nums.GroupBy(n => (n % 2 == 0) ? "偶數" : "奇數");


            this.dataGridView1.DataSource = q.ToList();
            //========================
            //TreeView
            foreach (var group in q)
            {
                TreeNode parentnode = this.treeView1.Nodes.Add(group.Key);
                foreach (var item in group)
                {
                    parentnode.Nodes.Add(item.ToString());
                }
            }
            //========================
            //ListView
            foreach (var group in q)
            {
                ListViewGroup lvg = this.listView1.Groups.Add(group.Key, group.Key);
                foreach (var item in group)
                {
                    this.listView1.Items.Add(item.ToString()).Group = lvg;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //split-Apply Aggregation
            var q = from n in nums
                    group n by (n % 2 == 0) ? "偶數" : "奇數" into g
                    select new
                    {
                        Mykey = g.Key,
                        MyCount = g.Count(),
                        MyMax = g.Max(),
                        MyGroup = g
                    };

            this.dataGridView1.DataSource = q.ToList();

            //========================
            //TreeView
            foreach (var group in q)
            {
                string header = $"{group.Mykey} ({group.MyCount})";

                TreeNode parentnode = this.treeView1.Nodes.Add(header);
                foreach (var item in group.MyGroup)
                {
                    parentnode.Nodes.Add(item.ToString());
                }
            }
            //========================
            //ListView
            foreach (var group in q)
            {
                string header = $"{group.Mykey} ({group.MyCount})";

                ListViewGroup lvg = this.listView1.Groups.Add(group.Mykey, header);
                foreach (var item in group.MyGroup)
                {
                    this.listView1.Items.Add(item.ToString()).Group = lvg;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //split-Apply Aggregation
            var q = from n in nums
                    group n by MyKey(n) into g
                    select new
                    {
                        Mykey = g.Key,
                        MyCount = g.Count(),
                        MyMax = g.Max(),
                        MyAvg = g.Average(),
                        MyGroup = g
                    };

            this.dataGridView1.DataSource = q.ToList();

            //========================
            //TreeView
            foreach (var group in q)
            {
                string header = $"{group.Mykey} ({group.MyCount})";

                TreeNode parentnode = this.treeView1.Nodes.Add(header);
                foreach (var item in group.MyGroup)
                {
                    parentnode.Nodes.Add(item.ToString());
                }
            }
            //========================
            //ListView
            foreach (var group in q)
            {
                string header = $"{group.Mykey} ({group.MyCount})";

                ListViewGroup lvg = this.listView1.Groups.Add(group.Mykey, header);
                foreach (var item in group.MyGroup)
                {
                    this.listView1.Items.Add(item.ToString()).Group = lvg;
                }
            }

            //Chart
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "MyKey";
            this.chart1.Series[0].YValueMembers = "MyCount";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart1.Series[1].XValueMember = "MyKey";
            this.chart1.Series[1].YValueMembers = "MyAvg";
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }
        string MyKey(int n)
        {
            return n < 4 ? "小" :
                   n < 7 ? "中" : "大";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            var files = dir.GetFiles();
            this.dataGridView1.DataSource = files;

            var q = from n in files
                    group n by n.Extension into g
                    select new
                    {
                        MyKey = g.Key,
                        MyCount = g.Count(),
                    };

            this.dataGridView2.DataSource = q.ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ordersTableAdapter1.Fill(nwDataSet1.Orders);
            this.dataGridView1.DataSource = nwDataSet1.Orders;

            var q = from n in nwDataSet1.Orders
                    group n by n.OrderDate.Year into g
                    select new
                    {
                        Year = g.Key,
                        Count = g.Count(),
                    };

            this.dataGridView2.DataSource = q.ToList();
            //========================

            var count = nwDataSet1.Orders.Where(n => n.OrderDate.Year == 1997).Count();
            MessageBox.Show(count.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "I have a pen, I have an apple, Ah! Applepen! ";

            char[] chars = { ' ', '.', ',', '!' };
            string[] words = s.Split(chars);

            var q = from w in words
                    where w != ""
                    group w by w.ToUpper() into g
                    select new { Words = g.Key, Count = g.Count() };

            this.dataGridView1.DataSource = q.ToList();
        }
    }
}
