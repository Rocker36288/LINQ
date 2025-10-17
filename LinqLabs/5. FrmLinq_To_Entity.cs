using LinqLabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmLinq_To_Entity : Form
    {
        public FrmLinq_To_Entity()
        {
            InitializeComponent();

            dbContext.Database.Log = Console.Write;     //看SQL指令用 會耗效能
            //Console.Write("123");
        }
        NorthwindEntities dbContext = new NorthwindEntities();

        private void button1_Click(object sender, EventArgs e)
        {

            var q = dbContext.Products.Where(n => n.UnitPrice > 30);
            dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Categories.First().Products.ToList();

            MessageBox.Show(dbContext.Products.First().Category.CategoryName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Sales_by_Year(new DateTime(1997, 1, 1), DateTime.Now);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products
                    orderby p.UnitsInStock descending, p.ProductID
                    select p;

            dataGridView1.DataSource = q.ToList();
            //========================

            var q2 = dbContext.Products.OrderByDescending(p => p.UnitsInStock)
                                       .ThenBy(p => p.ProductID);

            dataGridView2.DataSource = q2.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q2 = dbContext.Products.ToList()    //也可用.AsEnumerable() 用記憶體先存起來 存成IEnumerable<T>
                                       .OrderByDescending(p => p.UnitsInStock)
                                       .ThenBy(p => p.ProductID)
                                       .Select(p => new
                                       {
                                           p.ProductID,
                                           p.ProductName,
                                           p.UnitPrice,
                                           p.UnitsInStock,
                                           TotalPrice = $"{p.UnitPrice * p.UnitsInStock:C2}"
                                       });

            dataGridView2.DataSource = q2.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products
                    group p by p.Category.CategoryName into g
                    select new { CategoryName = g.Key, AvgPrice = g.Average(p => p.UnitPrice) };

            dataGridView1.DataSource = q.ToList();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products
                    select new { p.CategoryID, p.Category.CategoryName, p.ProductID, p.UnitPrice, p.UnitsInStock, };

            dataGridView1.DataSource = q.ToList();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            var q = from o in dbContext.Orders
                    group o by o.OrderDate.Value.Year into g
                    select new { Year = g.Key, Count = g.Count() };

            dataGridView1.DataSource = q.ToList();

        }

        private void button55_Click(object sender, EventArgs e)
        {
            Product product = new Product { ProductName = "123" + DateTime.Now.ToLongTimeString(), Discontinued = true };
            this.dbContext.Products.Add(product);

            this.dbContext.SaveChanges();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbContext.Products.ToList();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Product product = this.dbContext.Products.Where(p => p.ProductName.Contains("123")).FirstOrDefault();
            if (product != null)
            {
                product.ProductName += "456";
            }
            this.dbContext.SaveChanges();
            RefreshDataGridView();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            Product product = this.dbContext.Products.Where(p => p.ProductName.Contains("123")).FirstOrDefault();
            if (product != null)
            {
                dbContext.Products.Remove(product);
            }
            this.dbContext.SaveChanges();
            RefreshDataGridView();
        }
    }
}
