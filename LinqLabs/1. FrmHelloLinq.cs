using LinqLabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmHelloLinq : Form
    {
        public FrmHelloLinq()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in list)
            {
                this.listBox1.Items.Add(i);
            }

            //=========================================
            this.listBox1.Items.Add("================");
            //C#內部轉譯//=========================================
            //C#內部轉譯
            List<int>.Enumerator en = list.GetEnumerator();

            while (en.MoveNext())
            {
                this.listBox1.Items.Add(en.Current);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in num)
            {
                this.listBox1.Items.Add(i);
            }

            this.listBox1.Items.Add("================");
            //=========================================
            //C#內部轉譯
            System.Collections.IEnumerator en = num.GetEnumerator();

            while (en.MoveNext())
            {
                this.listBox1.Items.Add(en.Current);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int w = 100;
            //foreach (int i in w)
            //    因為 'int' 不包含 'GetEnumerator' 的公用執行個體或延伸模組定義，
            //    所以 foreach 陳述式無法在型別 'int' 的變數上運作

            string s = "abcde";
            foreach (char ch in s)
            {
                this.listBox1.Items.Add(ch);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1: define sourse
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // 2: define query
            IEnumerable<int> q = from n in nums
                                     //where n % 2 == 0
                                     //where n >= 5 && n <= 8
                                 where n < 3 || n > 10
                                 select n;

            // 3: execute query
            foreach (int i in q)
            {
                this.listBox1.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool result = false && A();
            MessageBox.Show(result.ToString());
        }

        private bool A()
        {
            MessageBox.Show("A");
            return true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            IEnumerable<int> q = from n in nums
                                 where IsEven(n)
                                 select n;

            foreach (int i in q)
            {
                this.listBox1.Items.Add(i);
            }
        }

        private bool IsEven(int n)
        {
            return n % 2 == 0;

            //
            //if (n % 2 == 0)
            //{
            //return true;
            //}
            //else
            //{
            //return false;
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            IEnumerable<Point> q = from n in nums
                                   where IsEven(n)    //n % 2 == 0
                                   select new Point(n, n * n);

            foreach (Point i in q)
            {
                this.listBox1.Items.Add(i); //i.X + ", " + i.Y
            }

            List<Point> list = q.ToList();  //back foreach(.....in q)
            this.dataGridView1.DataSource = list;

            this.chart1.DataSource = list;
            this.chart1.Series[0].XValueMember = "X";
            this.chart1.Series[0].YValueMembers = "Y";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = { "aaa", "Apple", "pineapple", "xxxApple" };

            IEnumerable<string> q = from w in words
                                    where w.ToLower().Contains("apple") && w.Length > 5
                                    select w;

            foreach (string s in q)
            {
                this.listBox1.Items.Add(s);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);

            IEnumerable<NWDataSet.ProductsRow> q = from p in this.nwDataSet1.Products
                                                   where !p.IsUnitPriceNull() && p.UnitPrice > 30 && p.ProductName.StartsWith("C")
                                                   orderby p.UnitPrice
                                                   select p;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);

            IEnumerable<NWDataSet.OrdersRow> q = from p in this.nwDataSet1.Orders
                                                 where p.OrderDate.Year == 1997 && 
                                                 (p.OrderDate.Month >= 1 && p.OrderDate.Month <= 3) 
                                                 orderby p.OrderDate
                                                 select p;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID;

            MessageBox.Show("OrderID =" + this.dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
