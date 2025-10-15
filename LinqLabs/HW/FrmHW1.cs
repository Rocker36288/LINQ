using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs.HW
{
    public partial class FrmHW1 : Form
    {
        public FrmHW1()
        {
            InitializeComponent();
            var extension = dir.GetFiles().Select(p=>p.Extension).Distinct().ToList();     
            this.comboBox1.DataSource = extension;

            var filesAll = dir.GetFiles().ToList();
            this.dataGridViewMain.DataSource = filesAll;
            this.lblMain.Text = $"C:\\windows 檔案總共有{filesAll.Count}筆";
        }
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
        private void ShowResult(FileInfo[] files)
        {
            this.lblDetail.Text = $"Count ={files.Length} 筆";
            this.dataGridViewDetail.DataSource = files;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //System.IO.FileInfo[] files = (from p in dir.GetFiles()
            //                              where p.Extension ==".exe"
            //                              orderby p.Name
            //                              select p).ToArray();

            System.IO.FileInfo[] files = dir.GetFiles("*.exe");

            ShowResult(files);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = (from p in dir.GetFiles()
                                          where p.CreationTime.Year == 2025
                                          orderby p.CreationTime
                                          select p).ToArray();
            ShowResult(files);
        }

        private void btnLargeFile_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo[] files = (from p in dir.GetFiles()
                                          where p.Length >= 1024
                                          orderby p.Length
                                          select p).ToArray();
            ShowResult(files);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ex = this.comboBox1.Text;

            System.IO.FileInfo[] files = (from p in dir.GetFiles()
                                          where p.Extension == ex
                                          select p).ToArray();
            ShowResult(files);

        }
    }
}
