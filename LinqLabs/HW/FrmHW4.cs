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

        private void btnProductPrice_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(nwDataSet1.Products);
            
            var q = from n in nwDataSet1.Products
                    group n by n.UnitPrice < 30 ? "<30元" : n.UnitPrice < 60 ? "30~59元" : "60元以上" into g
                    select new { Price = g.Key, Count = g.Count(), MyGroup = g };

            this.dataGridView1.DataSource = nwDataSet1.Products;
            this.dataGridView2.DataSource = q.ToList();

            foreach (var group in q)
            {
                string header = $"{group.Price},({group.Count})";
                TreeNode pNode = this.treeView1.Nodes.Add(header);
                foreach (var item in group.MyGroup)
                {
                    pNode.Nodes.Add(item.ToString());
                }
            }
        }
    }
}
