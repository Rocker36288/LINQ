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
        }
        NorthwindEntities dbContext = new NorthwindEntities();

        private void button1_Click(object sender, EventArgs e)
        {

            var q = dbContext.Products.Where(n => n.UnitPrice > 30);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.Categories.First().Products.ToList();

            MessageBox.Show(dbContext.Products.First().Category.CategoryName);
        }
    }
}
