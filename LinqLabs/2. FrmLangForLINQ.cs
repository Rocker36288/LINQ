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
    }
}
