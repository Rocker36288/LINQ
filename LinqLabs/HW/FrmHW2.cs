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
    public partial class FrmHW2 : Form
    {
        NorthwindEntities db = new NorthwindEntities();

        public FrmHW2()
        {
            InitializeComponent();
            //ordersTableAdapter1.Fill(db.Orders);
            //order_DetailsTableAdapter1.Fill(db.Order_Details);

            List<int> q = (from p in db.Orders
                           select p.OrderDate.Value.Year).Distinct().OrderBy(n => n).ToList();

            this.comboBoxYear.DataSource = q;

        }

        private IEnumerable<Order> _ordersAll;
        private IEnumerable<Order> _orders;

        private int _pages;
        private int _count;


        public void ShowlabelResult()
        {
            this.lblOrders.Text = $"訂單 共{_ordersAll.Count()}筆";
            this.lblOD.Text = $"訂單 共{dataGridViewOD.RowCount}筆";
        }
        public void SetRows()
        {
            if (string.IsNullOrWhiteSpace(txtCount.Text))
            {
                _count = 0;
                return;
            }

            if (!int.TryParse(txtCount.Text, out _count) || _count <= 0)
            {
                _count = 0;
            }
        }
        public void ShowPages()
        {
            int totalpages = (int)Math.Ceiling((double)_ordersAll.Count() / _count);

            if (_count <= 0)
            {
                _orders = _ordersAll;
                lblPages.Text = $"第 {_pages + 1} / {_pages + 1} 頁";
            }
            else
            {
                _orders = _ordersAll.Skip(_count * _pages).Take(_count);

                lblPages.Text = $"第 {_pages + 1} / {totalpages} 頁";
            }

            dataGridViewOrders.DataSource = _orders.ToList();
            ShowlabelResult();

        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            _ordersAll = db.Orders;
            SetRows();
            _pages = 0;
            ShowPages();
        }
        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            int year = (int)comboBoxYear.SelectedValue;

            _ordersAll = db.Orders.Where(p => p.OrderDate.Value.Year == year);
            SetRows();
            _pages = 0;
            ShowPages();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = (int)this.dataGridViewOrders.CurrentRow.Cells[0].Value;

            IEnumerable<Order_Detail> q = db.Order_Details.Where(p => p.OrderID == orderID);

            dataGridViewOD.DataSource = q.ToList();
            ShowlabelResult();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_pages > 0)
            {
                _pages--;
                ShowPages();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_count <= 0) return;

            int totalPages = (int)Math.Ceiling((double)_ordersAll.Count() / _count);
            if (_pages < totalPages - 1)
            {
                _pages++;
                ShowPages();
            }
        }
    }
}
