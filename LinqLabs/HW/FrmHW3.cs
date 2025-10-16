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
    public partial class FrmHW3 : Form
    {
        List<Student> s_score;
        public FrmHW3()
        {
            InitializeComponent();
            s_score = new List<Student>()
            {
                new Student{ Name = "大雄", Class = "C101", Chinese = 10, English = 0, Math = 10, Gender = "Male" },
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

        }

        private void btnClassScore_Click(object sender, EventArgs e)
        {

        }

    }
}
