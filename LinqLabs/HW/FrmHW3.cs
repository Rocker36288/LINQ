using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LinqLabs.HW
{
    public partial class FrmHW3 : Form
    {
        List<Student> s_score;
        public FrmHW3()
        {
            InitializeComponent();
            s_score = new List<Student>()
            {
                new Student{ Name = "大雄", Class = "C101", Chinese = 10, English = 5, Math = 10, Gender = "Male" },
                new Student{ Name = "靜香", Class = "C101", Chinese = 95, English = 90, Math = 90, Gender = "Female" },
                new Student{ Name = "胖虎", Class = "C101", Chinese = 65, English = 70, Math = 60, Gender = "Male" },
                new Student{ Name = "小夫", Class = "C102", Chinese = 70, English = 80, Math = 70, Gender = "Male" },
                new Student{ Name = "小杉", Class = "C102", Chinese = 100, English = 100, Math = 100, Gender = "Male" },
                new Student{ Name = "多拉A夢", Class = "C102", Chinese = 95, English = 95, Math = 95, Gender = "Male" },
            };
        }
        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Chinese { get; set; }
            public int English { get; internal set; }
            public int Math { get; set; }
            public string Gender { get; set; }
        }
        private void FrmHW3_Load(object sender, EventArgs e)
        {
            List<string> _class = s_score.Select(x => x.Class).Distinct().ToList();
            this.comboBoxClass.DataSource = _class;

            List<string> _name = s_score.Select(x => x.Name).Distinct().ToList();
            this.comboBoxStudent.DataSource = _name;

            this.dataGridView1.DataSource = s_score;
            this.chart1.DataSource = s_score.ToList();
            ShowChart();
        }
        private void ShowChart()
        {
            this.chart1.Series[0].XValueMember = "Name";
            this.chart1.Series[0].YValueMembers = "Chinese";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart1.Series[1].XValueMember = "Name";
            this.chart1.Series[1].YValueMembers = "English";
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart1.Series[2].XValueMember = "Name";
            this.chart1.Series[2].YValueMembers = "Math";
            this.chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }


        private void btnClassScore_Click(object sender, EventArgs e)
        {
            var q = s_score.Where(n => n.Class == comboBoxClass.Text);
            //var q = from n in s_score
            //where n.Class == comboBoxClass.Text
            //select new 
            //{
            //Name = n.Name,
            //Class = n.Class,
            //Chinese = n.Chinese,
            //English = n.English,
            //Math = n.Math,
            //Gender = n.Gender,
            //};
            this.dataGridView1.DataSource = q.ToList();
            this.chart1.DataSource = q.ToList();
            ShowChart();
        }

        private void btnStudentScore_Click(object sender, EventArgs e)
        {
            var q = s_score.Where(n => n.Name == comboBoxStudent.Text);

            this.dataGridView1.DataSource = q.ToList();
            this.chart1.DataSource = q.ToList();
            ShowChart();
        }

        private void btnRandom3Group_Click(object sender, EventArgs e)
        {
            List<Student> r_score = new List<Student>();
            int n = 0;
            {
                for (int i = 0; i < 100; i++)
                {
                    RandomScore(ref n);
                    r_score.Add(new Student { Name = $"學生{i + 1}", Math = n });
                }
            }
            var q1 = from p in r_score
                     select new { p.Name , p.Math };

            var q2 = from p in r_score
                    group p by (p.Math >= 60 ? ">=60" :p.Math >=40? "40~59":"<40") into g
                    select new ScoreGroup
                    {
                        狀態 = g.Key,
                        人數 = g.Count()
                    };

            dataGridView1.DataSource = q1.ToList();
            dataGridView2.DataSource = q2.ToList();
            
        }
        public class ScoreGroup
        {
            public string 狀態 { get; set; }
            public int 人數 { get; set; }
        }

        private static Random rd = new Random();

        private static void RandomScore(ref int n)
        {
            n = rd.Next(0, 101);
        }

        private void btnAllRandom_Click(object sender, EventArgs e)
        {

        }
    }
}
