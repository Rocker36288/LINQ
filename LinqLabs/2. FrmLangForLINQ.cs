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
    //Notes: LINQ 主要參考 
    //組件 System.Core.dll,
    //namespace {}  System.Linq
    //public static class Enumerable
    //


    //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);


    //1. 泛型 (泛用方法)                                          (ex.  void SwapAnyType<T>(ref T a, ref T b)
    //2. 委派參數 Lambda Expression (匿名方法簡潔版)               (ex.  List<int> MyWhere(nums, n => n %2==0);
    //3. Iterator                                                (ex.  MyIterator)
    //4. 擴充方法                                                 (ex.  MyStringExtend.WordCount(s);

    public partial class FrmLangForLINQ : Form
    {
        public FrmLangForLINQ()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            MessageBox.Show(n1 + "," + n2);

            Swap(ref n1, ref n2);

            MessageBox.Show(n1 + "," + n2);

            //===========================

            string s1 = "aa", s2 = "bb";
            MessageBox.Show(s1 + "," + s2);

            Swap(ref s1, ref s2);

            MessageBox.Show(s1 + "," + s2);
        }

        private void Swap(ref int n1, ref int n2)
        {
            int m1 = n1, m2 = n2;

            n1 = m2;
            n2 = m1;
        }
        private void Swap(ref string n1, ref string n2)
        {
            string m1 = n1, m2 = n2;

            n1 = m2;
            n2 = m1;
        }
        private void SwapAnyType<T>(ref T n1, ref T n2)
        {
            T m1 = n1, m2 = n2;
            n1 = m2;
            n2 = m1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            MessageBox.Show(n1 + "," + n2);

            SwapAnyType<int>(ref n1, ref n2);

            MessageBox.Show(n1 + "," + n2);

            //===========================

            string s1 = "aa", s2 = "bb";
            MessageBox.Show(s1 + "," + s2);

            SwapAnyType(ref s1, ref s2);        //<>裡面沒寫string也可以，會自動判斷型別

            MessageBox.Show(s1 + "," + s2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  C#1.0  具名方法
            this.buttonX.Click += buttonX_click;
            this.buttonX.Click += aaa;
            this.buttonX.Click += new EventHandler(bbb);

            //========================
            //  C#2.0   匿名方法
            this.buttonX.Click += delegate (object sender1, EventArgs e1)
            { MessageBox.Show("匿名方法"); };

            //========================
            //  C#3.0   匿名方法    lambda => goes to
            this.buttonX.Click += (object sender1, EventArgs e1)
                =>
            { MessageBox.Show("匿名方法 lambda"); };

        }

        private void bbb(object sender, EventArgs e)
        {
            MessageBox.Show("bbb");
        }

        private void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }

        private void buttonX_click(object sender, EventArgs e)
        {
            MessageBox.Show("buttonX_click");
        }

        //  1.  define delegate Class
        //  2.  define delegate Object
        //  3.  call方法  /   Invoke Method
        public delegate bool MyDelegate(int n);
        private void button9_Click(object sender, EventArgs e)
        {
            bool result;
            result = Test(8);

            //========================
            //  C#1.0  具名方法

            MyDelegate delegateObj = new MyDelegate(Test);

            result = delegateObj.Invoke(9);

            //========================

            delegateObj = IsEven;
            result = delegateObj(9);

            //========================
            //  C#2.0   匿名方法

            delegateObj = delegate (int n)
            { return n > 5; };

            result = delegateObj(9);

            //========================
            //  C#3.0   匿名方法    lambda => goes to
            //  lambda 運算式 是建立委派最精簡的方法 (沒參數型別 / 沒return => 非常高階的抽象寫法)
            delegateObj = n => n > 5;
            result = delegateObj(9);

            MessageBox.Show("result=" + result);
        }

        bool IsOdd(int n)
        {
            return (n % 2 == 1);
        }

        bool IsEven(int n)
        {
            return (n % 2 == 0);
        }

        bool Test(int n)
        {
            return n > 5;
        }
        public List<int> MyWhere(int[] nums, MyDelegate delegateObj)
        {
            List<int> list = new List<int>();

            foreach (int n in nums)
            {
                if (delegateObj(n))
                {
                    list.Add(n);
                }
            }
            return list;
        }
        public IEnumerable<int> MyIterator(int[] nums, MyDelegate delegateObj)
        {

            foreach (int n in nums)
            {
                if (delegateObj(n))
                {
                    yield return n;
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //  具名方法 

            //List<int> largelist = MyWhere(nums, Test);
            //List<int> isEvenlist = MyWhere(nums, IsEven);
            //List<int> isOddlist = MyWhere(nums, IsOdd);

            //========================
            //  C#3.0   匿名方法    lambda => goes to

            List<int> largelist = MyWhere(nums, n => n > 5);
            List<int> isEvenlist = MyWhere(nums, n => n % 2 == 0);
            List<int> isOddlist = MyWhere(nums, n => n % 2 == 1);


            foreach (int n in isEvenlist)
            {
                this.listBox1.Items.Add(n);
            }

            foreach (int n in isOddlist)
            {
                this.listBox2.Items.Add(n);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //IEnumerable<int> q = from n in nums
            //where n % 2 == 0
            //select n;

            IEnumerable<int> q = nums.Where(n => n % 2 == 0);

            foreach (int n in q)
            {
                listBox1.Items.Add(n);
            }

            string[] words = { "aaa", "bbbb", "ccccc" };

            IEnumerable<string> q1 = words.Where(w => w.Length > 3);

            foreach (string s in q1)
            {
                listBox2.Items.Add(s);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> q = MyIterator(nums, n => n % 2 == 0);

            foreach (int n in q)
            {
                listBox1.Items.Add(n);
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            int n = 100;
            var n1 = 200;

            var s = "abcde";
            s.ToUpper();

            var p = new Point(n, n);
            p.X = 20;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.Font = new Font("微軟正黑體", 10, FontStyle.Bold);

            //========================
            //  C#3.0   {} object initialize 物件初始化

            Point p1 = new Point { X = 1, Y = 2 };
            Point p2 = new Point { X = 10 };
            Point p3 = new Point { Y = 20 };

            List<Point> list = new List<Point>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(new Point { X = 100 });

            this.dataGridView1.DataSource = list;

            //========================
            //  C#3.0   集合初始化

            List<Point> list2 = new List<Point>
            {
               new Point{ X = 1, Y = 2 },
               new Point{ X = 10 },
               new Point{ Y = 20 },
            };

            this.dataGridView2.DataSource = list2;

        }

        private void button43_Click(object sender, EventArgs e)
        {
            var p1 = new { X = 1, Y = 2, Z = 3 };
            //MessageBox.Show($"{p1.X},{p1.Y},{p1.Z}");

            this.listBox1.Items.Add(p1.GetType());

            var p2 = new { X = 1, Y = 2, Z = 3 };
            var p3 = new { X = 1, Y = 2, Z = 3 };
            this.listBox1.Items.Add(p2.GetType());
            this.listBox1.Items.Add(p3.GetType());

            //========================
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var q = from n in nums
            //where n > 5
            //select new { N = n, N2 = n * 2, N3 = n * 3 };

            var q = nums.Where(n => n > 5).Select(n => new { N = n, N2 = n * 2, N3 = n * 3 });

            this.dataGridView1.DataSource = q.ToList();

            //========================
            this.productsTableAdapter1.Fill(nwDataSet1.Products);

            //var q2 = from p in this.nwDataSet1.Products
            //         where p.UnitPrice > 30
            //         select new
            //         {
            //             ID = p.ProductID,
            //             Name = p.ProductName,
            //             p.UnitPrice,
            //             p.UnitsInStock,
            //             TotalPrice = $"{(p.UnitPrice * p.UnitsInStock):C2}"
            //         };
            //========================

            var q2 = nwDataSet1.Products.Where(n => n.UnitPrice > 30).Select(p => new
            {
                ID = p.ProductID,
                Name = p.ProductName,
                p.UnitPrice,
                p.UnitsInStock,
                TotalPrice = $"{(p.UnitPrice * p.UnitsInStock):C2}"
            });

            this.dataGridView2.DataSource = q2.ToList();


        }

        private void button32_Click(object sender, EventArgs e)
        {
            string s = "abcde";
            int count = s.WordCount();

            string s1 = "123456789";
            count = s1.WordCount();
            //count = MyString.WordCount(s1);
            
            MessageBox.Show("count=" + count);
            //========================
            char ch = s1.Chars(0);
            
            MessageBox.Show("Char=" + ch);

        }
    }
}

public static class MyString
{
    public static int WordCount(this string s)
    {
        return s.Length;
    }
    public static char Chars(this string s, int index)
    {
        return s[index];
    }

}
//'MyString': 無法衍生自密封類型 'string'
//class MyString : String
//{ 
//    WordCount....
//}

