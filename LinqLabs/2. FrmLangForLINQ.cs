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

        private void Swap(ref int n1,ref int n2)
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
    }
}
