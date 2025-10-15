using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmLINQ架構介紹_InsideLINQ : Form
    {
        public FrmLINQ架構介紹_InsideLINQ()
        {
            InitializeComponent();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(3);
            arrayList.Add(5);
            arrayList.Add(7);

            var q = from n in arrayList.Cast<int>()
                    where n > 3
                    select new { N = n };   //設定匿名型別
            //select n;
            // n 沒有屬性，所以dataGridView沒有辦法顯示出來
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  When execute query q=...
            //  1.  foreach (...in q)
            //  2.  ToXXX()
            //  3.  Aggregation

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            this.listBox1.Items.Add("Sum = " + nums.Sum());
            this.listBox1.Items.Add("Min = " + nums.Min());
            this.listBox1.Items.Add("Max = " + nums.Max());
            this.listBox1.Items.Add("Avg = " + nums.Average());
            this.listBox1.Items.Add("Count = " + nums.Count());

            //========================
            this.productsTableAdapter1.Fill(nwDataSet1.Products);

            this.listBox1.Items.Add($"Price Sum = {nwDataSet1.Products.Sum(p => p.UnitPrice):C2}");
            this.listBox1.Items.Add($"Price Min = {nwDataSet1.Products.Min(p => p.UnitPrice):C2}");
            this.listBox1.Items.Add($"Price Max = {nwDataSet1.Products.Max(p => p.UnitPrice):C2}");
            this.listBox1.Items.Add($"Price Avg = {nwDataSet1.Products.Average(p => p.UnitPrice):C2}");
            this.listBox1.Items.Add($"Price Count = {nwDataSet1.Products.Count():C2}");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(nwDataSet1.Products);

            var q = (from p in nwDataSet1.Products
                     where p.UnitPrice > 30
                     orderby p.UnitPrice descending
                     select p).Take(5);

            this.dataGridView1.DataSource = q.ToList();
        }
    }
}